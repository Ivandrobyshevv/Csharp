namespace  GB
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1 - Задача47\n2 – Задача50\n3 - Задача52";
            string stop = "";
            var task = new Tasks();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер программы");
                Console.WriteLine(text);
                Console.WriteLine("(Для выхода введите 'q')");
            
                stop = Console.ReadLine();
                if (stop == "1") {task.Task47();}
                if (stop == "2") {task.Task50();}
                if (stop == "3") {task.Task52();}
                if (stop == "q") {Console.WriteLine("Хорошего дня!"); break;}
                Console.WriteLine($"Не известное значение – {stop}");
            }
        }
    }
}