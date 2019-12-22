using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab18_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Write("Введите N: ");
            n = int.Parse(ReadLine());

            Write("Введите M: ");
            m = int.Parse(ReadLine());

            int[,] arr = new int[10, 10];
            double[] b = new double[10];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write("A[{0}][{1}] = ", i, j);
                    arr[i, j] = int.Parse(ReadLine());
                }
            }
            double sr = 0, k = 0;

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += arr[j, i];
                }
                sr = sum / n;
                b[i] = sr;
            }

            for (int i = 0; i < m; i++)
            {
                k = 0;
                for (int j = 0; j < m; j++)
                {
                    if (b[i] < arr[j, i])
                    {
                        k++;
                    }
                }
                WriteLine("{0} столбец, количество {1}", i, k);
            }
        }
    }
}
