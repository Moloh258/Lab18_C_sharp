using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab18_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Write("Введите кол-во строк: ");
            n = int.Parse(ReadLine());

            Write("Введите кол-во столбцов: ");
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
            int pr = 1, min = 99999, ind = 0;

            for (int i = 0; i < n; i++)
            {
                pr = 1;
                for (int j = 0; j < m; j++)
                {
                    pr *= arr[j, i];
                }
                if (pr < min)
                {
                    min = pr;
                    ind = i;
                }
            }
            Write("Произведение = {0}, номер столбца = {1}", min, ind);
        }
    }
}
