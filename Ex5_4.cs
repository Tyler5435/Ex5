namespace Ex5_4
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            string strPassword;

            // Ask the user for the password
            Console.WriteLine("Enter your password");
            strPassword = Console.ReadLine();

            // Check if the password is correct
            if (strPassword == "PASSWORD")
            {
                Console.WriteLine("Welcome to the treasure");
            }
            else
            {
                Console.WriteLine("Go away, it's all mine");
            }

            Console.ReadKey();
        }
    }
}