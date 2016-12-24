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
            Random rand = new Random();
            int sayi;
            int indis;
            int[] dizi = new int [64];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = 0;
            }
            for (int i = 0; i < 64; i++)
            {
                sayi = rand.Next(1, 65);
                indis = i;
                i=iceride(dizi, sayi, i);
            }
            int min = 0;
            int max = 8;
            for (int i = 0; i < 8; i++)
            {
                //Console.WriteLine("{0}. kişinin kelimeleri:",i+1);
               

                for (int j = min; j < max; j++)
                {
                    Console.Write(" " + dizi[j] + " ");
                }
                Console.WriteLine("-------------------------");
                min = max;
                max +=8;
            }
            //Array.Sort(dizi);
          /*
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(" // "+dizi[i]+" // ");
                
            }
            */
            Console.ReadLine();
        }
        static int iceride(int []dizi,int sayi,int indis)
        {
            Boolean kontrol=false;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]==sayi)
                {
                 //   Console.Write("İçeride");
                    kontrol = true;
                    
                }              
           }
            if (kontrol==false)
            {
               // Console.Write("İçeride değil");
                dizi[indis] = sayi;
                return indis;
            }
            return --indis;
        }
    }
}
