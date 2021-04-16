using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*а)  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 * Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
 * 
 * (c) Алексей Кострецов
 * 
 */

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int sum = 0;
            bool flag;
            do
            {
                Console.WriteLine("\nВведите число: ");
                string str = Console.ReadLine();
                flag = int.TryParse(str, out a);
                if (flag)
                {
                    if (a == 0) break;
                    Console.WriteLine($"Число: {a}");
                    if (a % 2 != 0 && a >= 0)
                    {
                        sum += a;
                        Console.WriteLine($"Cумма: {sum}");
                    }
                }
                else Console.WriteLine("Это не число.");

            } while (a != 0 || !flag);
            Console.WriteLine($"Общая сумма всех веденных нечётных пложительных числ = {sum}");
            Console.ReadLine();
        }
    }
}
