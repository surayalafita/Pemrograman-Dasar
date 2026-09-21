using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imayyaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            // VARIABLE KOSONG
            string nama;
            int umur;

            Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK===");
            Console.Write("Masukkan nama: ");
            nama = Console.ReadLine();
            Console.Write("masukkan alamat: ");
            var alamat = Console.ReadLine();
            Console.Write("Masukkan umur: ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terima kasih!");
            Console.WriteLine("Data diterima");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine($"Umur: {umur}");
            Console.WriteLine("SUDAH DISIMPAN");
            Console.WriteLine();


            
            // KONSTANTA

            const float Phi = 3.14f;

            Console.WriteLine("== PROGRAM LUAS LINGKARAN ==");
            Console.Write("input jari-jari: ");
            int r = int.Parse(Console.ReadLine());

            var luas = Phi * r * r;

            Console.WriteLine($"Luas Lingkaran = {luas}");


            
            // OPERASI PENJUMLAHAN DENGAN OPERATOR MATEMATIKA

            int mangga_kebakar, mangga_menggigil, hasil = 0;
            Console.Write("mangga_kebakar = ");
            mangga_kebakar = int.Parse(Console.ReadLine());
            Console.Write("mangga_menggigil = ");
            mangga_menggigil = int.Parse(Console.ReadLine());

            // BISA DIGANTI DENGAN TANDA LAIN (+,-,*,/,%)
            hasil = mangga_kebakar % mangga_menggigil;

            Console.WriteLine($"hasil mangga_kebakar % mangga_menggigil = {hasil}");



            int mangga_atis = 2;
            int pepaya_atis = 12;

            Console.WriteLine($"mangga_atis = {mangga_atis}");
            Console.WriteLine($"pepaya_atis = {pepaya_atis}");

            // INCREMENT
            mangga_atis++;
            ++pepaya_atis;

            Console.WriteLine($"mangga_atis+1 = {mangga_atis}");
            Console.WriteLine($"pepaya_atis+1 = {pepaya_atis}");

            // DECREMENT

            mangga_atis--;
            --pepaya_atis;

            Console.WriteLine($"mangga_atis-1 = {mangga_atis}");
            Console.WriteLine($"pepaya_atis-1 = {pepaya_atis}");

             
            // MENGGUNAKAN OPERATOR = UNTUK MENGISI NILAI
            int mangga_anyep = 4;
            int pepaya_anyep = 6;

            // MWNGISI ULANG VARIABLE MANGGA ANYEP
            mangga_anyep = 2;

            Console.WriteLine($"mangga_anyep = {mangga_anyep}");

            // MENGGUNAKAN += UNTUK MENGISI DAN MENJUMLAHKAN
            pepaya_anyep += 3;

            Console.WriteLine($"pepaya_anyep = {pepaya_anyep}");


            // OPERATOR PERBANDINGAN
            int mangga_radioaktif, pepaya_radioaktif = 0;

            Console.Write("jumlah mangga_radioaktif = ");
            mangga_radioaktif = int.Parse(Console.ReadLine());
            Console.Write("jumlah pepaya_radioaktif = ");
            pepaya_radioaktif = int.Parse(Console.ReadLine());

            Console.WriteLine("hasil perbandingan: ");
            Console.WriteLine($"mangga_radioaktif > pepaya_radioaktif : {mangga_radioaktif > pepaya_radioaktif}");
            Console.WriteLine($"mangga_radioaktif >= pepaya_radioaktif : {mangga_radioaktif >= pepaya_radioaktif}");
            Console.WriteLine($"mangga_radioaktif < pepaya_radioaktif : {mangga_radioaktif < pepaya_radioaktif}");
            Console.WriteLine($"mangga_radioaktif <= pepaya_radioaktif : {mangga_radioaktif <= pepaya_radioaktif}");
            Console.WriteLine($"mangga_radioaktif == pepaya_radioaktif : {mangga_radioaktif == pepaya_radioaktif}");
            Console.WriteLine($"mangga_radioaktif != pepaya_radioaktif : {mangga_radioaktif != pepaya_radioaktif}");


            // MEMBUAT OPERATOR LOGIKA
            Console.Write("Masukkan age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("password: ");
            string password = Console.ReadLine();
            bool isAdult = age > 15;
            bool ispasswordvalid = password == " ayyaa anya dua";

            if (isAdult && ispasswordvalid)
            {
                Console.WriteLine("selamat datang di raya Club");
            }
            else
            {
                Console.WriteLine("sorry, lu siapa nyak?!");
            }
        }
    }
}
        
    

