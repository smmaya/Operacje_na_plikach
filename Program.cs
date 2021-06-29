using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

//Programik podnosi do kwadratu liczby od 1 do 100 i zapisuje wyniki do pliku tekstowego.

namespace Kwadraty
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciezka = "/Users/Maya/programowanie/wynik.txt";
            using (StreamWriter sw = new StreamWriter(sciezka))
            {
                for (int i = 1; i <= 100; i++)
                {
                    sw.WriteLine("kwadrat " + i + " to: " + (i * i));
                }
            }
        }
    }
}
