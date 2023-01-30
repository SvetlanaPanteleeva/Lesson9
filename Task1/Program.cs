using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите целое число. Х=   ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целое число. Y=   ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - произведение");
                Console.WriteLine("4 - частное");
                Console.Write("Ваш выбор: ");
                double k = Convert.ToDouble(Console.ReadLine());
                double c = 0;
                if (k == 1)
                {
                    c = a + b;
                    Console.WriteLine("Результат = {0}", c);
                }
                else if (k == 2)
                {
                    c = a - b;
                    Console.WriteLine("Результат = {0}", c);
                }
                else if (k == 3)
                {
                    c = a * b;
                    Console.WriteLine("Результат = {0}", c);
                }
                else if (k == 4)
                {
                    c = a / b;
                    if (a != 0 && b != 0)
                    {
                        Console.WriteLine("Результат = {0}", c);
                    }
                    else if (a == 0 && b == 0)
                    {
                        Console.WriteLine("Деление 0 на 0");
                    }
                    else if (b == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно!");
                    }
                    else
                    {
                        Console.WriteLine("Нет операции с указанным номером");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }



    }
}
