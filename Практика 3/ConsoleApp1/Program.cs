using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17.Кит плавает под водой со скоростью 27 км / ч.Он развивает мощность 150 кВт.Определить силу сопротивления воды.
            /*
            Console.Write("Введите скорость кита (км/ч): ");
            double speed = double.Parse(Console.ReadLine());            
            Console.Write("Введите мощность (кВт): ");
            double power = double.Parse(Console.ReadLine());

            double speed2 = speed / 3.6;
            double power2 = power * 1000;

            double strength = power2 / speed2;
            Console.Write($"Сила сопртевления воды = {strength:f2} H");     
            */




            // 17.Посчитайте, сколько очков набрала команда «Динамо» в первом круге чемпионата России по хоккею, если известно, 
            // что m встреч она выиграла, n встреч проиграла, k встреч закончились ничьими, полагая, что за выигрыш команда получает 2 очка, за ничью -1 очко, за проигрыш – 0 очков.
            /*
            Console.Write("Кол-во выигранных матчей: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Кол-во проигранных матчей: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Кол-во ничейных матчей: ");
            int k = int.Parse(Console.ReadLine());

            int win = m * 2;
            int draw = k * (-1);
            int point = win+draw;
            Console.Write($"Кол-во очков: {point}");
            */



            // 17. Вычислить значение функции для заданного значения аргумента
            /*
            Console.Write("Введите x= ");
            double x = double.Parse(Console.ReadLine());

            double y = Math.Log(2*x)  +  Math.Pow(Math.Sin(x),2) + x / 2 * Math.Sqrt(Math.Pow(Math.E,2) + 1) - Math.Cos(x - Math.PI);
            Console.Write($"y= {y:f2}");
            */



            // 17.а4, а12, а28 за шесть операций, а – действительное число, при этом не пользуясь никакими другими арифметическими операциями, кроме умножения.
            /*
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double a2 = a * a;
            double a4 = a2 * a2;
            double a8 = a4 * a4;
            double a12 = a4 * a8;
            double a16 = a8 * a8;
            double a28 = a16 * a12;

            Console.WriteLine($"a^4 = {a4}");
            Console.WriteLine($"a^12 = {a12}");
            Console.WriteLine($"a^28 = {a28}");
            */
            Console.ReadKey();
        }
    }
}
