namespace Ex5_4_Using_Switch
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            string strPassword;

            Console.WriteLine("Enter your password");
            strPassword = Console.ReadLine();

            switch (strPassword)
            {
                case "PASSWORD":
                    Console.WriteLine("Welcome to the treasure");
                    break;

                default:
                    Console.WriteLine("Go away, it's all mine");
                    break;
            }

            Console.ReadKey();
        }
    }
}