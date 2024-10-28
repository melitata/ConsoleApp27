using System;
namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Ma}ymun" };
            int[] dizi;
            dizi = new int[5];
            //Dizilere değer atama ve erişim
            renkler[0]= "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Dizi uzunluğunu giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];//Dizi oluşturuldu
            for (int i = 0; i < diziUzunlugu; i++)//Diziye eleman atama
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());//Kullanıcıdan diziye eleman alındı
            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)//Dizi elemanlarını ekrana yazdırma
            {
                toplam += sayi;
                Console.WriteLine("ortalma:" + toplam/diziUzunlugu);
            }



        }
    }
}