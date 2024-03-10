
using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //Degiskenler();
        //Vatandas vatandas1 = new Vatandas();

        SelamVer(isim: "Engin");
        SelamVer(isim: "Ahmet");
        SelamVer(isim: "Ayşe");

        int sonuc = Topla(6,58);

        string ogrenci1 = "Engin";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Berkay";

        //Console.WriteLine(ogrenci1);
        //Console.WriteLine(ogrenci2);
        //Console.WriteLine(ogrenci3);

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";
        //ogrenciler[3] = "İlker";

        ogrenciler = new string[4];
        ogrenciler[3] = "İlker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyaarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        Person person1 = new Person();
        person1.FirstName = "Engin";
        person1.LastName = "Demiroğ";
        person1.DateOfBirthYear = 1985;
        person1.NationalIdentity = 123;

        Person person2 = new Person();
        person2.FirstName = "Murat";

        foreach (string s in sehirler1)
        {
            Console.WriteLine(s);
        }

        List<string> yeniSehirleri1 = new List<string>() { "Ankara 1", "İstanbul 1", "İzmir 1" };
        yeniSehirleri1.Add("Adana 1");
        foreach (string s in yeniSehirleri1)
        {
            Console.WriteLine(s);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);




        Console.ReadLine();
    }
    static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

    static int Topla(int sayi1 =5, int sayi2 =10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam : " + sonuc.ToString());
        return sonuc;
    }

    //private static void Degiskenler()
    //{
    //    string mesaj = "Merhaba";
    //    double tutar = 100000; //db den gelir
    //    int sayi = 100;
    //    bool girisYapmisMi = false;

    //    string ad = "Engin";
    //    string soyad = "Demiroğ";
    //    int dogumYili = 1985;
    //    long tcNo = 12345678910;

    //    Console.WriteLine(tutar * 1.18);
    //    Console.WriteLine(tutar * 1.18);
    //}
}


//public class Vatandas
//{
//    public string Ad { get; set; }
//    public string Soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }
//}