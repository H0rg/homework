using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
 * «Хорошим» называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
 * 
 * (c) Кострецов Алексей
 *
 */

namespace exercise6
{
    class Program
    {
        static int numbCount(int a)
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
            DateTime dold = DateTime.Now;
            Console.WriteLine("start");
            int k = 1;
            int count = 0;
            int nc;
            while (k <= 1000000000)
            {
                double sum = 0;
                nc = numbCount(k);
                int save = k;
                for (int i = 0; i < nc; i++)
                {
                    while (k != 0)
                    {
                        sum += k % 10;
                        k = k / 10;
                    }
                }
                k = save;
                if (k % sum == 0)
                {
                    count++;
                }
                k++;
            }

            Console.WriteLine($"Количество 'Хороших чисел': {count}");
            TimeSpan sp = DateTime.Now - dold;
            Console.WriteLine($"Времени затраченого на подсчёт: {sp}");
            Console.ReadLine();
        }
    }
}
