namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        
        {
            string number1 = "";
            string number2 = "";
            string number3 = "";
            string next = "";



            do
            { 
                Console.WriteLine("Введите первое целое число и нажмите клавишу Enter:");
                number1 = Console.ReadLine();

                int intnumber1 = Convert.ToInt32(number1);

                Console.WriteLine("Введите второе целое число и нажмите клавишу Enter:");
                number2 = Console.ReadLine();

                int intnumber2 = Convert.ToInt32(number2);

                Console.WriteLine("Введите трерье целое число и нажмите клавишу Enter:");
                number3 = Console.ReadLine();

                int intnumber3 = Convert.ToInt32(number3);

                    if (intnumber2 < intnumber1 && intnumber3 < intnumber1)
                    {
                        Console.WriteLine($"Среди {number1}, {number2}, {number3} - max: {number1}");
                    }

                    if (intnumber1 < intnumber2 && intnumber3 < intnumber2)
                    {
                        Console.WriteLine($"Среди {number1}, {number2}, {number3} - max: {number2}");
                    }

                    if (intnumber1 < intnumber3 && intnumber2 < intnumber3)
                    {
 
                        Console.WriteLine($"Среди {number1}, {number2}, {number3} - max: {number3}");
                    }

                    if (intnumber1 == intnumber3 && intnumber2 == intnumber3)
                    {
 
                        Console.WriteLine($"Числа {number1}, {number2}, {number3} равны");
                    }
                    
                Console.WriteLine("Повторить операцию введите y|n?");
                next = Console.ReadLine();

            } while (next != "n");
        }
    }
}