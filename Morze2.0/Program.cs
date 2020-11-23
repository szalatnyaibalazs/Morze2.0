using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Morze2._0
{
    class Program
    {
        static Dictionary<string, string> abcmorze = new Dictionary<string, string>();
        static Dictionary<string, string> morzeabc = new Dictionary<string, string>();

        static void abcbeolvasas()
        {
            StreamReader be = new StreamReader("morzeabc.txt");
            be.ReadLine();
            while (!be.EndOfStream)
            {
                string[] a = be.ReadLine().Split('\t');
                abcmorze.Add(a[0],a[1]);
                morzeabc.Add(a[1],a[0]);
            }
            be.Close();
        }
        static void Harmadik()
        {
            Console.WriteLine($"3. feladat: {morzeabc.Count} db karakter kódját tartalmazza");
        }
        static void Main(string[] args)
        {
            abcbeolvasas();
            Harmadik();

            Console.ReadKey();
        }
    }
}
