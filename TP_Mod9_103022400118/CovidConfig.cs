using System;

namespace Tp_Modul9_103022400118
{
    public class CovidConfig
    {
        public string SatuanSuhu { get; set; }
        public int BatasHariDemam { get; set; }
        public string PesanDitolak { get; set; }
        public string PesanDiterima { get; set; }

        public CovidConfig()
        {
            // Default values jika tidak ada data JSON
            SatuanSuhu = "Celsius";
            BatasHariDemam = 14;
            PesanDitolak = "Maaf, Anda tidak boleh masuk.";
            PesanDiterima = "Silakan masuk.";
        }

        // Method untuk mengubah satuan suhu
        public void UbahSatuan(string satuan)
        {
            if (satuan.ToLower() == "fahrenheit")
            {
                SatuanSuhu = "Fahrenheit";
            }
            else
            {
                SatuanSuhu = "Celsius";
            }
        }
    }
}