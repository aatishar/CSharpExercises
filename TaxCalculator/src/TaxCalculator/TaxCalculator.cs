namespace TaxCalculator
{
    public class TaxCalculator
    {
        public decimal Calculate(decimal salary)
        {
            // Tax Table
            List<(decimal From, decimal To, decimal Rate)> taxTable = new()
            {
                (From: 0, To:  10_064m, Rate: 0),
                (From: 10_064m, To:  27_794m, Rate: 0.14m),
                (From: 27_794m, To:  74_517m, Rate: 0.30m),
                (From: 74_517m, To:  157_806m, Rate: 0.41m),
                (From: 157_806m, To:  decimal.MaxValue, Rate: 0.45m),
            };

            // Taxable salary
            var percentTaxable = 0.90m;
            var taxableSalary = salary * percentTaxable;
            var remainingTaxableSalary = taxableSalary;

            // Total tax
            var totalTax = 0m;

            foreach (var taxRange in taxTable)
            {
                if (taxableSalary > taxRange.To)
                {
                    var range = taxRange.To - taxRange.From;
                    totalTax += range * taxRange.Rate;
                    remainingTaxableSalary -= range;
                } 
                else if(taxableSalary < taxRange.To)
                {
                    totalTax += remainingTaxableSalary * taxRange.Rate;
                    break;
                }

                if (remainingTaxableSalary == 0)
                {
                    break;
                }
            }

            return totalTax;
        }
    }
}
