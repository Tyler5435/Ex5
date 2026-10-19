namespace Ex5_5_Using_Switch
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int intNumber;

            Console.WriteLine("Enter a number between 1 and 10");
            intNumber = Convert.ToInt16(Console.ReadLine());

            switch (intNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Number is in range");
                    break;

                default:
                    Console.WriteLine("Sorry...out of range");
                    break;
            }

            Console.ReadKey();
        }
    }
}