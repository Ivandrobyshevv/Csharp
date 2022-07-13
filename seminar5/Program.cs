using System;

    namespace Program5
    {
        class MainClass
        {
            public static void Main(string [] args)
            {
                while (true)
                {   
                    string prog = "";

                    Console.Clear();
                    Console.WriteLine("Выберите программу:");
                    Console.WriteLine("\n1 - Количеcтво четных чисел в массиве.");
                    Console.WriteLine("2 - Сумма элементов массива, стоящих на нечетных позициях.");
                    Console.WriteLine("3 - Разница между максимальным и минимальным элементами массива.");
                    Console.WriteLine("\t(Для выхода введите 'q')");
                    prog = Console.ReadLine();

                    if (prog == "1") {Program1();}
                    if (prog == "2") {Program2();}
                    if (prog == "3") {Program3();}
                    if (prog == "q") {break;}
                }
            }
            public static void Program1()
            {   

                while (true)
                {
                    Console.Clear();
                    Random rand = new Random();

                    int count = 0;
                    Console.WriteLine("Сколько элементов должно быть в массиве?");
                    count = Convert.ToInt32(Console.ReadLine());

                    int [] numbers_list = new int[count];
                    Console.WriteLine($"Массив содержит {count} чисел:");

                    for (int i = 0; i < numbers_list.Length; i++)
                    {
                        numbers_list[i] = rand.Next(99, 999);
                        Console.WriteLine(numbers_list[i]);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Четные числа:");

                    for (int j = 0; j < numbers_list.Length; j++)
                    {
                        if (numbers_list[j] % 2 == 0)
                        {
                            Console.WriteLine($"{numbers_list[j]}");
                        }
                       
                    }

                    string stop = "";

                    Console.WriteLine("\nПовторить операцию введите y|n?");
                    stop = Console.ReadLine();

                    if (stop == "y") {continue;}
                    else {break;}

                }

                
            }
            public static void Program2()
            {
                while (true)
                {
                    Console.Clear();
                    Random rand = new Random();

                    int totoal = 0;
                    int count = 0;
                    Console.WriteLine("Сколько элементов должно быть в массиве?");
                    count = Convert.ToInt32(Console.ReadLine());

                    int [] numbers_list = new int[count];
                    Console.WriteLine($"Массив содержит {count} чисел:"); 

                    for (int i = 0; i < numbers_list.Length; i++)
                    {
                        numbers_list[i] = rand.Next(0, 999);
                        Console.WriteLine($"\t{numbers_list[i]}");
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("Числа с нечетными индексами:");

                    for (int j = 0; j < numbers_list.Length; j ++)
                    {
                        if (j % 2 == 0) {Console.WriteLine($"\t{numbers_list[j]}");}
                        totoal += numbers_list[j];
                    }
                    
                    Console.WriteLine($"\nCумма чисел под нечетными индексами = {totoal}");
                    string stop = "";

                    Console.WriteLine("\nПовторить операцию введите y|n?");
                    stop = Console.ReadLine();

                    if (stop == "y") {continue;}
                    else {break;}                    
                }
            }
            public static void Program3()
            {
               while (true)
                {
                    Console.Clear();
                    Random rand = new Random();

                    int count = 0;
                    Console.WriteLine("Сколько элементов должно быть в массиве?");
                    count = Convert.ToInt32(Console.ReadLine());

                    int [] numbers_list = new int[count];
                    Console.WriteLine($"Массив содержит {count} чисел:");

                    for (int i = 0; i < numbers_list.Length; i++)
                    {
                        numbers_list[i] = rand.Next(99, 999);
                        Console.WriteLine($"{numbers_list[i]}");
                    }

                    Console.WriteLine();
                    
                    int max = numbers_list.Max();
                    int min = numbers_list.Min();
                    int result = max - min;

                    Console.WriteLine($"Разница между максимальным {max} и минимальным {min} = {result}");

                    string stop = "";

                    Console.WriteLine("\nПовторить операцию введите y|n?");
                    stop = Console.ReadLine();

                    if (stop == "y") {continue;}
                    else {break;}

                } 
            }

        }
    }
