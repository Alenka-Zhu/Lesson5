using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meteo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение N для формирования двумерного массив размера NxN");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];/*задали квадратный массив размерностью введенного числа*/
            Console.WriteLine("Заполните массив числами");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Массив заполнен");
            Console.WriteLine("Получился следующий массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            int sumi = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumi += a[i, j];
                    Console.WriteLine(sumi);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}
