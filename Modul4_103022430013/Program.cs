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

    class mesinKopi
    {
        enum state
        {
            OFF, STANBY, BREWING, MAINTENANCE
        }
        private state currentState;

        public mesinKopi()
        {
            currentState = state.OFF;
        }

        public void ChangeState (state newState)
        {
            if (currentState == state.OFF && newState == mesinKopi.state.STANDBY)
            {
                Console.WriteLine("Mesin off berubah menjadi Standby");
            }

            else if (currentState == state.STANDBY && newState == mesinKopi.state.BREWING)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
            }

            else if (currentState == state.BREWING && newState == mesinKopi.state.STANDBY)
            {
                Console.WriteLine("Mesin Brewing berubah menjadi Standby");
            }

            else if (currentState == state.STANDBY && newState == mesinKopi.state.MAINTENANCE)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
            }

            else if (currentState == state.MAINTENANCE && newState == mesinKopi.state.STANDBY)
            {
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
            }

            else if (currentState == state.STANDBY && newState == mesinKopi.state.OFF)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Off");
            }

            else {  
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KodePaket kode = new KodePaket();

            Console.Write("Masukkan nama paket: ");
            string input = Console.ReadLine();
            jjk
            Console.WriteLine(kode.getKodePaket(input));
            

            mesinKopi.OFF();
            mesinKopi.STANBY();
            mesinKopi.BREWING();
            mesinKopi.STANDBY();
            mesinKopi.MAINTENANCE();
            mesinKopi.STANBY();

            mesinKopi.BREWING();
        }
    }
}