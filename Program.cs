using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tas_kagıt_makas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random __RAND = new Random();
        basla: int i = 1;
            Console.Clear();
            Console.WriteLine("TAŞ-KAĞIT-MAKAS");
            int __YourHand1=0, PcSkor = 0, MySokor = 0;
        int __Rand = 0;
        bas: while (i < 4)
            {
                Console.WriteLine("raund {0}", i);
                Console.WriteLine("taş=1 kağıt=2 makas=3 yazınız");
                __YourHand1 = Convert.ToInt32(Console.ReadLine());
                __Rand = __RAND.Next(1, 4);
                if ((__Rand == 3 && __YourHand1 == 2) || (__Rand == 2 && __YourHand1 == 1) || (__Rand == 1 && __YourHand1 == 3))
                {
                    PcSkor += 1;
                }
                else if ((__Rand == 3 && __YourHand1 == 1) || (__Rand == 2 && __YourHand1 == 3) || (__Rand == 1 && __YourHand1 == 2))
                {
                    MySokor += 1;
                }
                else if ((__Rand == 3 && __YourHand1 == 3) || (__Rand == 2 && __YourHand1 == 2) || (__Rand == 1 && __YourHand1 == 1))
                {
                    Console.WriteLine("raund berabere raund tekrar ediliyor");
                    Console.WriteLine("***********************************************");
                    goto bas;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş");
                    goto bas;
                }
                Console.WriteLine("You Score {0}, PC Score {1} ", MySokor, PcSkor);
                i++;
                Console.WriteLine("***********************************************");
            }
            if (PcSkor < MySokor)
            {
                Console.WriteLine("Kazandınız");
            }
            else if (PcSkor == MySokor)
            {
                Console.WriteLine("berabere");
            }
            else
            {
                Console.WriteLine("Kaybettiniz");
            }
            Console.WriteLine("devam etmek ister misiniz E/H");
            string deger = Console.ReadLine();

            if (deger == "E" || deger == "e")
            {
                goto basla;
            }
            Console.WriteLine("iyi günler");
            Console.ReadLine();
        }
        
        
    }
}
