using System;

public class Program
{
    private static void Main(string[] args)
    {
        CovidConfig covidConfig = new CovidConfig();

        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + covidConfig.config.satuan_suhu);
        double suhuBadan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
		int TerakhirDemam = Convert.ToInt32(Console.ReadLine());

        if (covidConfig.config.satuan_suhu == "celcius")
        {
            string pesan = suhuBadan >= 36.5 && suhuBadan <= 37.5 && TerakhirDemam < covidConfig.config.batas_hari_demam ?
                covidConfig.config.pesan_diterima : covidConfig.config.pesan_ditolak;
            Console.WriteLine(pesan);
        }
        else if (covidConfig.config.satuan_suhu == "fahrenheit")
        {
            string pesan = suhuBadan >= 97.7 && suhuBadan <= 99.5 && TerakhirDemam < covidConfig.config.batas_hari_demam ?
                covidConfig.config.pesan_diterima : covidConfig.config.pesan_ditolak;
            Console.WriteLine(pesan);
        }

        covidConfig.UbahSatuan();
        Console.WriteLine("Berapa suhu badan saat ini ? Dalam nilai " + covidConfig.config.satuan_suhu);
        suhuBadan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        TerakhirDemam = Convert.ToInt32(Console.ReadLine());

        if (covidConfig.config.satuan_suhu == "celcius")
        {
            string pesan = suhuBadan >= 36.5 && suhuBadan <= 37.5 && TerakhirDemam < covidConfig.config.batas_hari_demam ?
                covidConfig.config.pesan_diterima : covidConfig.config.pesan_ditolak;
            Console.WriteLine(pesan);
        }
        else if (covidConfig.config.satuan_suhu == "fahrenheit")
        {
            string pesan = suhuBadan >= 97.7 && suhuBadan <= 99.5 && TerakhirDemam < covidConfig.config.batas_hari_demam ?
                covidConfig.config.pesan_diterima : covidConfig.config.pesan_ditolak;
            Console.WriteLine(pesan);
        }
    }
}