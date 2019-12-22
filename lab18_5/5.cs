using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab18_5
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

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Write("A[{0}][{1}] = ", i, j);
                    arr[i, j] = int.Parse(ReadLine());
                }
            }
            int k = 0;
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                flag = true;
                for (int j = 0; j < m; j++)
                {
                    if (arr[j, i] % 2 == 0)
                    {
                        flag = false;
                    }

                }
                if (flag)
                {
                    k = i;
                    Write("Номер первого столбца со всеми нечетными числами: {0}", k);
                    ReadKey();
                    return;
                }
            }

            Write(k);
        }
    }
}
