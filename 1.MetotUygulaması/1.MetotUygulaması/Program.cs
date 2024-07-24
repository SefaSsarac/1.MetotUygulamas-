using System;
using System.Threading.Channels;

class Program
{
    // 1. PRATİK ----------------------------------------------------------------------------
    static void Main()
    {
        // Değer döndürmeyen metod çağırma
        SevdigimSarkiSozu();
    }
    // Değer döndürmeyen metod tanımlama
    static void SevdigimSarkiSozu()
    {
        Console.WriteLine("Benimle oynama, söyledim sana");
    }
    // 2. PRATİK ----------------------------------------------------------------------------
    static void Main()
    {
        // Geriye tamsayı döndüren metod çağırma
        int result = rastgeleSayi();
        Console.WriteLine($"Rastgele üretilen sayının 2'ye bölümünden kalan: {result} ");
    }
    // Geriye tamsayı döndüren metod tanımlama
    static int rastgeleSayi()
    {
        // Random sınıfından bir nesne oluşturuyoruz
        Random rnd = new Random();
        // 0 ile 999999 arasında rastgele bir sayı üretiyoruz
        int rastgeleSayi = rnd.Next(0, 999999);

        int result = rastgeleSayi % 2;

        return result;
    }
    // 3. PRATİK ----------------------------------------------------------------------------
    static void Main()
    {
        // Paremetre alan ve geriye değer döndüren bir metodu çağırma
        int result = AddNumbers(4, 5);
        Console.WriteLine($"Sonuc: {result}");
    }
    // Paremetre alan ve geriye değer döndüren bir metodu tanımlama
    static int AddNumbers(int a, int b)
    {
        return a * b;
    }
    // 4. PRATİK ----------------------------------------------------------------------------
    static void Main()
    {
        // Kullanıcıdan isim ve soyisim bilgisini alalım
        Console.Write("Lütfen isminizi girin: ");
        string isim = Console.ReadLine();

        Console.Write("Lütfen soyisminizi girin: ");
        string soyisim = Console.ReadLine();

        // Hoş geldiniz mesajını yazdıran metodu çağıralım
        HosGeldinizMesaji(isim, soyisim);
    }

    // Parametre alan ve geriye değer döndürmeyen metot tanımı
    static void HosGeldinizMesaji(string isim, string soyisim)
    {
        Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }
}