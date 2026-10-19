namespace Ex5_5
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intNumber;

            // Ask the user for a number
            Console.WriteLine("Enter a number between 1 and 10");
            intNumber = Convert.ToInt16(Console.ReadLine());

            // Check if the number is outside the range
            if (intNumber < 1 || intNumber > 10)
            {
                Console.WriteLine("Sorry...out of range");
            }

            Console.ReadKey();
        }
    }
}