using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "AbcdAaAA";

            //Count a in text
            int count = text.Count(c => c == 'a' || c == 'A');

            //Aufgabe 1: Initialisiere 2 Zahlen und gebe die Summe auf der Console aus
            //Aufgabe 2: Lasse den Nutzer zwei Zahlen eingeben und gebe die Summe auf der Console aus
            //Aufgabe 3: Lasse den Nutzer eine Zahl eingeben und gebe alle Zahlen 
            //           bis einschließlich der eingegeben Zahl aus 
            //Aufgabe 4: Lasse den Nutzer eine Zahl eingeben und gebe nur die geraden Zahlen aus.
            //           (Hinweis: Modulo operator. => Geteilt durch 2, 
            //                  wenn der Rest 0 ist, ist die Zahl gerade)
            //Aufgabe 5: Lasse den Nutzer eine Zahl eingeben und berechne von dieser Zahl die Fakultät.
            //Aufgabe 6a: Lasse den Nutzer einen Text eingeben und gebe den Text nur in Großbuchstaben aus
            //Aufgabe 6b: Gebe die Länge des Textes aus 
            //Aufgabe 6c: Zähle wie oft der Buchstabe a vorkommt.
            //Aufgabe 6d: Gebe nur einen Teil des Textes aus. Ab Position 3, und dann die nächsten 5 Buchstaben       


            //Aufgabe 7: Frage den Nutzer nach einem Text und ersetze im Text alle vorkommenden „U“ und „u“ durch „G“ und „g“
            string myText= "UuuhhhGggggGgasdknxymcnklasd";
            string myText2 = myText.Replace("U", "G");
            myText2 = myText2.Replace("u", "g");
            //Aufgabe 8: Frage den Nutzer nach einer Texteingabe und fülle diese mit bis zu 20 Stellen mit einem y von links auf

            //Aufgabe 9: Frage den Nutzer nach einer Eingabe mit Semikolons ( ; ) und Splitte die Eingabe an diesem Zeichen. Gebe die einzelnen Werte auf der Console aus.

            //Aufgabe 10: Frage den Nutzer nach einer Eingabe und überprüfe die Texteingabe des Nutzers, ob die Zeichen „abc“ in der Eingabe enthalten sind. Gebe true oder false auf der Konsole aus. 


            //Aufgabe 11: Frage den Nutzer nach einer Zahl und zähle von dieser Rückwärts bis 0
            //Aufgabe 12: Laufe mit einer For-Schleife über die Namen der Azubis & Studenten. Wenn der Name des Azubis ein „e“ enthält, gebe den Namen aus, ansonsten nicht.
            //Aufgabe 12b: Wiederhole das Ganze und lass den Nutzer einen Buchstaben bestimmen, nach dem gesucht wird.
            //Aufgabe 13: Frage den Nutzer  wie viele Einträge er in einem int-Array haben möchte. Initialisiere ein int-Array von dieser Größe und befülle dieses Int Array in einer Schleife, indem du den Nutzer jedes Mal frägst, welche Zahl eingetragen werden soll.  
            //           => Gebe anschließend alle Zahlen nacheinander nochmal aus
	        //Aufgabe 13b: Gehe das Int-array durch und gebe den Maximal-Wert aus, Minimal-Wert und den Durchschnitt.

            //Aufgabe 14: Frage den Nutzer nach einer Zahl und gebe alle Zahlen nacheinander aus
            //           => Wenn die Zahl durch 3 teilbar ist, gebe „Fizz“ aus    
            //           => Wenn die Zahl durch 5 teilbar ist, gebe „Buzz“ aus
            //           => Wenn die Zahl durch 3 und 5 teilbar ist, gebe „FizzBuzz“ aus
            //           => Ansonsten die Zahl selbst                          

        }
    }
}