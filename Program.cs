using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Der Nutzer soll eine Zahl eingeben. Diese stellen die Anzahl der Sekunden dar. 
            //Konvertiere die Zahl in die Anzahl der Tage, Stunden Minuten und restliche Sekunden.  
            //(90.061 => 1 Tag 1 Stunde 1 Minute 1 Sekunde)

            int amountSeconds = Convert.ToInt32(Console.ReadLine());

            int amountDays = amountSeconds / 24 / 60 / 60;
            Console.WriteLine("Anzahl Tage:" + amountDays);
            int restSeconds = amountSeconds % ( 24 * 60 * 60);
            int amountHours = restSeconds / 60 / 60;
            restSeconds = restSeconds % (60 * 60);
            int amountMinutes = restSeconds / 60 ;
            restSeconds = restSeconds % 60;
            
            Console.WriteLine($@"Aus der Anzahl {amountSeconds} wird {amountDays} Tage, {amountHours}
                                Stunden, {amountMinutes} Minuten, {restSeconds} Sekunden");

        }
    }
}