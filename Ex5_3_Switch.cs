namespace Ex5_3_Using_Switch
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intAge;

            Console.WriteLine("Enter your age");
            intAge = Convert.ToInt16(Console.ReadLine());

            switch (intAge)
            {
                case < 18:
                    Console.WriteLine("Sorry, this film is not for you");
                    break;

                default:
                    Console.WriteLine("You can watch the film");
                    break;
            }

            Console.ReadKey();
        }
    }
}