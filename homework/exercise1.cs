using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

//  1.    Изменить программу вывода таблицы функции так, 
//    чтобы можно было передавать функции типа double (double, double). 
//    Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
//
// (c) Кострецов Алексей

namespace exercise1
{
    delegate double MyDel(double a, double b);
    class Program
    {
        static double f(double a, double x)
        {
            return a * (x * x);
        }
        static double g(double a, double x)
        {
            return a * (Math.Sin(x));
        }
        static void enterNumbers(out double a, out double b)
        {
            Console.WriteLine("Enter a ..");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b .."); 
            b = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            double a, b;
            enterNumbers(out a,out b);
            MyDel fynxFisrt = new MyDel(f);
            MyDel fynxSecond = new MyDel(g);

            Console.WriteLine($"a * x ^ 2 = {fynxFisrt(a, b)}");
            Console.WriteLine($"a * sin(x) = {fynxSecond(a, b)}");
            Console.ReadLine();

        }
    }
}
