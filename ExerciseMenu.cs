namespace Ex5
{
    internal class ExerciseMenu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an exercise:");
                Console.WriteLine("1 - Program.cs (enter an integer)");
                Console.WriteLine("2 - Ex5_1.cs (24 + 9)");
                Console.WriteLine("3 - Ex5_2.cs");
                Console.WriteLine("4 - Ex5_3.cs");
                Console.WriteLine("5 - Ex5_4.cs");
                Console.WriteLine("6 - Ex5_5.cs");
                Console.WriteLine("7 - Ex5_6.cs");
                Console.WriteLine("8 - Ex5_1_Switch.cs");
                Console.WriteLine("9 - Ex5_2_Switch.cs");
                Console.WriteLine("10 - Ex5_3_Switch.cs");
                Console.WriteLine("11 - Ex5_4_Switch.cs");
                Console.WriteLine("12 - Ex5_5_Switch.cs");
                Console.WriteLine("0 - Exit");

                string? choice = Console.ReadLine();

                if (choice == "0" || choice == null)
                {
                    return;
                }
                else if (choice == "1")
                {
                    Program.Main(args);
                }
                else if (choice == "2")
                {
                    Ex5_1.Program.Main(args);
                }
                else if (choice == "3")
                {
                    Ex5_2.Program.Main(args);
                }
                else if (choice == "4")
                {
                    Ex5_3.Program.Main(args);
                }
                else if (choice == "5")
                {
                    Ex5_4.Program.Main(args);
                }
                else if (choice == "6")
                {
                    Ex5_5.Program.Main(args);
                }
                else if (choice == "7")
                {
                    Ex5_6.Program.Main(args);
                }
                else if (choice == "8")
                {
                    Ex5_1_Using_Switch.Program.Main(args);
                }
                else if (choice == "9")
                {
                    Ex5_2_Using_Switch.Program.Main(args);
                }
                else if (choice == "10")
                {
                    Ex5_3_Using_Switch.Program.Main(args);
                }
                else if (choice == "11")
                {
                    Ex5_4_Using_Switch.Program.Main(args);
                }
                else if (choice == "12")
                {
                    Ex5_5_Using_Switch.Program.Main(args);
                }
                else
                {
                    Console.WriteLine("Please enter 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 or 0.");
                }

                Console.WriteLine();
            }
        }
    }
}
