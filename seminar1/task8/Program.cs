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
                Console.WriteLine("Введите целое число и нажмите Enter");
                number = Console.ReadLine();
                
                int intnumber = Convert.ToInt32(number);

                IEnumerable<int> numbers = Enumerable.Range(1, intnumber-1);

                foreach (int i in numbers)
                {
                    if (i%2 == 0)
                    {
                        Console.WriteLine(i);

                    }
                }

                Console.WriteLine("Повторить операцию введите y|n?");
                next = Console.ReadLine();

            } while (next != "n");
        }
    }
}