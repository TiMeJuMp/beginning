using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Passe die Methode "Fahren" so an, dass 
            //- bei einer Geschwindigkeit von 0 die Methode "steht" zurück gibt: Hinweis: return
            //- bei einer Geschwindigkeit von 1-10 "schleicht" zurück gibt
            //- bei einer Geschwindigkeit von 11-50 "fährt langsam" zurück gibt
            //- bei einer Geschwindigkeit von 51-100 "fährt schnell" zurück gibt
            //- bei einer Geschwindigkeit über 100 "rast" zurück gibt.

            //Bau die Ausgabe so, dass nach jedem Aufruf folgende Texte ausgegeben werden können. 
            //Das Auto steht.
            //Das Auto schleicht.
            //Das Auto fährt langsam.
            //Das Auto fährt schnell. 
            //Das Auto rast.
            */
            string steht_variable = Fahren(0);
            string schleicht_variable = Fahren(9);
            string langsam_variable = Fahren(25);
            string schnell_variable = Fahren(65);
            string rast_variable = Fahren(120);

            string base_text = "Das Auto ";
            Console.WriteLine(base_text + steht_variable);
            Console.WriteLine(base_text + schleicht_variable);
            Console.WriteLine(base_text + langsam_variable);
            Console.WriteLine(base_text + schnell_variable);
            Console.WriteLine(base_text + rast_variable);
            Console.WriteLine(base_text + Fahren(-50));

        }

        static string Fahren(int geschwindigkeit)
        {
            switch(geschwindigkeit)
            {
                case 0:
                    return "steht";
                case > 0 and <= 10:
                    return "schleicht";
                case >10 and <=50:
                    return "fährt langsam";
                case >50 and <=100:
                    return "fährt schnell";
                case >100:
                    return "rast";
                default:
                    return "auto kaputt";
            }
        }
    }
}