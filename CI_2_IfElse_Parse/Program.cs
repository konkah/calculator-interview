namespace CI_2_IfElse_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool system_loop = true;
            while (system_loop)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Calculator:\n");
                Console.ResetColor();
                Console.WriteLine(
                    "\x1b[93mSelect a number below for your operation:\x1b[39m\n" +
                    "1 - Addition\n" +
                    "2 - Subtraction\n" +
                    "3 - Multiplication\n" +
                    "4 - Division\n" +
                    "5 - Clear\n" +
                    "6 - Exit\n"
                 );
                Console.ResetColor();

                float num_op = float.Parse(Console.ReadLine());

                Console.WriteLine();

                if (num_op == 1)
                {
                    Console.WriteLine("Put the first number of the addition below:");
                    float num1_sum = float.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Put the second number of the addition below:");
                    float num2_sum = float.Parse(Console.ReadLine());
                    
                    Console.WriteLine();
                    float result_sum;
                    result_sum = num1_sum + num2_sum;

                    Console.WriteLine($"Addition's result:\n{result_sum}\n\n");
                }

                else if (num_op == 2)
                {
                    Console.WriteLine("Put the first number of the subtraction below:");
                    float num1_sub = float.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Put the second number of the subtraction below:");
                    float num2_sub = float.Parse(Console.ReadLine());

                    Console.WriteLine();
                    float result_sub;
                    result_sub = num1_sub - num2_sub;

                    Console.WriteLine($"Subtraction's result:\n{result_sub}\n\n");
                }

                else if (num_op == 3)
                {
                    Console.WriteLine("Put the first number of the multiplication below:");
                    float num1_mult = float.Parse(Console.ReadLine());

                    Console.WriteLine("Put the second number of the multiplication below:");
                    float num2_mult = float.Parse(Console.ReadLine());
                    
                    Console.WriteLine();
                    float result_mult;
                    result_mult = num1_mult * num2_mult;

                    Console.WriteLine($"Multiplication's result:\n{result_mult}\n\n");
                }

                else if (num_op == 4)
                {
                    Console.WriteLine("Put the first number of the division below:");
                    float num1_div = float.Parse(Console.ReadLine());

                    Console.WriteLine("Put the second number of the division below:");
                    float num2_div = float.Parse(Console.ReadLine());
                    
                    Console.WriteLine();
                    float result_div;
                    if (num2_div != 0)
                    {
                        result_div = num1_div / num2_div;
                        Console.WriteLine($"Division's result:\n{result_div}\n\n");
                    }
                    else
                    {
                        Console.WriteLine("It's not possible division by 0!\n\n");
                    }
                }

                else if (num_op == 5)
                {
                    Console.Clear();
                }

                else if (num_op == 6)
                {
                    return;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("It's a wrong option. Please select one of the operation number.\n\n");
                }
            }
        }
    }
}
