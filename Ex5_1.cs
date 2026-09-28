namespace Ex5_1
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intAnswer;

            Console.WriteLine("What is 24 + 9?");
            intAnswer = int.Parse(Console.ReadLine());

            if (intAnswer == 33)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. The answer is 33.");
            }
        }
    }
}
