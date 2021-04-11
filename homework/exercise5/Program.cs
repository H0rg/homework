using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
 * нужно ли человеку похудеть, набрать вес или всё в норме.
 * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 * 
 * 
 * (c) Кострецов Алексей
 */

namespace exercise5
{
    class Program
    {

        static double howMuch(double imt)
        {
            double F;
            if (imt < 18)
            {
                F = 18 - imt;
                Console.WriteLine("Вам нужно, для нормализации вес, набрать {0} кг", F);

            } 
            else if (imt >25.0)
            {
                F = imt - 25.0;
                Console.WriteLine("Вам нужно, для нормализации вес, сбросить {0} кг", F);

            }
            else Console.WriteLine("Вас вес в норме!");
            return 0;

        }

        static double imt(double weight,double height)
        {
            double I = weight / (height * height);
            return I;
        }
        static void who(double numb)
        {
            if (numb < 16)
            {
                Console.WriteLine("Выраженный дефицит массы тела");
            }
            else if (numb >= 16 && numb < 18)
            {
                Console.WriteLine("Недостаточная (дефицит) масса тела");
            }
            else if (numb >= 18 && numb < 25)
            {
                Console.WriteLine("Норма");
            }
            else if (numb >= 25 && numb < 30)
            {
                Console.WriteLine("Избыточная масса тела (предожирение)");
            }
            else if (numb >= 30 && numb < 35)
            {
                Console.WriteLine("Ожирение");
            }
            else if (numb >= 35 && numb < 40)
            {
                Console.WriteLine("Ожирение резкое");
            }
            else if (numb >= 40)
            {
                Console.WriteLine("Очень резкое ожирение");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой вес(кг): ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой рост(м): ");
            double h = double.Parse(Console.ReadLine());
            double k = imt(w, h);
          
            who(k);
            Console.WriteLine("Ваш индекс массы тела : {0:f2}",k);
            Console.ReadLine();
        }
    }
}
