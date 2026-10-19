namespace Ex5_2_Using_Switch
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intAnswer;

            Console.WriteLine("How many in a baker's dozen?");
            intAnswer = Convert.ToInt16(Console.ReadLine());

            switch (intAnswer)
            {
                case 13:
                    Console.WriteLine("Most excellent");
                    break;

                default:
                    Console.WriteLine("Incorrect");
                    break;
            }

            Console.ReadKey();
        }
    }
}