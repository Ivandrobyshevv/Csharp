namespace GB
{
     public class Tasks
    {
        public void Task47()
        {   
            string stop = "";
            while (stop != "n")
            {
                Console.WriteLine("Создание двумерного массива");
                Console.WriteLine("\nВведите количество строк массива");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов массива");
                int m = int.Parse(Console.ReadLine());

                int [,] mass = new int[n, m];
                Random rand = new Random();

                Console.WriteLine();

                for (int i = 0; i < mass.GetLength(0) ; i++)
                {
                    for (int j = 0; j < mass.GetLength(1); j++)
                    {
                        mass[i, j] = rand.Next(10);
                        Console.Write(mass[i,j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Повторить операцию (y/n)");
                stop = Console.ReadLine();


               
                
            
            }

            
        }
        public void Task50()
        {   
            string stop = "";
            while (stop != "n")
            {   
                Console.Clear();
                string result = null;
                Console.WriteLine("Введите чило которое надо найти в массиве");
                Console.WriteLine("(Для выхода введите 'q')");
                string number = Console.ReadLine();
                if (number == "q") {break;}
                
                int [,] arr = new int[5, 5];
                Random rand = new Random();
                bool flag = false;
                
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1) ; j++)
                    {
                        arr[i, j] = rand.Next(50);
                        if (arr[i,j]== Convert.ToInt32(number))
                        {   
                            flag = true;
                            result = $"({i},{j})";
                        }
                        
                    }
                } Console.WriteLine();
                
                if (flag == true)
                {
                    Console.WriteLine($"{number} -> позиция в массиве {result}");
                }
                else
                {
                    Console.WriteLine($"{number} -> такого числа в массиве нет");
                }
                Console.WriteLine("Повторить операцию (y/n)");
                stop = Console.ReadLine();
            }
        }
        public void Task52()
        {   
            string stop = null;
            while (stop != "n")
            {
                int [,] numbers = new int [5,5];
                Random rand = new Random();
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    int srAr = 0;
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {   
                        numbers [i, j] = rand.Next(50);
                        srAr += numbers[i, j];
                    }
                    Console.WriteLine($"Среднее арифитическое элементов столбца {i + 1} = {(float)srAr/numbers.GetLength(0)}");
                }
                Console.WriteLine("Повторить операцию (y/n)");
                stop = Console.ReadLine();

            }
        }
    }
}