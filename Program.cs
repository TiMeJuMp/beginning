using System.Globalization;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {      
            /* 
            Filehandling (I/O)            
            1.	Kopiere aus T:\WKH_EXC\Trash\cbec\ die Datei data.csv auf deine 
                Festplatte C:\..... (Freie Wahl möglich)
            2.	Kopiere die Datei unter einem anderen Namen
            3.	Lösche die kopierte Datei wieder 
            4.	Kopiere die Datei in ein Variables Verzeichnis, welches der Nutzer 
                selbst setzen kann
            5.	Probiere eine Datei einzulesen, welche nicht existiert. Behalte die 
                Lösung im Hinterkopf wenn du zukünftig Dateien einliest, damit du hier 
                keinen Fehler bekommst!!!
            6.	Lese Datei mittels einem C#- Programm ein
            7.	Teile die Einträge am Separator und gebe die ersten 10 Zeilen mit einem Tabulator separiert aus.
            8.	Gebe nur die Einträge aus, welche vom Alter jünger als 20 und männlich sind
            9.	Speichere diese in einer neuen CSV-Datei mit dem Namen „JungeHüpfer.csv“
            10.	Erstelle eine Schleife welche die Einträge nach Alter separieren. (Gewichte_18.csv, Gewichte_19.csv ……. Bis  Alter 100) 
            */              
            string filepath = "D:/050_Ausbilder/04 Ausbildung 2023/copy_data.csv";
            FileInfo fi = new FileInfo(filepath);
            if(fi.Exists)
            {
                StreamReader reader = new StreamReader(filepath, Encoding.UTF8);
                List<string[]> myEntries = new List<string[]>();
                string headerLine = reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    myEntries.Add(reader.ReadLine().Split(';'));
                }
                Console.WriteLine(string.Join('\t', myEntries[0]));
                Console.WriteLine(myEntries.Count);

                //int startAlter = 18;
                int endAlter = 100;

                for(int alter = 18; alter<=endAlter; alter++ )
                {
                    Console.WriteLine("Aktuell bin ich bei Alter:" + alter);
                    List<string[]> gefilterteEintraege =  myEntries
                                    .Where(w => Convert.ToInt32(w[2]) == alter)
                                    .ToList();
                    using(StreamWriter writer = new StreamWriter($"D:/050_Ausbilder/04 Ausbildung 2023/Gewichte_{alter}.csv", true, Encoding.UTF8))
                    {
                        foreach(string[] entry in gefilterteEintraege)
                        {
                            writer.WriteLine(string.Join('\t', entry));
                        }
                    }
                    Thread.Sleep(1000);
                }
                
              

                
                

                //Console.WriteLine(myEntries.Where(w => w[0] == "m" && Convert.ToInt32(w[2]) < 20).Count());
              /*  foreach(string[] entry in maennlichUnter20)
                {
                    Console.WriteLine(string.Join("\t", entry));
                }*/
            }
            else {
                Console.WriteLine("Diese Datei existiert nicht! "  +filepath);
            }

            //FileInfo fileToDelete = new FileInfo("D:/050_Ausbilder/04 Ausbildung 2023/copy_data2.csv");
            //fileToDelete.Delete();

            //Console.WriteLine("Wohin willst du die Datei kopieren?");
            //string newPath = Console.ReadLine();
            //fi.CopyTo(newPath);

        }
    }
}