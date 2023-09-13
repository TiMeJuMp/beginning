using System.Globalization;

namespace HelloWorld
{
    class Program
        {
        static void Main(string[] args)
        {
            List<int> myNumberList = new List<int>();

            Console.WriteLine("Sage mir wieviele Zahlen du in deine Liste hinzufügen möchtest!");
            int amountNumbers = Convert.ToInt32(Console.ReadLine());

            while(myNumberList.Count < amountNumbers)
            {
                Console.WriteLine("Gebe mir eine Zahl");
                myNumberList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //Summiere alle zahlen auf
            int ergebnis = 0;
            foreach(int zahl in myNumberList) 
            {
                ergebnis = ergebnis + zahl;
            }
            Console.WriteLine($"Das Ergebnis ist {ergebnis}");
        } 
    }
}