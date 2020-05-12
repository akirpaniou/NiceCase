using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*         string zmienna;
                       Console.Write("Podaj imie i nazwisko:");
                       zmienna = Console.ReadLine();
                       Console.WriteLine("Witaj, {0}!", zmienna);
                       Console.ReadKey();
           */
            /*           int a;
                       int wynik;
                       Console.Write("Podaj liczbe: ");
                       a = Convert.ToInt32(Console.ReadLine());
                       wynik = a * a * a;
                       Console.WriteLine("V=" + wynik);
                       Console.ReadKey();
                       */
            /*          int a;
                      Console.Write("Podaj liczbe: ");
                      a = Convert.ToInt32(Console.ReadLine());
                      if (a %2 == 0)
                      {
                          Console.WriteLine("Liczba parzysta");
                      }
                     else
                      {
                          Console.WriteLine("Liczba nie parzysta");
                      }
                      Console.ReadKey();
          */

            /*         int max, min; 
                     double sr;
                     Console.Write("Podaj liczbe a: ");
                     int a = Convert.ToInt32(Console.ReadLine());

                     Console.Write("Podaj liczbe b: ");
                     int b = Convert.ToInt32(Console.ReadLine());

                     Console.Write("Podaj liczbe c: ");
                     int c = Convert.ToInt32(Console.ReadLine());

                     min = a;

                     if (b < min)
                         min = b;
                     if (c < min)
                         min = c;

                     max = a;

                     if (b > max)
                         max = b;
                     if (c > max)
                         max = c;

                     sr = (a + b + c) / 3;

                     Console.WriteLine("Minimum to {0}", min);
                     Console.WriteLine("Maximum to {0}", max);
                     Console.WriteLine("Srednia to {0}", sr);
                     Console.ReadKey();

         */
            /*         int a;
                     Console.Write("Podaj rok: ");
                     a = Convert.ToInt32(Console.ReadLine());
                     if(a%4 != 0)
                     {
                         Console.WriteLine("Zwykly");
                     }
                     else if(a%100 == 0 && a%400 != 0)
                     {
                         Console.WriteLine("Zwykly");
                     }
                     else
                     {
                         Console.WriteLine("Przestepny");
                     }

                     Console.ReadKey();
         */

            int a;
            Console.Write("Podaj liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("styczen");
                    break;
                case 2:
                    Console.WriteLine("luty");
                    break;
                case 3:
                    Console.WriteLine("marzec");
                    break;
                case 4:
                    Console.WriteLine("kwiecien");
                    break;
                case 5:
                    Console.WriteLine("maj");
                    break;
                case 6:
                    Console.WriteLine("czerwiec");
                    break;
                case 7:
                    Console.WriteLine("lipiec");
                    break;
                case 8:
                    Console.WriteLine("sierpien");
                    break;
                case 9:
                    Console.WriteLine("wrzesien");
                    break;
                case 10:
                    Console.WriteLine("pazdziernik");
                    break;
                case 11:
                    Console.WriteLine("listopad");
                    break;
                case 12:
                    Console.WriteLine("grudzien");
                    break;
                default:
                    Console.WriteLine("lol");
                    break;


            }
            Console.ReadKey();




        }
    }
}
