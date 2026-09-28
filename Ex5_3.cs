namespace Ex5_3
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intAge;

            // Ask the user for their age
            Console.WriteLine("Enter your age");
            intAge = Convert.ToInt16(Console.ReadLine());

            // Check if they are under 18
            if (intAge < 18)
            {
                Console.WriteLine("Sorry, this film is not for you");
            }

            Console.ReadKey();
        }
    }
}