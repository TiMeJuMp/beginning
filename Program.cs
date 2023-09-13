namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frage den Nutzer nach der ersten Zahl
            Console.WriteLine("Gebe uns deine erste Zahl!");
            string eingabe1 = Console.ReadLine();

            //Frage den Nutzer nach der zweiten Zahl
            Console.WriteLine("Gebe uns deine zweite Zahl!");
            string eingabe2 = Console.ReadLine();

            //Gebe das Ergebnis auf der Console aus
            int zahl1 = Convert.ToInt16(eingabe1);
            int zahl2 = Convert.ToInt16(eingabe2);
            int ergebnis = zahl1+zahl2;
            

            // "Das Ergebnis aus {{Zahl1}} + {{Zahl2}} = {{Ergebnis}}"
            Console.WriteLine($"Das Ergebnis aus {zahl1} + {zahl2} = {ergebnis}");
        }
    }
}