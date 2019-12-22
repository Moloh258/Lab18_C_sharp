using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, k;
            Write("Введите кол-во строк: ");
            n = int.Parse(ReadLine());

            Write("Введите кол-во столбцов: ");
            m = int.Parse(ReadLine());

            Write("Введите число k: ");
            k = int.Parse(ReadLine());
            k--;

            int[,] arr = new int[10, 10];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write("A[{0}][{1}] = ", i, j);
                    arr[i, j] = int.Parse(ReadLine());
                }
            }
            int pr = 1, s = 0;
            for (int i = 0; i < m; i++)
            {
                pr *= arr[k, i];
                s += arr[k, i];
            }

            WriteLine("Произведение {0} строки = {1}", k++, pr);
            WriteLine("Сумма {0} строки = {1}", k++, s);
        }
    }
}
