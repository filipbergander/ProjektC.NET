# Projektuppgift | Programmering i C#.NET DT071G
## Budgetkoll
**Budgetkoll** skapades i Windows Forms för att ge användaren en tydlig översikt över sin privatekonomi genom att samla utgifter och inkomster i en och samma applikation. Inspiration till projektet hämtades från tidigare budgetkalkyler skapade i Microsoft Excel. För hantering av data används LINQ-syntax genom .NET-ramverket i stora delar av applikationen. Projektet skapades med utvecklingsverktyget Microsoft Visual Studio 2026 Preview och .NET.    
### Funktionalitet
* Hantering av transaktioner med CRUD-funktionalitet (Create, Read, Update, Delete).
* Sortering, filtrering och sökning bland transaktioner.
* Registrering och inloggning av användare.
* Lagring av användare och transaktioner i databas med hjälp av Entity Framework Core (EF) och SQLite.
* Sparkalkylator som beräknar hur ett sparande kan växa över tid med ränta på ränta-effekten.
* Sparutmaning som använder ML.NET för att generera och förutsäga vinster eller förluster baserat på användarens ekonomiska situation.
* Startsida med dashboard som presenterar en ekonomisk översikt över sina inkomster, utgifter och nuvarande saldo.
* Visualisering av utgifter per kategori genom ett diagram.
* Hantering av lösenord genom hashning och saltning.

<img width="1177" height="584" alt="image" src="https://github.com/user-attachments/assets/81d941ac-c758-4911-a9f6-5443dafe18c1" />


## Använd projektet:
För att köra projektet behöver .NET SDK samt EF Core CLI-verktyget (dotnet ef) vara installerade.
Installera .NET SDK och dotnet-ef CLI-verktyget med kommandot:   
`dotnet tool install --global dotnet-ef`
1. Klona ned repot och kör däreftert: `dotnet restore`
2. Skapa den initiala migreringen: `dotnet ef migrations add InitialCreate`
3. Skapa och uppdatera databasen: `dotnet ef database update`
4. Starta projektet, exempelvis i Visual Studio med: `Ctrl + F5`   
När applikationen startas skapas SQLite-databasen automatiskt och initial testdata läggs till genom SeedInitialData.

## Struktur   
Applikationen är uppbyggd i Services, Forms, Models, Interfaces och Data för att separera klasser mellan olika ansvarsområden.  

**Services:**
* **TransactionService** ansvarar för hantering av transaktioner och kommunicera med databasen.
* **UserService** ansvarar för användare och autentisering.
* **FinanceService** ansvarar för beräkningar av summor och belopp samt statistik.
* **GamingService** ansvarar för logiken i sparutmaningen.
*  **QueryService** ansvarar för filtrering, sortering och sökfunktionalitet med hjälp av LINQ.
* **BudgetMLService** ansvarar för att läsa in träningsdata, träna ML-modellen samt generera bonusbelöningar i sparutmaningen.
    
**Forms:**
* **MainForm** - applikationens nav samt startsida genom navigeringsmeny och dashboard.
*  **TransactionForm** - visar och hanterar transaktioner.
* **AddTransactionForm** - skapar och uppdaterar transaktioner.
* **SavingsForm** - innehåller sparkalkylator och sparutmaningen.
* **RegisterForm** - registrering av nya användare.
* **LoginForm** - autentisering av användare.
* **AboutForm** - information om applikationen.
  
**Models:**
* **Transaction** - representerar en transaktion med sina egenskaper som id, typ, namn, kategori, belopp och datum.
* **TransactionFilter** - används för att söka och filtrera transaktioner.
* **User** - representerar en användare med inloggningsuppgifter som användarnamn, roll samt hashat och saltat lösenord.
* **BudgetGameInput** - träningsdata till ML-modellen med variabler som saldo, dag i månaden, turfaktor och bonusbelöning.
* **BudgetGamePrediction**- bonusbelöningen som modellen ska förutsäga.

**Interfaces:**
* **ITransactionService** - kontrakt över vilka metoder transaktionsservicen ska använda.
* **IUserService** - kontrakt över vilka metoder användarservicen ska använda.

**Data:**
* **ProjektDbContext** - skapar databasen med tabellerna Transactions & Users genom EF Core.
* **SeedInitialData** - lägger till initial data när databasen skapas.

## Design och användarvänlighet
Ikoner, färger och modernt typsnitt användes för att bygga en mer modern applikation. Windows Forms kan upplevas lite äldre men det går att förbättra designen och användarupplevelsen. 

Ett användartest genomfördes för att främst utvärdera applikationens navigering, funktionalitet och användarupplevelse. Resultatet visade att applikationen upplevdes som lätt att använda, men att vissa delar kunde förbättras ytterligare genom mindre justeringar i layouten samt förtydliga olika benämningar och färger i knappar.

### Förbättringar
* **Lucida Sans** som typsnitt i hela applikationen.
* Ikoner som integrerades i applikationen med FontAwesome.Sharp.
* Färger som blått, grönt samt orange i knappar och layout.
* Navigeringsmeny på startsidan.
* En gemensam liten sidomeny längst upp i högra hörnet för att kunna stänga ned applikationen eller navigera till Hjälp (Om-sidan).

*Filip Bergander Mittuniversitetet 2026*
