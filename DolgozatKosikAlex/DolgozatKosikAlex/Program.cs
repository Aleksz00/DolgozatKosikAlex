using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DolgozatKosikAlex
{
    class Program
    {
        static void Main(string[] args)
        {
            var bolygok = new List<Bolygo>();
            using (var sr = new StreamReader(@"..\..\src\solsys.txt",Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    bolygok.Add(new Bolygo(sr.ReadLine()));
                }
            }
            Console.WriteLine("3.feladat:");
            Console.WriteLine($"3.1: {bolygok.Count}  van a naprendszerunkbe");
            
           var f2= bolygok.Average(x => x.BolygoSzam);
            Console.WriteLine($"3.2:A naprendszerünkben egy bolygónak atlagosan {f2} holdja van");

            var f3 = bolygok.OrderBy(x => x.BolygoTerfogat).Last();
            Console.WriteLine($"3.3:A legnagyobb térfogatú bolygó a {f3.BolygoNev}");

            Console.WriteLine("Írj be a keresett bolygó nevet:");
            string nev = Console.ReadLine();
            var f4 = bolygok.SingleOrDefault(b => b.BolygoNev == nev);
               if (f4 != null)
                {
                Console.WriteLine("Van ilyen bolygó a naprendszerben");
                
                }
                else
                {
                Console.WriteLine("sajnos nincs ilyen nevű bolygó a naprendszerben");
                }
    
            Console.Write("3.5 Írj be egy egész számot: ");
            string szam = Console.ReadLine();
            var f5 = bolygok.Where(b => b.BolygoSzam > int.Parse(szam));
            Console.WriteLine($"A következő bolygóknak van {szam} nál/nél több holdja: ");
            foreach (var item in f5)
            {
                Console.Write($"{item.BolygoNev} ");
            }
            Console.ReadKey(true);
        }
    }
}
