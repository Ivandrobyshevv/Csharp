namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        
        {
            string number1 = "";
            string number2 = "";
            string next = "";



            do
            { 
                Console.WriteLine("Введите первое целое число и нажмите клавишу Enter:");
                number1 = Console.ReadLine();

                int intnumber1 = Convert.ToInt32(number1);

                Console.WriteLine("Введите второе целое число и нажмите клавишу Enter:");
                number2 = Console.ReadLine();

                int intnumber2 = Convert.ToInt32(number2);

                if (intnumber1 > intnumber2)
                    {
                        Console.WriteLine($"Число {number1} больше числа {number2}");
                    }

                    if (intnumber1 < intnumber2)
                    {
                        Console.WriteLine($"Число {number1} меньше числа {number2}");
                    }

                    if (intnumber1 == intnumber2)
                    {
                        Console.WriteLine($"Число {number1} равно числу {number2}");
                    }

                Console.WriteLine("Повторить операцию введите y|n?");
                next = Console.ReadLine();

            } while (next != "n");
        }
    }
}