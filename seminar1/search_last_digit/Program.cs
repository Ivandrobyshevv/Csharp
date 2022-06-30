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
                Console.WriteLine("Введите первое целое число и нажмите клавишу Enter:");
                number = Console.ReadLine();

                Console.WriteLine(number[2]);


                Console.WriteLine("Повторить операцию введите y|n?");
                next = Console.ReadLine();

            } while (next != "n");
        }
    }
}