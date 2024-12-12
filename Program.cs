using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı tahmin oyununa hoş geldiniz başlamak için henhagi bir yuşa basınız ");
            Console.ReadKey();

            bool playAgain;
            do
            {

                Console.Write("kaç deneme hakkınız olsun = ");
                int deneme = int.Parse(Console.ReadLine());



                int hak = deneme;
                int tahmin = 1;
                Random random = new Random();
                int sayi1 = random.Next(0, 101);

                Console.Write("1 ila 100 arasında bir deger tuttum hadi tahmin et = ");
                int sayi2 = int.Parse(Console.ReadLine());
                while (true)
                {
                    if (sayi1 == sayi2)
                    {
                        Console.WriteLine("tebrikler dogru bildiniz ");
                        break;
                    }
                    else if (sayi2 > sayi1)
                    {
                        Console.WriteLine($"{tahmin} denemeniz yanlış dikkat edin {hak} denemeniz kaldı   ");
                        Console.Write("lüften  degeri düşürürerek bir deger giriniz =  ");
                        sayi2 = int.Parse(Console.ReadLine());


                    }
                    else
                    {
                        Console.WriteLine($"{tahmin} denemeniz yanlış dikkat edin {hak} denemeniz kaldı   ");
                        Console.Write("lüften  degeri yükselterek bir deger giriniz =  ");
                        sayi2 = int.Parse(Console.ReadLine());
                    }
                    hak--;
                    if (hak <= 0)
                    {
                        Console.WriteLine("bütün deneme haklarınız bitirdiniz ");
                        break ;
                    }   
                    tahmin++;
                }
                while (true)
                {
                    Console.WriteLine("oyunu tekrar oynamak istermisinz E/H");
                    string playAgainInput = Console.ReadLine()?.Trim().ToUpper();
                    playAgain = (playAgainInput == "e");


                    if (playAgainInput == "E") 
                    {
                        playAgain = true;
                        Console.WriteLine("oyun tekrar başlıyor");
                        break;;

                    }
                    
                }

            }while(playAgain);
        }
    }
}
