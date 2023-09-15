using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string operators = "";
            do{
            Console.WriteLine("Gebe mir ein Rechenzeichen (+,-,*,/)");

            operators = Console.ReadLine();
            }while(operators != "+" && operators != "-" && operators != "*" && operators != "/");

            string zahl1 = Console.ReadLine();
            string zahl2 = Console.ReadLine();


            switch(operators) 
            {
                case "+":
                    string ergebnis = AdditionWithReturn(zahl1,zahl2).ToString();
                    ergebnis = ergebnis.PadLeft(16,' ');
                    Console.WriteLine("Das ergebnis ist");
                    Console.WriteLine(ergebnis);
                    break;
                case "-":
                    Substract(zahl1, zahl2);
                    break;
                case "*":
                    Multiply(zahl1, zahl2);
                    break;
                case "/":
                    Division(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Ich kenne diesen Operator nicht");
                    break;
            }
        }

        static int AdditionWithReturn(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);

            return numero1 + numero2;
        }

        static void Addition(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 + numero2);

        }
        static void Addition(int zahl1, int zahl2) 
        {
            Console.WriteLine(zahl1 + zahl2);
        }

        static void Substract(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 - zahl2);
        }

        static void Substract(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 - numero2); 
        }

        static void Multiply(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 * numero2); 
        }
        static void Division(string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32(zahl1);
            int numero2 = Convert.ToInt32(zahl2);
            Console.WriteLine(numero1 / numero2); 
        }
    }
}