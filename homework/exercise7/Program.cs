using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
 * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 * 
 * (c) Кострецов Алексей
 *
 */

namespace exercise7
{
    class Program
    {
        static int numbers(int a, int b)
         {
            int sum;

            if (a == b - 1)
                return 0;
            
            a++;
            Console.Write(" "+a);
            sum = numbers(a, b)+a;         
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое(меньшее) число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            numbers(a, b);
            Console.WriteLine($"\nСумма числе стоящих между {a} и {b} = {numbers(a,b)}");
            Console.ReadLine();

        }
    }
}
