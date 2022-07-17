
namespace GB
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1 – Задача 41.\n2 – Задача 43.";        
            string stop = "";
            
            var mc = new App();

            while (true)
            {   
                Console.Clear();
                Console.WriteLine(text);
                Console.WriteLine("(Для выхода введите 'q')");
                stop = Console.ReadLine();
                
                if (stop == "1") {mc.Program1();}
                if (stop == "2") {mc.Program2();}
                if (stop == "q")
                {
                    Console.WriteLine("Пока!");
                    break;
                }

            }
        }
    }
}