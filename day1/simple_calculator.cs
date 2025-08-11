namespace day1
{
    class Assignment
    {
        static void Main(string[] args)
        {

            // Assignment

            Console.WriteLine("Hello!\r\nInput the first number:\r\n");
            string number1 = Console.ReadLine();
            int num1 = int.Parse(number1);
            Console.WriteLine("Input the second number:\r\n");
            string number2 = Console.ReadLine();
            int num2 = int.Parse(number2);


            Console.WriteLine();
            Console.WriteLine("What do you want to do with those numbers?\r\n" +
                "[A]dd\r\n" +
                "[S]ubtract\r\n" +
                "[M]ultiply\r\n");
            char ch;
            ch = char.ToLower(Console.ReadLine()[0]);
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("Result = " + (num1 + num2));
                    break;
                case 's':
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;
                case 'm':
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

        }
    }
}