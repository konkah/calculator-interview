namespace CI_1_SwitchCase_TryParse
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

                float num_op;
                float.TryParse(Console.ReadLine(), out num_op);
                Console.WriteLine();

                switch (num_op)
                {
                    case 1:
                        Console.WriteLine("Put the first number of the addition below:");
                        float num1_sum;
                        if (float.TryParse(Console.ReadLine(), out num1_sum))
                        {
                            Console.WriteLine("Put the second number of the addition below:");
                            float num2_sum;
                            if (float.TryParse(Console.ReadLine(), out num2_sum))
                            {
                                Console.WriteLine();
                                float result_sum;
                                result_sum = num1_sum + num2_sum;

                                Console.WriteLine($"Addition's result:\n{result_sum}\n\n");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Texts are not accepted in addition operation.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Texts are not accepted in addition operation.\n\n");
                        }

                        break;

                    case 2:
                        Console.WriteLine("Put the first number of the subtraction below:");
                        float num1_sub;
                        if (float.TryParse(Console.ReadLine(), out num1_sub))
                        {
                            Console.WriteLine("Put the second number of the subtraction below:");
                            float num2_sub;
                            if (float.TryParse(Console.ReadLine(), out num2_sub))
                            {
                                Console.WriteLine();
                                float result_sub;
                                result_sub = num1_sub - num2_sub;

                                Console.WriteLine($"Subtraction's result:\n{result_sub}\n\n");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Texts are not accepted in subtraction operation.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Texts are not accepted in subtraction operation.\n\n");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Put the first number of the multiplication below:");
                        float num1_mult;
                        if (float.TryParse(Console.ReadLine(), out num1_mult))
                        {
                            Console.WriteLine("Put the second number of the multiplication below:");
                            float num2_mult;
                            if (float.TryParse(Console.ReadLine(), out num2_mult))
                            {
                                Console.WriteLine();
                                float result_mult;
                                result_mult = num1_mult * num2_mult;

                                Console.WriteLine($"Multiplication's result:\n{result_mult}\n\n");
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Texts are not accepted in multiplication operation.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Texts are not accepted in multiplication operation.\n\n");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Put the first number of the division below:");
                        float num1_div;
                        if (float.TryParse(Console.ReadLine(), out num1_div))
                        {
                            Console.WriteLine("Put the second number of the division below:");
                            float num2_div;
                            if (float.TryParse(Console.ReadLine(), out num2_div))
                            {
                                if (num2_div != 0)
                                {
                                    Console.WriteLine();
                                    float result_div;
                                    result_div = num1_div / num2_div;

                                    Console.WriteLine($"Division's result:\n{result_div}\n\n");
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("It's not possible division by 0!\n\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Texts are not accepted in division operation.\n\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Texts are not accepted in division operation.\n\n");
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
