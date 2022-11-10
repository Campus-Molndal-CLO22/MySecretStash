namespace MySecretStash
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ReadConfig
    {
        public static string[] Read()
        {
            // Hämtar projektets namn
            string projectName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            // Skickar in filnamn på konfigurationsfilen
            return Read(projectName);
        }

        public static string[] Read(string filename)
        {
            // Mina dokument, kan ändras till vad man vill... ApplicationData är inte helt dumt heller
            var docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // Lägg till sökväg för var filen ska finnas
            var path = Path.Combine(docs, "Passwordz", filename+".txt");
            if (File.Exists(path))
            {
                // Om filen finns, läs in den
                return File.ReadAllLines(path);
            }
            else
            {
                // Annars skapa en ny fil
                // Skapa sökväg för mappen i dokumenten
                var folder = Path.GetDirectoryName(path);
                // Skapa mappen om den inte finns
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                
                // Skapa en dummy fil
                File.WriteAllText(path,"\nLägg dina passwods här");
                return new string[0];
            }
        }
    }
}
