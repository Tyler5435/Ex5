namespace Ex5_6
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intNumber1, intNumber2;

            // Ask for the first number
            Console.WriteLine("Enter the first number");
            intNumber1 = Convert.ToInt16(Console.ReadLine());

            // Ask for the second number
            Console.WriteLine("Enter the second number");
            intNumber2 = Convert.ToInt16(Console.ReadLine());

            // Check if both numbers are equal
            if (intNumber1 == intNumber2)
            {
                Console.WriteLine("The numbers are equal");
            }
            // Check if the first number is bigger
            else if (intNumber1 > intNumber2)
            {
                Console.WriteLine("The first number is bigger");
            }
            // Otherwise the second number must be bigger
            else
            {
                Console.WriteLine("The second number is bigger");
            }

            Console.ReadKey();
        }
    }
}