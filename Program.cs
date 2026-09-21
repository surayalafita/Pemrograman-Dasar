using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hallo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menampilkan pesan "Hello world" di layar konsol
            // Dibuat oleh Suraya Lafita
            //Kelas X PPLG 2

            Console.WriteLine("Hello World");
            Console.WriteLine("Nama = Suraya Lafita");
            Console.WriteLine("Kelas = X");
            Console.WriteLine("Jurusan = PPLG 2");

            // Praktik 1
            // Nama : Ayakkmepi
            // Kelas : X PPLG 2
            // Membuat Project Console


            Console.WriteLine("Hello World");

            // Praktik 2
            // Nama : Rayalapita
            // Kelas : X PPLG 2
            // Perbedaan Write dan WriteLine

            Console.Write("Hai");
            Console.Write("Hallo");
            Console.WriteLine("ayaaa");
            Console.WriteLine(" X PPLG");

            // PRaktik 3
            // Nama : Raayaa
            // Kelas : X PPLG 2
            // Memanggil nama Variabel

            string nama = "Rayaa";
            Console.WriteLine("Nama saya : " + nama);
            Console.WriteLine("nama");
            Console.WriteLine(" nama saya:" + "neymar");

            //Praktik 4
            //Suraya Lafita
            //Kelas = x pplg 2
            //Input dan nama

            Console.Write("Masukkan nama");
            string namaa = Console.ReadLine();
            Console.Write(" Masukkan umur  : ");
            int umur = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("= = = DATA SISWA = = =");
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine(" Umur : " + umur + " tahun ");
            
            // Praktik 5
            // Suraya Lafita
            // Kelas = x pplg 2
            // Progam Biodata Sederhana

            Console.Write(" nama     : ");
            string Nama = Console.ReadLine();
            Console.Write("Kelas     : ");
            string kelas = Console.ReadLine();
            Console.Write(" Jurusan     : ");
            string jurusan = Console.ReadLine();
            Console.Write(" umur    : ");
            int umurr = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("==== BIODATA ====");
            Console.WriteLine(" Nama   : " + nama);
            Console.WriteLine("Kelas    : " + kelas);
            Console.WriteLine("Jurusan  : " + jurusan);
            Console.WriteLine("Umur     : " + umur + " tahun");

        }
    }
}
