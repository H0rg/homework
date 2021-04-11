using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Написать метод подсчета количества цифр числа.
 * 
 * (c) Кострецов Алексей
 * 
 */

namespace exercise2
{
    class Program
    {
        static long numbCount(long a)
        {
            int count = 0;
            while (a != 0)
            {
                count++;
                a = a / 10;
            }
            return count;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            long a = long.Parse(Console.ReadLine());

            Console.WriteLine("Количество числ: " + numbCount(a));
            Console.ReadLine();
        }
    }
}
