using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halmaz_Szótár
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 2, 5, 2, 6, 5, 6, 5, 5, 2 };

            HashSet<int> halmaz = new HashSet<int>();

            Console.WriteLine(halmaz.Count);
            halmaz.Add(2);
            Console.WriteLine(halmaz.Count);
            halmaz.Add(3);
            Console.WriteLine(halmaz.Count);
            halmaz.Add(2);
            Console.WriteLine(halmaz.Count);

            for (int i = 0; i < lista.Count; i++)
            {
                halmaz.Add(lista[i]);
            }

            foreach (int elem in lista)
            {
                Console.Write($"{elem}");
            }

             Dictionary<string, string> angolnémetszótár = new Dictionary<string, string>();

             angolnémetszótár["one"]="eins";
             angolnémetszótár["two"]="zwei";
             angolnémetszótár["three"]="drei";
            foreach (string kulcs in angolnémetszótár.Keys)
            {
                Console.WriteLine($"{ kulcs} -> {angolnémetszótár[kulcs]}");
            }
        }


    }
}
