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

                float num_op;
                bool num_op_parse = float.TryParse(Console.ReadLine(), out num_op);
                if (num_op_parse)
                {
                    Console.WriteLine();

                    if (num_op_parse == 1)
                    {
                        private static float result_sum = createAddition(num_op_parse, num_op_parse);
                    }

                    else if (num_op_parse == 2)
                    {
                        Console.WriteLine("Put the first number of the subtraction below:");
                        float num1_sub;
                        if (num_op_parse == true)
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
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Texts are not accepted in subtraction operation.\n\n");
                        }
                    }

                    else if (num_op == 3)
                    {
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
                    }

                    else if (num_op == 4)
                    {
                        Console.WriteLine("Put the first number of the division below:");
                        float num1_div;
                        if (float.TryParse(Console.ReadLine(), out num1_div))
                        {
                            Console.WriteLine("Put the second number of the division below:");
                            float num2_div;
                            if (float.TryParse(Console.ReadLine(), out num2_div))
                            {
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
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Texts are not accepted, try the operation numbers.\n\n");
                }
            }
        }
    }

    static float createAddition()
    {
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

                return result_sum;
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
    }
    static float createSubtraction()
    {
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

                return result_sum;
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
    }
    static float createMultiplication()
    {
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

                return result_sum;
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
    }
    static float createDivision()
    {
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

                return result_sum;
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
    }
}
