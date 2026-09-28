namespace Ex5_2
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intAnswer;

            Console.WriteLine("How many in a baker's dozen?");
            intAnswer = Convert.ToInt16(Console.ReadLine());

            if (intAnswer == 13)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
            
            Console.ReadKey();
        }
    }
}