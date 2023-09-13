using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_0
{
    internal class Program
    {
        /// <summary>
        /// 8. Реализовать функцию вычисления частного двух вещественных чисел
        /// </summary>
        /// <param name="x">Делимое</param>
        /// <param name="y">Делитель</param>
        /// <returns>Вовзращает частное двух вещественных чисел </returns>
        static double Divide(double x, double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            double result;
            Random GenerateRandomDouble = new Random();
            double dividend = GenerateRandomDouble.NextDouble() * 20.0 - 10.0;
            double divisor = GenerateRandomDouble.NextDouble() * 20.0 - 10.0;

            do
            {
                string formattedDividend = dividend.ToString("F2");
                Console.WriteLine($"Делимое: {formattedDividend}");
                string formattedDivisor = divisor.ToString("F2");
                Console.WriteLine($"Делитель: {formattedDivisor}");

                if (divisor != 0)
                {
                    result = Divide(dividend, divisor);
                    string formattedResult = result.ToString("F2");
                    Console.WriteLine($"Результат: {formattedResult}");
                    break;
                }

                else
                {
                    Console.WriteLine("Деление на ноль! Повторите ввод.");
                }

            }while (true);
            Console.ReadLine();
        }
    }
}
