using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Topshiriq 1
            Console.Write("Radiusga qiymat kiriting: ");
            double  radius = Convert.ToDouble(Console.ReadLine());
            double S = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"S = {S}");
            double L = 2 * Math.PI * radius;
            Console.WriteLine($" L = {L}");

            //Topshiriq 2
            Console.Write("Valuta:");
            double valuta = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kurs: ");
            double kurs = Convert.ToDouble(Console.ReadLine());
            double result = kurs * valuta;
            Console.WriteLine(result);
            Console.WriteLine($" {valuta} so'm {kurs} kurs = {result} so'm");

            // Topshiriq 3
            Console.Write("To'g'ilgan yilingizni kiriting: ");
            int yil = Convert.ToInt32(Console.ReadLine());
            int yosh = 2023 - yil;
            int day = yosh * 365;
            Console.WriteLine($"Siz {yosh} yosh ekansiz");
            Console.WriteLine($"{yosh} yosh va {day} kun");


            Console.ReadKey();
        }
    }
}
