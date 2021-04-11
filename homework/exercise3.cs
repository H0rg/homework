using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*С клавиатуры вводятся числа, пока не будет введен 0. 
 * Подсчитать сумму всех нечетных положительных чисел.
 * 
 * (c) Кострецов Алексей
 */
namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите числа :\nЧто бы прекратить введите 0");
            double a = double.Parse(Console.ReadLine());

            double sum = 0;
            do
            {
                if(a>0 && a % 2 != 0)
                {
                    sum = sum + a;
                }
                a = double.Parse(Console.ReadLine());

            } while (a!=0);
            Console.WriteLine($"Сума всех нечетных пожолительных чисел = {sum}");
            Console.ReadLine();
        }
    }
}
