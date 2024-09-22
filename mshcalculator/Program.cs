using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace mshcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; ) //Sonsuz Döngü (İnfinity Loop)
            {
            devam:
                Console.Clear();
                
            Console.WriteLine("Menü");

            Console.WriteLine("Toplama - 1");

            Console.WriteLine("Çıkarma - 2 ");

            Console.WriteLine("Çarpma - 3 ");

            Console.WriteLine("Bölme - 4");

            Console.Write("Seçiminiz : ");
            string menü = Console.ReadLine();

           
                if (menü == "1" || menü == "toplama")
                {
                    Console.Clear();
                    Console.WriteLine("Toplama İşlemini Seçtiniz");
                    Console.Write("1.sayı : ");
                    decimal s1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("2.sayı : ");
                    decimal s2 = Convert.ToDecimal(Console.ReadLine());
                    decimal toplam = s1 + s2;
                    Console.WriteLine("Toplama Sonucu = {0}",toplam);
                }

                else if (menü == "2" || menü == "çıkarma")
                {
                    Console.Clear();
                    Console.WriteLine("Çıkarma İşlemini Seçtiniz");
                    Console.Write("1.sayı : ");
                    decimal s1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("2.sayı : ");
                    decimal s2 = Convert.ToDecimal(Console.ReadLine());
                    decimal cıkarma = s1 - s2;
                    Console.WriteLine("Çıkarma Sonucu = {0}",cıkarma);
                    
                }

                else if (menü == "3" || menü == "çarpma")
                {
                    Console.Clear();
                    Console.WriteLine("Çarpma İşlemini Seçtiniz");
                    Console.Write("1.sayı : ");
                    decimal s1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("2.sayı : ");
                    decimal s2 = Convert.ToDecimal(Console.ReadLine());
                    decimal carpma = s1 * s2;
                    Console.WriteLine("Çarpma Sonucu = {0}", carpma);
                }

                else if (menü == "4" || menü == "bölme")
                {
                devam3:
                    Console.Clear();
                    Console.WriteLine("Bölme İşlemini Seçtiniz");
                    Console.Write("1.sayı : ");
                    decimal s1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("2.sayı : ");
                    decimal s2 = Convert.ToDecimal(Console.ReadLine());
                    if (s2 == 0)
                    {
                        Console.WriteLine("Hiçbir Sayı 0'A Bölünemez");
                        Thread.Sleep(2000);
                        goto devam3;
                    }
                    decimal bölme = s1 / s2;
                    
                    Console.WriteLine("Bölme Sonucu = {0}", bölme);
                }

                else
                {
                    Console.WriteLine("Yanlış Veya Eksik Numaraya Bastınız");
                }
               
            devam2:
                
                Console.WriteLine("Devam Edilsinmi ? E/H");
                string devam = Console.ReadLine();
                
                if(devam == "E" || devam == "e")
                {
                    goto devam;
                }

                else if (devam == "H" || devam == "h")
                {
                    
                    Console.WriteLine("Kapatılıyor.....");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }

                else
                {
                    Console.Clear();
                    goto devam2;    
                   
                }
               
            }
          
        }
    }
}
