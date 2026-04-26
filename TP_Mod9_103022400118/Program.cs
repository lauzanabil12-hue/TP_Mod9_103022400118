using System;
using System.IO;
using System.Text.Json;

namespace Tp_Modul9_103022400118
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membaca file JSON
            string json = File.ReadAllText("covid_config.json");

            // Mendekode JSON ke dalam objek menggunakan System.Text.Json
            CovidConfig config = JsonSerializer.Deserialize<CovidConfig>(json);

            // Menampilkan data konfigurasi
            Console.WriteLine("Satuan suhu: " + config.SatuanSuhu);
            Console.WriteLine("Batas hari demam: " + config.BatasHariDemam);
            Console.WriteLine("Pesan ditolak: " + config.PesanDitolak);
            Console.WriteLine("Pesan diterima: " + config.PesanDiterima);

            // Input suhu badan
            Console.Write("Berapa suhu badan anda saat ini? Dalam satuan {0}: ", config.SatuanSuhu);
            double suhuBadan = Convert.ToDouble(Console.ReadLine());

            // Input hari demam
            Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
            int hariDemam = Convert.ToInt32(Console.ReadLine());

            // Menampilkan output berdasarkan kondisi
            if (hariDemam > config.BatasHariDemam)
            {
                Console.WriteLine(config.PesanDitolak);
            }
            else
            {
                Console.WriteLine(config.PesanDiterima);
            }

            // Menampilkan hasil suhu badan
            Console.WriteLine("Suhu badan Anda: {0} {1}", suhuBadan, config.SatuanSuhu);
        }
    }
}