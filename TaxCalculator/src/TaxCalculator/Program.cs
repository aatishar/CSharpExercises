using System.Globalization;

var taxCalculator = new TaxCalculator.TaxCalculator();
var exit = false;

Console.Title = "Tax Calculator";
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("*********************************");
Console.WriteLine("*         Tax Calculator        *");
Console.WriteLine("*********************************");

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Enter Salary (Rs): ");
    var input = Console.ReadLine();
    if (input?.Contains("exit") ?? false)
    {
        exit = true;
    }

    if (decimal.TryParse(input, out var salary))
    {
        var totalTax = taxCalculator.Calculate(salary);

        
        Console.Write("Total Tax: ");
        Console.WriteLine(totalTax.ToString("C2", CultureInfo.CreateSpecificCulture("en-MU")));

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("---------------------------------");
    }

} while (!exit);

