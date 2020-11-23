using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Morze2._0
{
    class Program
    {
        static Dictionary<string, string> abcmorze = new Dictionary<string, string>();
        static Dictionary<string, string> morzeabc = new Dictionary<string, string>();
        static List<Szoveg> idezetek = new List<Szoveg>();
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
        static void Negyedik()
        {
            Console.Write("4. Feladat: Kérek egy karakert: ");
            string betu = Console.ReadLine();

            if (abcmorze.ContainsKey(betu))
            {
                Console.WriteLine($"\tA {betu} karaketer morzekódja: {abcmorze[betu]}");
            }
            else
            {
                Console.WriteLine("Nem található a kódtárban ilyen karakter");
            }
        }
        static void Otodik()
        {

        }
        static string morze2szöveg(string kodolt)
        {
            StringBuilder vissza = new StringBuilder();
            string[] szavak = kodolt.Replace("       ", ";").Split(';');
            foreach (var szo in szavak)
            {
                string[] betuk = szo.Trim().Replace("   ", ";").Split(';');

                foreach (var betu in betuk)
                {
                    vissza.Append(morzeabc[betu]);
                }
                vissza.Append(" ");
            }

            return vissza.ToString().Trim();

        }
        static void Main(string[] args)
        {
            abcbeolvasas();
            Harmadik();
            Negyedik();

            Console.ReadKey();
        }
    }
}
