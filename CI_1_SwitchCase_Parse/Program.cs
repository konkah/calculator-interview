namespace CI_1_SwitchCase_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculator:\n");
                Console.WriteLine(
                    "Select a number below for your operation:\n" +
                    "1 - Addition\n" +
                    "2 - Subtraction\n" +
                    "3 - Multiplication\n" +
                    "4 - Division\n" +
                    "5 - Clear\n" +
                    "6 - Exit\n"
                 );

                float num_op = float.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (num_op)
                {
                    case 1:
                        float result_sum = 0;

                        Console.WriteLine("Put the first number of the addition below:");
                        float num1_sum = float.Parse(Console.ReadLine());
                        Console.WriteLine("Put the second number of the addition below:");
                        float num2_sum = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        result_sum = num1_sum + num2_sum;

                        Console.WriteLine($"Addition's result:\n{result_sum}\n\n");

                        break;

                    case 2:
                        float result_sub = 0;

                        Console.WriteLine("Put the first number of the subtraction below:");
                        float num1_sub = float.Parse(Console.ReadLine());
                        Console.WriteLine("Put the second number of the subtraction below:");
                        float num2_sub = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        result_sub = num1_sub - num2_sub;

                        Console.WriteLine($"Subtraction's result:\n{result_sub}\n\n");

                        break;

                    case 3:
                        float result_mult = 0;

                        Console.WriteLine("Put the first number of the multiplication below:");
                        float num1_mult = float.Parse(Console.ReadLine());
                        Console.WriteLine("Put the second number of the multiplication below:");
                        float num2_mult = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        result_mult = num1_mult * num2_mult;

                        Console.WriteLine($"Multiplication's result:\n{result_mult}\n\n");

                        break;

                    case 4:
                        float result_div = 0;

                        Console.WriteLine("Put the first number of the division below:");
                        float num1_div = float.Parse(Console.ReadLine());
                        Console.WriteLine("Put the second number of the division below:");
                        float num2_div = float.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (num2_div != 0)
                        {
                            result_div = num1_div / num2_div;
                            Console.WriteLine($"Division's result:\n{result_div}\n\n");
                        }
                        else
                        {
                            Console.WriteLine("It's not possible division by 0!\n\n");
                        }

                        break;

                    case 5:
                        Console.Clear();

                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("It's a wrong option. Please select one of the operation number.");

                        break;

                }
            }
        }
    }
}
