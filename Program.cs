internal class CalculatorCSL
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Welcome to the Inicio simple logic:");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Kindly enter the first number:");
        double Num1;
        if (!double.TryParse(Console.ReadLine(), out Num1))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter the operator (+, -, *, /):");
        string op = Console.ReadLine();

        if (!isValidOperator(op))
        {
            Console.WriteLine("Invalid operator");
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Kindly enter the second number:");
        double Num2;
        if (!double.TryParse(Console.ReadLine(), out Num2))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        /*double Result = 0;
        if (op == "+")
        {
            Result = Num1 + Num2;
        }
        else if (op == "-")
        {
            Result = Num1 - Num2;
        }
        else if (op == "*")
        {
            Result = Num1 * Num2;
        }
        else if (op == "/")
        {
            if (Num2 != 0)
            {
                Result = Num1 / Num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed");
                return;
            }
        }
*/
        double Result = 0;
        switch(op)
        {
            case "+":
                Result= Num1 + Num2;
                break;
            case "-":
                Result= Num1 - Num2;
                break; 
            case "*":
                Result= Num1 * Num2;
                break;
            case "/":
                if(Num2!=0)
                {
                    Result=Num1 / Num2;
                }
                else { 
                    Console.WriteLine("Division by Zero is not allowed"); 
                return;
                }
                break;
                default:
                Console.WriteLine("Invalid operator");
                return;
        }    

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("This is your Result: " + Result);
    }

    static bool isValidOperator(string op)
    {
        return op == "+" || op == "-" || op == "*" || op == "/";
    }
}