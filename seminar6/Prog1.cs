namespace GB
{
    public class App
    {
        public void Program1()
        {   
            string stop = "";
            while (true)
            {   
                Console.Clear();
                string  amount = null;
                Console.WriteLine("Сколько чисел будет введено?");
                Console.WriteLine("(Для выхода введите 'q')");
                amount = Console.ReadLine();
                if (amount == "q") {break;}

                int [] numbers = new int [Convert.ToInt32(amount)];
                string digit = "";

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"\nВведите число {i+1}");
                    Console.WriteLine("(Для выхода введите 'q')");
                    
                    digit = Console.ReadLine();
                    if (digit == "q"){break;}
                    
                    numbers[i] = Convert.ToInt32(digit);
                    Console.WriteLine($"Добавили число: {digit}");
                }
                
                int count = 0;
                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        count += 1;
                    }
                }
                string total = "";
                Console.WriteLine("\nОтвет:");

                for (int i = 0; i <numbers.Length; i++)
                {
                       total += $"{numbers[i]},";
                }

                Console.WriteLine($"({total}) => {count}");
                
                Console.WriteLine("\nПовторить операцию (y/n)");
                stop = Console.ReadLine();
                if (stop == "n") {break;}

            }
        }
        public void Program2()
        {   
            string stop = "";

            while (true)
            {   
                Console.Clear();
                string b1 = "";
                string b2 = "";
                string k1 = "";
                string k2 = "";

                Console.WriteLine("Решение уравнения y = k1 * x + b1, y = k2 * x + b2");
                
                Console.WriteLine("\nВведите значение b1");
                Console.WriteLine("(Для выхода введите 'q')");
                b1 = Console.ReadLine();
                if (b1 == "q") {break;}
                
                Console.WriteLine("Введите значение b2");
                Console.WriteLine("(Для выхода введите 'q')");
                b2 = Console.ReadLine();
                if (b2 == "q") {break;}

                Console.WriteLine("Введиет значение k1");
                Console.WriteLine("(Для выхода введите 'q')");
                k1 = Console.ReadLine();
                if (k1 == "q") {break;}

                Console.WriteLine("Введеите значение k2");
                Console.WriteLine("(Для выхода введите 'q')");
                k2 = Console.ReadLine();
                if (k2 == "q") {break;}

                Console.Clear();
                Console.WriteLine("\nУравение имеет вид");
                Console.WriteLine($"\ty = {k1}x + {b1}");
                Console.WriteLine($"\ty = {k2}x + {b2}");

                Console.WriteLine("1.Действие (находим Х)");
                Console.WriteLine($"\t{k1}x + {b1} = {k2}x + {b2}");
                Console.WriteLine($"\t{k1}x - {k2}x = {b2} - {b1}");
                double f_h_x = Convert.ToDouble(k1) - Convert.ToDouble(k2);
                double s_h_x = Convert.ToDouble(b2) - Convert.ToDouble(b1);
                Console.WriteLine($"\t{f_h_x}x = {s_h_x}");
                double x = s_h_x / f_h_x;
                Console.WriteLine($"\tx = {x}");

                Console.WriteLine("\n2.Действие (находим Y)");
                Console.WriteLine($"\ty = {k1} * {x} + {b1}");
                double y = Convert.ToDouble(k1) * Convert.ToDouble(x) + Convert.ToDouble(b1);
                Console.WriteLine($"\ty = {y}");

                Console.WriteLine("\nОтвет");
                Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} => ({x}, {y})");
                
                Console.WriteLine("Повторить операцию введите y|n?");
                stop = Console.ReadLine();
                if (stop == "n") {break;}

                


            }
        }
    }
}