using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // tiedostoon kirjoittaminen
            string tiedosto = @"C:\Users\maria\OneDrive\Asiakirjat\harjoitus\Lämpötila.txt";

            //luetaan tiedostotsta aiemmin asetettu lämpötila

            if (File.Exists(tiedosto))

            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila on " + aiempiArvo + " astetta");

            }

            else
            {
                Console.WriteLine("Tervetuloa!");

            }

            int lämpötila = 0;
            Console.Write("Anna uusi lämpätila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);



            // C-kielit katsovat kenoviivan erikoismerkiksi, joten toimiakseen kenomerkki tulee laittaa tuplana tai alkuun @-merkki

            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu ");
            Console.ReadLine();
        }
    }
}
