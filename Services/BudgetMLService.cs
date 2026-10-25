using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML;
using Microsoft.ML.FastTree;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;
using Projekt.Models;
using Projekt.Interfaces;

namespace Projekt.Services
{
    public class BudgetMLService
    {
        private readonly BudgetGameInput gameSchema;
        private readonly string dataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "budget-data.csv"); // Filsökvägen för datafilen

        public BudgetMLService(BudgetGameInput gameSchema)
        {
            this.gameSchema = gameSchema;
        }
        // Förutsäger bonusen som användaren kan ha möjlighet att få på sparutmaningen
        public float PredictGameBonus(float currentBalance, float dayOfMonth, float luckFactor)
        {
            var mlContext = new MLContext(); // Hämtar in ML-kontext
            // Kollar om datafilen finns, annars visas ett felmeddelande

            if (!File.Exists(dataPath))
            {
                MessageBox.Show($"Datafilen ''{dataPath}'' hittades inte. Se till att filen finns i projektets rotkatalog.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Laddar in datafilen med tidigare data om sparutmaningen som modellen ska tränas på
            IDataView data = mlContext.Data.LoadFromTextFile<BudgetGameInput>(dataPath, hasHeader: true, separatorChar: ',');

            // Skapar en pipeline utifrån 
            var pipeline = mlContext
                .Transforms.Concatenate("Features",
                nameof(BudgetGameInput.CurrentBalance),
                nameof(BudgetGameInput.DayOfMonth),
                nameof(BudgetGameInput.LuckFactor))
                .Append(mlContext.Regression.Trainers.FastTree(  // Använder FastTree-trainern
                    labelColumnName: nameof(BudgetGameInput.BonusReward),
                    numberOfLeaves: 4,
                    numberOfTrees: 10));

           /* Testresultat för att utvärdera hur bra modellen faktiskt fungerar
            * var cvResults = mlContext.Regression.CrossValidate(data, pipeline, numberOfFolds: 5, labelColumnName: nameof(BudgetGameInput.BonusReward)); // 5-faldig korsvalidering för att utvärdera modellen

            double averageMAE = cvResults.Average(r => r.Metrics.MeanAbsoluteError); // Medelvärdet av Mean Absolute Error
            double averageRMSE = cvResults.Average(r => r.Metrics.RootMeanSquaredError); // Medelvärdet av Root Mean Squared Error
            double averageR2 = cvResults.Average(r => r.Metrics.RSquared); // Medelvärdet av R^2

            var testMetrics = mlContext.Regression.Evaluate(cvResults[0].Model.Transform(data), labelColumnName: nameof(BudgetGameInput.BonusReward)); // Utvärderar modellen med testdata
            MessageBox.Show($"Testresultat\n" +
                $"MAE: {averageMAE:F2}\n" +
                $"MSE: {averageRMSE:F2}\n" +
                $"R: {averageR2:F2}");*/

            // Tränar modellen på data från datasetet
            var model = pipeline.Fit(data);

            var predictionEngine = mlContext.Model.CreatePredictionEngine<BudgetGameInput, BudgetGamePrediction>(model);

            // Användarens data som modellen ska utvärdera för att generera ett resultat
            var userData = new BudgetGameInput
            {
                CurrentBalance = currentBalance,
                DayOfMonth = dayOfMonth,
                LuckFactor = luckFactor
            };
            // Det som modellen förutsäger
            var finalPrediction = predictionEngine.Predict(userData);
            return finalPrediction.BonusReward;
        }


    }
}
