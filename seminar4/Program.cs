using System;

    namespace Project4
    {
        class MainClass
        {
            public static void Main (string[] args)
            {   
                
                while (true)
                {
                    string prog = "";

                    Console.Clear();
                    Console.WriteLine("Выберите программу:");
                    Console.WriteLine("\n1 - Возводит число А в натуральную степень В.");
                    Console.WriteLine("2 - Считает сумму цифр в чиле.");
                    Console.WriteLine("3 - Квадрыты случайных чисел.");
                    Console.WriteLine("\t(Для выхода введите 'q')");

                    prog = Console.ReadLine();
                    
                    if (prog == "1") {Program1();}
                    if (prog == "2") {Program2();}
                    if (prog == "3") {Program3();}
                    
                    
                    if (prog == "q") 
                    {   
                        Console.WriteLine("\nХорошего дня!;)");
                        break;
                    }

                    
                }
                  
            }
            public static void Program1()
            {  
                string stop = "";
                
                while (stop != "n")
                {   
                    Console.Clear();
                    Console.WriteLine("Возвидение числа А в натуральную степень В.");
                    Console.WriteLine("\nВведите значение числа А и B");
                    var number  = Console.ReadLine().Split(',');



                    double sqert = Math.Pow(Convert.ToDouble(number[0]), Convert.ToDouble(number[1]));
                    Console.WriteLine($"{number[0]},{number[1]} -> {sqert}");

                    Console.WriteLine("Повторить операцию введите y|n?");
                    stop = Console.ReadLine();

                }
            }
            public static void Program2()
            {   
                string stop2 = null;
                while(stop2 != "n")
                {
                    Console.Clear();
                    
                    string number = null;
                    int count = 0;

                    Console.WriteLine("Подсчет суммы цифр в числе");
                    Console.WriteLine("\nВведите число");
                    
                    number = Console.ReadLine();
                    int len = number.Length;

                    for (int i = 0; i<len; i++)
                    {   
                        Console.WriteLine(number[i]);
                        count = count + int.Parse(number[i].ToString());
                    }

                    Console.WriteLine($"\n{number} -> {count}");
                    Console.WriteLine("\nПовторить операцию (y|n)?");
                    stop2 = Console.ReadLine();

                }
            }
            public static void Program3()
            {   
                string stop = "";
                while (stop != "n")
                {
                    Console.WriteLine("Program3");

                    Random rand = new Random();

                    double [] numbers = new double [rand.Next(5, 11)];

                    for (int i = 0; i < numbers.Length; i++)
                    {   
                        numbers[i] = Math.Pow(rand.Next(1, 41), 2);

                    }
                    foreach (double d in numbers)
                    {
                        Console.WriteLine(d);
                    }
                    Console.WriteLine("Повторить операци (y|n)?");
                    stop = Console.ReadLine();
            
                }
            }
        }
    }