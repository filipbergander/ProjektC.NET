using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.ML.Data;


namespace Projekt.Models
{
    // Det modellen kommer tränas på
    public class SavingsGameInput
    {
        [LoadColumn(0)]
        public float CurrentBalance { get; set; } // Pengar på kontot just nu

        [LoadColumn(1)]
        public float DayOfMonth { get; set; } // Vilken dag det är i månaden, ju tidigare i månaden desto större chans ska det vara att få högre bonusen

        [LoadColumn(2)]
        public float LuckFactor { get; set; } // Extra faktor som kan påverka bonusen, 1 till 10, där 10 är mest tur och 1 är minst tur

        [LoadColumn(3)]
        public float BonusReward { get; set; } // Det som modellen ska avgöra, hur mycket bonus man kan få på sparutmaningen
    }
    // Det som modellen ska avgöra och generera, i detta fall hur mycket bonus man kan få på sparutmaningen
    public class SavingsGamePrediction
    {
        [ColumnName("Score")]
        public float BonusReward { get; set; }
    }
}
