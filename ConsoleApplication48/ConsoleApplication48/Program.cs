using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Random rand = new Random(); //Kelime id'leri için random sınıfı
            Random isim_rand = new Random(); //İsim indisleri için random sınıfı
            int isim_sayi, isim_indis, ind,sayi,indis;
            string[] isimler = { "Hasan", "Gazi", "Karaşahin", "Eren", "Ertaş", "Mustafa", "Akbel", "Software Eng." };
            int[] isim = new int[8]; // random isim indislerinin dizisi
            int[] dizi = new int [64]; // random kelime id'lerin dizisi
            for (int i = 0; i < dizi.Length; i++) 
            {
                dizi[i] = 0; 
            }
            for (int i = 0; i < 64; i++)
            {
                sayi = rand.Next(1, 65); // 1 ile 64 arası random sayı üretme
                indis = i; 
                i=iceride(dizi, sayi, i); // icerde fonksiyonuna tekrarı engellemek için diziyi sayıyı ve i değerlerini gönderiyoruz
            }
            for (int i = 0; i < isim.Length; i++)
            {
                isim[i] = 0;
            }
            for (int i = 0; i < 8; i++)
            {
                isim_sayi = isim_rand.Next(1, 9); // 1 ile 8 arası random sayı üretme
                isim_indis = i;
                i = isim_kontrol(isim, isim_sayi, i); // isim_kontrol fonksiyonuna tekrarı engellemek için isim dizisini sayıyı ve i değerlerini gönderiyoruz
            }
            int min = 0; 
            int max = 8;
            for (int i = 0; i < 8; i++)// Kelime id'leri 8'er gruplarda yazdırma
            {
                ind = isim[i];
                Console.WriteLine("--{0} Kişisine ait kelime id'leri--\n",isimler[ind-1]); //Kişi isimlerini yazdırma işlemi
                for (int j = min; j < max; j++)
                {
                    Console.Write(" " + dizi[j] + " ");
                }
                Console.WriteLine("\n");
                min = max; // Sınırları değiştirme işlemi
                max +=8;
            }

            Console.ReadLine();
        }
        static int isim_kontrol(int[] isim, int isim_sayi, int isim_indis) // isim id'lerini kontrol eden fonksiyon
        {
            Boolean isim_kontrol = false;
            for (int i = 0; i < isim.Length; i++)
            {
                if (isim[i] == isim_sayi)
                {
                    isim_kontrol = true;
                }
            }
            if (isim_kontrol == false)
            {
                isim[isim_indis] = isim_sayi;
                return isim_indis;
            }
            return --isim_indis;
        }
        static int iceride(int []dizi,int sayi,int indis)  //Kelime id'lerini kontrol eden fonksiyon
        {
            Boolean kontrol=false;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]==sayi)
                {
                    kontrol = true;
                    
                }              
           }
            if (kontrol==false)
            {
                dizi[indis] = sayi;
                return indis;
            }
            return --indis;
        }
    }
}
