namespace Ex5_1_Using_Switch
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intAnswer;

            Console.WriteLine("What is 24 + 9?");
            intAnswer = Convert.ToInt16(Console.ReadLine());

            switch (intAnswer)
            {
                case 33:
                    Console.WriteLine("Excellent");
                    break;

                default:
                    Console.WriteLine("Incorrect");
                    break;
            }

            Console.ReadKey();
        }
    }
}