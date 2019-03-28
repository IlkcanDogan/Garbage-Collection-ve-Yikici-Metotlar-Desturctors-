using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GarbageVeYikicilar
{
    class Oyuncu
    {
        public static int OyuncuSayisi = 0;

        public string KullaniciAdi;
        public string Sifre;
        public int Skor;

        public Oyuncu()
        {
            OyuncuSayisi++;
        }

        ~Oyuncu() 
        {
            OyuncuSayisi--;
            Console.WriteLine(Oyuncu.OyuncuSayisi);

        }

        /*
         * Oyuncu sınıfından her nesne oluşturulduğunda "OyuncuSayisi" bir artacaktır ve nesne
         * silinmeden önce bir eksilecektir.
         */
    }
}
