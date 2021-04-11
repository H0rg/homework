using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Написать метод, возвращающий минимальное из трёх чисел.
 * 
 * (c) Кострецов Алексей
 */

namespace exercise1
{
    class Program
    {

        static string MinNumb(int a, int b, int c)
        {
            if (a < b && a < c)
                Console.WriteLine("Минимальное число : " + a);
            else if (b < c)
                Console.WriteLine("Минимальное число : " + b);
            else
                Console.WriteLine("Минимальное число : " + c);
            return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());

            MinNumb(a, b, c);

            Console.ReadLine();


        }
    }
}



