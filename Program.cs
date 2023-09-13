using System.Globalization;

namespace HelloWorld
{
    class Program
        {
        static void Main(string[] args)
        {
            //Frage den Nutzer bis zu welcher Zahl aufsummiert werden soll
            //Mache das in allen möglichen Schleifenarten, 
            //In welcher geht es nicht und wieso?
                //for, foreach, while, do while
            
            //6
            //1 + 2 + 3 + 4 + 5 + 6 => 21
            int ergebnis = 0;
            int untilNumber = 0;
            Console.WriteLine("Bis zu welcher Zahl soll aufsummiert werden?");
            untilNumber = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i <= untilNumber; i++)
            {
                ergebnis += i;
                Console.WriteLine($"Added number{i}, current result {ergebnis}");
            }
        } 
    }
}