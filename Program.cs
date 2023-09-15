using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe: Zahlenraten:
            // Frage den Nutzer nach einer zahl zwischen 1 bis 100
            // Erstelle eine RandomZahl => Hinweis 
            Random random = new Random();
            int numberToGuess = random.Next(0, 101);

            Console.WriteLine("Bitte gebe eine Zahl ein, von welcher du denkst was die Zufallszahl ist.");
            int userZahl = Convert.ToInt16(Console.ReadLine());

            while(numberToGuess != userZahl)
            {
                Console.WriteLine("Du hast die zahl nicht getroffen.");
                if(userZahl > numberToGuess)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner als deine eingegebene!");
                }
                else
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer als deine eingegebene!");
                }
                userZahl = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Du hast gewonnen!");

            //Überprüft die zahl ob es numberToGuess ist
            //wenn ja => hat der Spieler gewonnen
            //Wenn nein => sage ob die gesuchte Zahl kleiner oder größer als die eingegebene Zahl ist.
        }
    }
}