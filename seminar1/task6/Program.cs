namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        
        {
            string number = "";
            string next = "";

            do
            {
                Console.WriteLine("Введите целое число");
                number = Console.ReadLine();
                
                int intnumber = Convert.ToInt32(number);
                    
                    if (intnumber%2 == 0)
                    {
                        Console.WriteLine($"Число {number} четное");
                    }
                    else
                    {
                        Console.WriteLine($"Число {number} нечетное");
                    }
                
                Console.WriteLine("Повторить операцию введите y|n?");
                next = Console.ReadLine();

            } while (next != "n");
        }
    }
}