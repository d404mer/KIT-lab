namespace PR3_2_PITPM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Percentage Calculator");

            try
            {
                Console.Write("Enter the percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the number: ");
                double number = Convert.ToDouble(Console.ReadLine());

                PercentageCalculator calculator = new PercentageCalculator();
                double result = calculator.CalculatePercentage(percentage, number);

                Console.WriteLine($"{percentage}% of {number} is: {result:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
            }
        }
    }
}
