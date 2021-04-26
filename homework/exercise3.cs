using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
 * Например: badc являются перестановкой abcd.
 * 
 * (c) Кострецов Алексей
 * 
 */

namespace exercise3
{
    class Program
    {
        static void IsItAnagram(string first, string second)
        {
            bool flag = false;
            StringBuilder a = new StringBuilder(first);
            StringBuilder b = new StringBuilder(second);
            for (int i = 0; i < a.Length; i++)
            {
                for (int k = 0; k < b.Length; k++)
                {
                    if(a[i] == b[k])
                    {
                        a[i] = '*';
                        b[k] = '*';
                    }
                }
            }
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] != '*')
                {
                    Console.WriteLine("Эти слова не являются анограммой");
                    flag = false;
                    break;
                }else flag = true;
            }
            if(flag == true) Console.WriteLine("Эти слова являются анограммой");
        }
        static void start()
        {
            Console.WriteLine("Введите первое число: ");
            string first = Console.ReadLine().ToLower();
            
            Console.WriteLine("Введите второе число: ");
            string second = Console.ReadLine().ToLower();
            IsItAnagram(first, second);
        }
        static void Main(string[] args)
        {
            start();
        }
    }
}
