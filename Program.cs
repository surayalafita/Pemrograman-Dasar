using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kondisi_pilihan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nama : Suuraya Lafita
            // Kelas : X PPLG 2
            // Kondisi dengan satu pilihan
            // Jika nilai >= 75 maka lulus
            // Variabel nilai int
            int nilai = 88;
            if  (nilai >= 75)
            {
                // pilihan 1
                Console.WriteLine("Predikat A");
            }
            else if (nilai >=88)
            {
                // pilihan 2
                Console.WriteLine("Predikat B");
            }
            else
            {
                Console.WriteLine("Predikat C");
            }
        }
        

    }
}
