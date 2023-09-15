using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lasse dir 2 Zahlen geben und lasse den den Rest ausgeben. 
            //lese Zahl 1 ein 
            Console.WriteLine("Gebe Zahl1 ein");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            //lese Zahl 2 ein
            Console.WriteLine("Gebe Zahl2 ein");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            //Mache eine Division mit Rest und speicher das Ergebnis in einer variablen
            int rest = numero1 % numero2;

            //Gebe den Text aus
            //"Die Division von {zahl1} und {Zahl2} erzeugt den Rest XYZ"
            Console.WriteLine($"Die Division von {numero1} und {numero2} erzeugt den Rest {rest}");
        }
    }
}