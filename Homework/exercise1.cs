using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
 * 
 * (c) Алексей Кострецов
 * 
 */



namespace exercise1
{
    public struct Complex
    {
        public int re;
        public int im;

        public void ConvToString()
        {
            Console.WriteLine($"{this.re} + {this.im}i");
        }
        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = x.re + re;
            y.im = x.im + im;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = x.re - re;
            y.im = x.im - im;
            return y;
        }


        public Complex Multi(Complex x)
        {
            Complex y;
            y.re = re * x.re - im * x.im; 
            y.im = re * x.im + im * x.re; 
            return y;
        }
    }
    class Program
    {
        static void Print(string text, Complex x)
        {
            Console.WriteLine(text);

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            x.re = a;
            x.im = b;
        }
        static void Main(string[] args)
        {
            Complex first;
            Complex second;
            

            Console.WriteLine("Введите первое комплексное число(без i): ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            first.re = a;
            first.im = b;

            Console.WriteLine("Введите второе комплексное число(без i): ");
            
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            
            second.re = c;
            second.im = d;
            Complex result;
            Console.WriteLine("Что с этими комплексными числами сделать?\nДобавить|Отнять|Умножить");
            string question = Console.ReadLine();
            question = question.ToLower();
            switch (question)
            {
                case "добавить":
                    result = first.Plus(second);
                    Console.Write($"{a}+{b}i + {c}+{d}i =  ");
                    result.ConvToString();
                    break;
                case "отнять":
                    result = first.Minus(second);
                    Console.Write($"{a}+{b}i - {c}+{d}i =  ");
                    result.ConvToString();
                    break;
                case "умножить":
                    result = first.Multi(second);
                    Console.Write($"{a}+{b}i * {c}+{d}i = ");
                    result.ConvToString();
                    break;
            }

            Console.ReadLine();


        }
    }
}
