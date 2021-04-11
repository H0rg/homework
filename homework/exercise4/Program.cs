using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 * (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, 
 * написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или 
 * не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 * 
 * (c) Кострецов Алексей
 */
namespace exercise4
{
    class Program
    {
        static bool Login(string log,string pass)
        {
            if(log == "root" && pass == "GeekBrains")
            {
                return true;
            }
            return false;

        }

        static void Main(string[] args)
        {
            int tryCount = 0;
            string login, password;

            do
            {
                Console.WriteLine("Введите логин: ");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль: ");
                password = Console.ReadLine();
                tryCount++;
                if (Login(login,password) == false && tryCount != 3)
                {
                    Console.WriteLine("\nЛогин или пароль не верный.\nПроверьте правильность введённых данных и повторите попытку.\n");
                }
            } while (Login(login, password) != true && tryCount != 3);

            if (tryCount == 3)
            {
                Console.WriteLine("Вы исчерпали количество попыток для входа.");
            }else
            Console.WriteLine("Вы вошли!");
            Console.ReadLine();

        }
    }
}
