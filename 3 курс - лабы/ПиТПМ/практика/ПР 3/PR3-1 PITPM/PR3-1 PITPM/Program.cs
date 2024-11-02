namespace PR3_1_PITPM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cylinder Volume Calculator");

            try
            {
                Console.Write("Enter the radius of the cylinder: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the height of the cylinder: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Cylinder cylinder = new Cylinder();
                double volume = cylinder.CalculateVolume(radius, height);

                Console.WriteLine($"The volume of the cylinder is: {volume:F2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numerical values.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
