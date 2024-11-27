using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП6.HelperClasses
{
    public class HelperTask1
    {
        public HelperTask1()
        { }
        public void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void RandomFilling(int[,] matrix)
        {
            Random random = new Random();
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 101);
                }
            }
        }
        public void OneFilling(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 1;
                }
            }
        }

        public void DiamondFilling(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int center = n / 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    bool c1 = i + n/2 < j;
                    bool c2 = i > j + n/2;
                    bool c3 = (i + n/2) + j < n - 1;
                    bool c4 = (j < i - n / 2) || (j > (n - 1) - (i - n / 2));

                    if (!(c1 || c2 || c3 || c4))
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
        }
    }
}
