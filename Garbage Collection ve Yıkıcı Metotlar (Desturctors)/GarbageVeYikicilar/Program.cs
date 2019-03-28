using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageVeYikicilar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Garbage Collection Nedir?
             * 
             * Garbage Collection erişilemeyen nesneleri silerek belleğin verimli şekilde 
             * kullanılmasını sağlar.
             * -------------------------------------------------------------------------
             * Ogrenci ogr1 = new Ogrenci();
             * 
             * Yukarıdaki kod satırında "new Ogrenci()" komutu ile Heap bellek bölgesinde "Ogrenci"
             * sınıfından bir nesne oluşturduk. Bu nesneye erişebilmek için adresini, belleğin Stack
             * bölgesinde tutulan "ogr1" ismindeki işaretçiye aktardık. Herhangi bir şekilde "ogr1"
             * ismindeki işaretçiyi kaybedersek, Heap bölgesindeki nesneye erişmemiz mümkün 
             * olmayacaktır. Erişilemeyen nesnelerde Garbage Collection tarafından silinerek
             * bellekte gerekesiz yer tutması önlenecektir. 
             * 
             * Ogrenci ogr1 = new Ogrenci();
             * Ogrenci ogr2 = new Ogrenci();
             * ogr1 = ogr2;
             * 
             * Ogrenci sınıfından 2 adet nesne oluşturduk. 1. ve 2. satırlarda ilk oluşturduğumuz
             * nesnenin adresini "ogr1" işaretçisine aktardık. Yani artık "ogr1" işaretçisi,
             * ilk nesnenin adresini değil ikinci nesnenin adresini tutmaktadır. İlk oluşturulan
             * nesnenin adresi kaybedildiği için artık o nesneye ulaşmak mümkün olmayacaktır.
             * 
             * Nesneye erişmenin mümkün olmadığı durumlarda bellekte kalmasının bir anlamı yoktur.
             * Bu yüzden Garbage Collection tarafından silinecektir.
             * 
             * [Dikkat]: Garbage Collection mekanizmasının ne zaman devreye gireceği kesin olarak
             * bilinemez. Arkaplanda programcıdan bağımsız bir şekilde çalışır.
             * --------------------------------------------------------------------------
             * 
             * Yıkıcı Metot Nasıl Tanımlanır?
             * 
             * Erişilemeyen bir nesnenin Garbage Collection tarafından silinmeden hemen önce
             * çalışan metoduna Yıkıcı Metot denilmektedir. Bir nesne silinmeden önce yapılması
             * gereken işleri yıkıcı metot içerisine yazarız.
             * 
             * 1-Yıkıcı metodun adı sınıf adıyla aynı olmalıdır ve başında "~" tilda işareti olmalıdır.
             * 2-Parametresi, geri dönüş değeri ve erişim belirteci olmamalıdır.
             */

            Oyuncu o = new Oyuncu();

            o.KullaniciAdi = "ilkcan";
            o.Sifre = "14589";
            o.Skor = 1;
            Console.WriteLine("Ad: {0}\nŞifre: {1}\nSkor: {2}\nOyuncu Sayısı: {3}\n",
                o.KullaniciAdi,o.Sifre,o.Skor, Oyuncu.OyuncuSayisi);

            GC.Collect();

         
            Console.ReadLine();
        }
    }
}
