namespace Helloworld
{
    class Program
    {
        public static void Main(string[] args)
        {   
            string stop = null;
            while (stop != "n")
            { 
                string get_program = null;
                Console.WriteLine("У меня есть 3 программы:");
                Console.WriteLine("\n\t 1 - Проверка числа на палиндром");
                Console.WriteLine("\t 2 - Нахождение растояние между двумя точками в 3D пространстве");
                Console.WriteLine("\t 3 - Вывод кубов до значения N");
                Console.WriteLine("\nКакую программу вам показать?");
                Console.WriteLine("*Для выходы введите 'q')");
                get_program = Console.ReadLine();

                if (get_program == "1") {Program1();}
                if (get_program == "2") {Program2();}
                if (get_program == "3") {Program3();}
                if (get_program == "q") {break;}
                else
                {
                    Console.WriteLine($"Программы под номером {get_program} у меня нет\nПопробуйте еще раз:");
                    Console.Write("Перевожу в меню: ");
                    for (int i = 0; i < 1; i++)
                    {   
                        string dot = ".";
                        for (int j = 0; j < 3; j++)
                        {   
                            Console.Write(dot);
                            Thread.Sleep(1000);
                            dot += ".";
                        }
                    }
                    continue;
                }
                Console.WriteLine ("\nВывести меню программ (y/n)");
                stop = Console.ReadLine();
                
            }
        }
        public static void Program1()
        {

            string stop = null;
    
            while (stop != "нет")
            {   
                string numbers = null;
                Console.WriteLine("Проверка являеться ли оно палиндромом.");
                Console.WriteLine("\nВведите 5 значное число");
            
                numbers = Console.ReadLine();
            
                int len = numbers.Length;

                if (len == 5)
                {
                    bool falg = false;

                    for(int i = 0; i < len/2; i++)
                    {
                        if (numbers[i] == numbers[len-i-1])
                        {
                            falg = true;
                        }
                        else
                        {
                            falg = false;
                        }
                    }
                    if (falg == true)
                    {
                        Console.WriteLine($"{numbers} - являеться палиндромом");
                    }
                    else
                    {
                        Console.WriteLine($"{numbers} - не являеться палиндромом");
                    }
                }
                else
                {
                    Console.WriteLine($"Вы ввели не 5 значное число!");
                }
                Console.WriteLine("\nПовторить операцию (да/нет)");
                stop = Console.ReadLine();
            }
        

        } 
        public static void Program3()
        {
            string stop = null;

            while (stop != "нет")
            {
                int numbs = 0;
                Console.WriteLine("Возведение чисел в куб от 1 до N");
                Console.WriteLine("\nВведите значение N");
                numbs = Convert.ToInt32(Console.ReadLine());

                for (double i = 1; i <= numbs; i++)
                {
                    double cube = Math.Pow(i,3);
                    Console.Write($"{cube}, ");
                }
                Console.WriteLine("\nПовторить операцию (да/нет)");
                stop = Console.ReadLine();

            }
        }
        public static void Program2()
        {   
            string stop = null;

            while(stop != "n")
            {
                string A = null;
                string B = null;

                Console.WriteLine("Поиск растояния в 3D пространстве");
            
                Console.WriteLine("\n Введите координаты точки А:");
                Console.WriteLine("*Отпрвте 'q' что бы завершить*" );
                A = Console.ReadLine();
                if (A == "q") {break;}
                var list_A = A.Split(',').Select(Int32.Parse).ToArray();

                Console.WriteLine("\n Введите координаты точки B:");
                Console.WriteLine("*Отпрвте 'q' что бы завершить*" );
                B = Console.ReadLine();
                if (B == "q") {break;}
                var list_B = B.Split(',').Select(double.Parse).ToArray();

                double count = 0;
                int i = 0;

                while (i < 3)
                {
                    count += Math.Pow(list_B[i] - list_A[i], 2);
                    i++;
                }
                Console.Write("\nЗагрузка: ");
                string slip = "///";
                int j = 0;

                while (j < 4)
                {
                    Console.Write(slip);
                    slip += "///";
                    Thread.Sleep(2000);
                    j ++;
                }
                
                double sqrt = Math.Sqrt(count);
                Console.WriteLine("\nРЕЗУЛЬТА:");
                Console.WriteLine($"\nA({A});B({B}) -> {Math.Round(sqrt, 2)}");
                Console.WriteLine("\nПовторить операцию (y/n)");
                stop = Console.ReadLine();

            }




            

        }
    }
}