using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Das ist ein Text";
            Console.WriteLine(text);
            int zahl = 21;
            Console.WriteLine(zahl);
            double kommazahl = 21.3;
            Console.WriteLine(kommazahl);
            float weiterFliesKommazahl = 26.33456516623F;
            Console.WriteLine(weiterFliesKommazahl);
            decimal flieskomma = 26.5M;
            Console.WriteLine(flieskomma);

            bool wahrheitswert = true;
            Console.WriteLine(wahrheitswert);
            bool anders = false;
            Console.WriteLine(anders);

            char buchstabe = (char)7;
            Console.WriteLine(buchstabe);

            long langezahl = 123456789123456789;
            Console.WriteLine(langezahl);
            
            uint posiotiveZahlen= 123;
            Console.WriteLine(posiotiveZahlen);

            
            string[] myArray = new string[10];
            myArray[0] = "erster Wert";
            myArray[9] = "letzter Wert";
            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[1]);

            List<string> myList = new List<string>();

            myList.Add("Christian");
            myList.Add("Benjamin");

            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);


        }
    }
}