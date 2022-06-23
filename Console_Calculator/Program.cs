namespace Console_Calculator
{
    internal class Program
    {


        static void Main(string[] args)
        {
            double firstNum;
            double secondNum;
            string? operatr = null;

            bool keepGoin = true;
            while (keepGoin)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("       *********************************************");
                Console.WriteLine("\n           Welcome to My Calculator!\n");
                Console.WriteLine("       *********************************************");
                Console.ResetColor();

                Console.WriteLine("Add your numbers and choose the operation you want.");

                Console.Write("Number 1: ");
                while (!double.TryParse(Console.ReadLine(), out firstNum))
                {
                    Console.WriteLine("Invalid number. Try again!");
                    Console.Write("Number 1: ");
                }

                Console.Write("Select an operator: (+, -, *, /): ");
                operatr = Console.ReadLine();
               
                while
                 (operatr == null || (operatr != "+" && operatr != "-" && operatr != "*" && operatr != "/"))
                {
                        Console.WriteLine("It's not a valid operator. Try again!: ");
                        Console.Write("Select an operator: (+, -, *, /): ");
                        operatr = Console.ReadLine();
                }
                    

                Console.Write("Number 2: ");
                while (!double.TryParse(Console.ReadLine(), out secondNum))
                {
                    Console.WriteLine("Invalid number. Try again!");
                    Console.Write("Number 2: ");
                }
                if (operatr == "+")
                {
                    Console.WriteLine(Add(firstNum, secondNum));
                }
                if (operatr == "-")
                {
                    Console.WriteLine(Subtract(firstNum, secondNum));
                }
                if (operatr == "*")
                {
                    Console.WriteLine(Multiplicate(firstNum, secondNum));
                }
                if (operatr == "/")
                {
                    Console.WriteLine(Divide(firstNum, secondNum));
                }
                Console.Write("Do you want to continue y(yes)/n(no): ");
                string? input = Console.ReadLine();
                if (input != null && input.ToLower() == "n")
                {
                    keepGoin = false;
                }
                    else if (input == null || input.ToLower() != "y")
                    {
                         keepGoin = false;
                    }
                else
                {
                    Console.Clear();
                    keepGoin = true;
                }
            }
        }


        // Made Math.Round for readability sake. Not good if reel calculator....
        static double Add(double num1, double num2)
        {
            return Math.Round(((num1) +(num2)), 3);

        }
        private static double Subtract(double num1, double num2)
        {
            return Math.Round(((num1) - (num2)), 3);
        }
        static double Divide(double num1, double num2)
        {
            //double quote = 0;
            if(num2 == 0)
            {
                Console.WriteLine("You have divided by zero (0). It does not work...!");
            }
            //try
            //{
            //    while (!double.TryParse(Console.ReadLine(), out num2))                                                                                                                                                                                                   
            //    {
            //        Console.WriteLine("Invalid number. Try again!");
            //        Console.Write("Number 2: ");
            //    }
            //quote = Math.Round(((num1) / (num2)), 3);
            return Math.Round(((num1) / (num2)), 3);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            ////}
            //return quote;
        }
        static double Multiplicate(double num1, double num2)
        {
            return Math.Round(((num1) * (num2)), 3);
        }
        private static void RaisTo()
        {
            throw new NotImplementedException();
        }
        private static void RootOf()
        {
            throw new NotImplementedException();
        }
        private static void Percent()
        {
            throw new NotImplementedException();
        }




    }
}