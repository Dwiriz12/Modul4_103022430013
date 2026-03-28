using System;
public class KodePaket
{
    string[] namePaket =
    {
        "Basic", "Standart", "Premium", "Unlimited", "Gaming",
        "Streaming", "Family", "Business", "Student", "Traveler"
    };

    string[] kodePaket =
    {
        "P201", "P202", "P203", "P204", "P205", "P206",
        "P207", "P208", "P209", "P210",
    };

    public string getKodePaket(string namaPaket)
    {

        for (int i = 0; i < namaPaket.Length; i++)
        {
            if (namePaket[i] == namaPaket)
            {
                return kodePaket[i];
            }
        }
        return "Kode tidak ditemukan";
    }

    class Program
    {
        static void Main(string[] args)
        {
            KodePaket kode = new KodePaket();

            Console.Write("Masukkan nama paket: ");
            string input = Console.ReadLine();

            Console.WriteLine(kode.getKodePaket(input));

        }
    }
}