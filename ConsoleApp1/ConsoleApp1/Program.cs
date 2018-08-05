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


            int lämpötila = 0;
            Console.Write("Anna uusi lämpätila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            // tiedostoon kirjoittaminen
            string tiedosto = @"C:\Users\maria\OneDrive\Asiakirjat\harjoitus\Lämpötila.txt";

            // C-kielit katsovat kenoviivan erikoismerkiksi, joten toimiakseen kenomerkki tulee laittaa tuplana tai alkuun @-merkki

            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu ");
            Console.ReadLine();
        }
    }
}
