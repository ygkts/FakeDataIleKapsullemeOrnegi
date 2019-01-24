using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u1_OrnekInsanOzellikleri
{
    class TemelInsan
    {
        public int Id { get; set; }
        public long TcKimlikNo { get; set; }
        private string ad;
        public string Ad { get { return ad; } set { ad = value.ToUpper(); } }
        private string soyad;
        public string Soyad { get { return soyad; } set { soyad = value.ToUpper(); } }
        // Adres sınıfından referans almak: Adres sınıfını tip olarak tanımlama
        public Adres AdresNesnesi { get; set; } // böylece adres sınıfını kalıtım almadan propertilerine erişebilicez

        public TemelInsan() // constructor: sınıflar ilk yüklendiği zaman constructorlarıyla yüklenirler
        {
            AdresNesnesi = new Adres();
        }
        public List<string> GetAdres()
        {
            List<string> alist = new List<string>();    // liste türünde bir nesne türettik
            string satir1 = "Sn. " + Ad + " " + Soyad;
            alist.Add(satir1);

            int satir2 = AdresNesnesi.Cadde;
            alist.Add(satir2.ToString() + ". cadde");

            string satir3 = AdresNesnesi.Sokak + " " + AdresNesnesi.KapiNo;
            alist.Add(satir3);

            return alist;
        }
        public string [] GetAdres1()
        {
            string[] adizi = new string[3];
            adizi[0] = "Sn. " + Ad + " " + Soyad;
            adizi[1] = AdresNesnesi.Cadde.ToString() + ". cadde";
            adizi[2] = AdresNesnesi.Sokak + " " + AdresNesnesi.KapiNo;

            return adizi;
        }

    }
}
