//using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Uygulama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string mesaj = "Merhaba";
            //double tutar = 100000;
            //int sayi = 100;
            //bool girisYapmisMi = false;

            //string ad = "Ali";
            //string soyad = "Kaya";
            //int dogumYili = 2002;
            //long tcNo = 12901038212;

            //Console.WriteLine(tutar * 1.18);
            //Console.WriteLine(tutar*1.18);

            //Vatandas vatandas = new Vatandas();
            SelamVer(isim: "Ali");
            SelamVer();
            int sonuc = Topla(9,17);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ali";
            ogrenciler[1] = "Ayşe";
            ogrenciler[2] = "Fatma";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            string[] sehirler1 = new[] { "Bayburt", "Ankara", "İstanbul" };
            string[] sehirler2 = new[] { "Trabzon", "Gümüşhane", "Erzurum" };

            sehirler2 = sehirler1;
            sehirler1[0] = "İzmir";
            Console.WriteLine(sehirler2[0]);

            //Person person1= new Person();
            //person1.FirstName = " Ahmet";
            //person1.LastName="Karaman";
            //person1.DateOfBirthYear= 2005;
            //person1.NationalIdentity= 21942014821;

            //person1 person2 = new Person();
            //person2.FirstName = "Elif";

            foreach(string s in sehirler1)
            {
                Console.WriteLine(s);
            }

            List<string> ysehirler1 = new List<string> { "Bursa", "Kocaeli", "Mersin" };
            ysehirler1.Add(item: "Muğla");
            foreach(var sehir in ysehirler1)
            {
                Console.WriteLine(sehir);
            }


            // PttManager pttManager = new PttManager(new ForeignerManager(new PersonManager));
            //pttManager.GiveMask(person1);
            Console.ReadLine();


        }

        static void SelamVer(string isim= "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 3, int sayi2 = 6)
        {
            int sonuc= sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
    //    private static void Degiskenler()
    //    {
    //        string mesaj = "Merhaba";
    //        double tutar = 100000;
    //        int sayi = 100;
    //        bool girisYapmisMi = false;

    //        string ad = "Ali";
    //        string soyad = "Kaya";
    //        int dogumYili = 2002;
    //        long tcNo = 12901038212;

    //        Console.WriteLine(tutar * 1.18);
    //        Console.WriteLine(tutar*1.18);
    //    }
    //}
    //public class Vatandas
    //{
    //    public string  Ad { get; set; }

    //    public string Soyad { get; set;}

    //    public int DogumYili{ get; set;}

    //    public long TcNo { get; set;}  

    
    }

}
