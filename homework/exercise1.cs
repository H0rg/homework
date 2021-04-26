using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
 * а) без использования регулярных выражений;
 * 
 * (c) Кострецов Алексей
 * 
 */

namespace exercise1
{
    class Program
    {
        static bool testLogin(string login)
        {
            int maxChar = login.Length;
            if (maxChar >= 2 && maxChar <= 10)
            {
                if (login[0] >= '0' && login[0] <= '9')
                {
                    Console.WriteLine("Некорректный логин.");
                }
                else
                {
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z' || login[i] >= '0' && login[i] <= '9') continue;
                        else
                        {
                            Console.WriteLine("Некорректный логин.");
                            return false;
                        }
                    }
                }
            }
            else Console.WriteLine("Некорректный логин.");
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            testLogin(login);
        }
    }
}
