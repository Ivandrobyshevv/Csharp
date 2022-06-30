using System;

namespace ProjectOne
{
    class MainClass {
         
        public static void Main (string[] args)
        {   
            string stop = "";

            do
            {
                int progra = 0;

                Console.WriteLine("У меня есть 3 программы");
                Console.WriteLine("------------------------");
                Console.WriteLine("Выберите номер программы, введите цифру и нажмите ");
                Console.WriteLine();
                Console.WriteLine("Номер 1 - Программа показывет 2 цифру числа");
                Console.WriteLine("Номер 2 - Программа показывает 3 цифу числа");
                Console.WriteLine("Номер 3 - Программа находит названия дня недели по его порядковому номеру");
                
                progra = Convert.ToInt32(Console.ReadLine());

                if (progra == 1) {Program1();}
                if (progra == 2) {Program2();}
                if (progra == 3) {Program3();}

                Console.WriteLine("*****************");
                Console.WriteLine("Перейти к выбору программ?");
                Console.WriteLine("Введите y|n и нажмите Enter");
                stop = Console.ReadLine();

            }while (stop != "n");
        }

        public static void Program1()
        {   
            string stopProgram1 = "";
            
            do 
            {
                Console.WriteLine("Вы выбрали программу под номером 1");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Поиск 2 числа у трех значного числа");
                Console.WriteLine();
                Console.WriteLine("Введите число и нажмите Enter");
                
                string strnumb= Console.ReadLine();
                int intnumb = Convert.ToInt32(strnumb);
                int lennumber = strnumb.Length;
    
                if (lennumber == 3)
                {
                    Console.WriteLine($"strnumb[1] - 2 цифра числа {strnumb}");
                }
                else
                {
                    Console.WriteLine("Вы ввели не 3х значеное число");
                }
                Console.WriteLine("Повторить операцию по поиску 2 цифры?");
                Console.WriteLine("*********************");
                Console.WriteLine();
                Console.WriteLine("Введите y|n и нажмите Enter");
                stopProgram1 = Console.ReadLine();

            }while ( stopProgram1 !="n");
    
        }

        public static void Program2()
        {   
            string stopProgram2 = "";

            do
            {
                Console.WriteLine("Вы выбрали программу под номером 2");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Поиск 3 цифры в трех значном числе");
                Console.WriteLine();
                Console.WriteLine("Введите число");
                
                string strnumb= Console.ReadLine();
                int intnumb = Convert.ToInt32(strnumb);
                int lennumber = strnumb.Length;

                if (lennumber == 3)
                {
                    Console.WriteLine($"{strnumb} - третья цифра = {strnumb[2]}");
                }
                else
                {
                    Console.WriteLine($"{strnumb} - третьей цифры нет");
                }

                Console.WriteLine("Повторить операцию по поиску третьей цифры?");
                Console.WriteLine("*********************");
                Console.WriteLine();
                Console.WriteLine("Введите y|n и нажмите Enter");
                stopProgram2 = Console.ReadLine();

            }while (stopProgram2 != "n");

        }

        public static void Program3()
        {
            string stopProgram3 = "";
            do
            {
                 string [] date = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятинца", "Cуббота", "Воскресенье"};
            
                Console.WriteLine("Вы выбрали программу под номером 3");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Поиск дня недели по его порядковому номеру");
                Console.WriteLine();
                Console.WriteLine("Введите номер дня недели");
                int number_date = Convert.ToInt32(Console.ReadLine());
                if (1 <= number_date && number_date <= 7) {Console.WriteLine(date[number_date - 1]);}
                
                else {Console.WriteLine($"{number_date} - Дня недели под таким номером нет");}
                
                Console.WriteLine("Повторить операцию по поиску дня недели?");
                Console.WriteLine("*********************");
                Console.WriteLine();
                Console.WriteLine("Введите y|n и нажмите Enter");
                stopProgram3 = Console.ReadLine();

            }while(stopProgram3 != "n");
            
        }
    }
}