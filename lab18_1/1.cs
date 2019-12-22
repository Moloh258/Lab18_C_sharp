using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;

            Write("Введите квадратную матрицу: ");
            m = int.Parse(ReadLine());


            int[,] arr = new int[10, 10];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write("A[{0}][{1}] = ", i, j);
                    arr[i, j] = int.Parse(ReadLine());
                }
            }
            for (int j = 0; j <= m; j++, m--)
            {
                for (int i = j; i < m; i++)
                {
                    Write("{0}  ", arr[j, i]);
                }
                for (int i = j + 1; i < m; i++)
                {
                    Write("{0}  ", arr[i, m - j - 1]);
                }
                for (int i = j + 1; i < m; i++)
                {
                    Write("{0}  ", arr[m - j - 1, m - i - 1]);
                }
                for (int i = j + 1; i < m - 1; i++)
                {
                    Write("{0}  ", arr[m - i - 1, j]);
                }
            }
        }
    }
}
