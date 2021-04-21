using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Заполнить случайными числами. 
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
 * 
 * 2. Реализуйте задачу 1 в виде статического класса StaticClass;
 * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 * б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
 * в)*Добавьте обработку ситуации отсутствия файла на диске.
 * 
 * (c) Кострецов Алексей
 * 
 */
namespace HomeworkL4
{
    static class Start
    {
        static public void Foo(int arrayLenght)
        {
            int[] array = new int[arrayLenght];
            int max = array.Length;
            Random r = new Random();
            for (int i = 0; i < max; i++)
            {
                array[i] = r.Next(-10000, 10000);
                Console.WriteLine($" | {i} -> {array[i]}| ");
            }
            int b = FindNumber(array);
            Console.WriteLine($"\n\n ha ha ha == {b}");
        }
        static int FindNumber(int[] array)
        {
            int max = array.Length;
            int count = 0;
            for (int i = 0; i < max; i++)
            {
                if (i + 1 == max) break;
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0 || array[i] % 3 != 0 && array[i + 1] % 3 == 0)
                {
                    Console.WriteLine($"Пара ->  |{array[i]} , {array[i + 1]}| ");
                    count++;
                }
            }
            return count;

        }
    }
    class Program
    {
        static void Method(int[] a)
        {
            //
            //
            // б) Добавьте статический метод для считывания массива из текстового файла.
            // Метод должен возвращать массив целых чисел;
            // в)*Добавьте обработку ситуации отсутствия файла на диске.
            try
            {
                StreamReader sr = new StreamReader("text.txt");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = int.Parse(sr.ReadLine());
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        static void Main(string[] args)
        {
            Start.Foo(20);
        }
    }
}
