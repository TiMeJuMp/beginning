using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frage den Nutzer wieviele Texte er in einem Array speichern will.
            Console.WriteLine("Wieviele Texte willst du im Array speichern?");
            int numero = Convert.ToInt32(Console.ReadLine());
            //Initalisiere das Array in der gewünschten größe
            string[] myText = new string[numero];
            //Lasse den Nutzer das Array nacheinander mit Texten befüllen.
            for(int i=0; i<numero;i++)
            {
                string text1 = Console.ReadLine();
                myText[i] = text1;
            }
            //Gebe die Texte mit mindestens 20 Zeichen aus, fülle den Text mit Leerzeichen auf von Links wenn kleiner. 
            foreach(string entry in myText)
            {
                Console.WriteLine(entry.PadLeft(20, ' '));
            }
        }
    }
}