using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, R;

           
            while (true)
            {
                Console.Write("Введите координату a (центр окружности по оси x): ");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            while (true)
            {
                Console.Write("Введите координату b (центр окружности по оси y): ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            
            while (true)
            {
                Console.Write("Введите радиус окружности R: ");
                if (double.TryParse(Console.ReadLine(), out R) && R > 0)
                    break;
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число.");
            }

          
            Console.WriteLine($"Уравнение окружности: (x - {a})^2 + (y - {b})^2 = {R * R}");

            Console.ReadKey();
        }
    }
}
