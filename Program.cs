namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to store the user's number
            int intInput;

            // Ask the user to enter an integer
            Console.WriteLine("Enter an integer...");
            intInput = Convert.ToInt16(Console.ReadLine());

            // Check if the user entered 1
            if (intInput == 1)
            {
                Console.WriteLine("Thank you.");
            }
            // Check if the user entered 2
            else if (intInput == 2)
            {
                Console.WriteLine("That's fine.");
            }
            // Check if the user entered 3
            else if (intInput == 3)
            {
                Console.WriteLine("Too big.");
            }
            // Runs if none of the above are true
            else
            {
                Console.WriteLine("Not a number I know.");
            }

            // Wait for a key press
            Console.ReadKey();
        }
    }
}
