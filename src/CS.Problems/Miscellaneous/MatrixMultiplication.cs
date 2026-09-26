using System;

namespace CS.Problems.Miscellaneous
{
    public class MatrixMultiplication
    {
        public static int[,] Multiply(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                throw new Exception("Matrice A don't have same number of rows as the columns of matrix B.");
            }

            var rows = a.GetLength(0);
            var cols = b.GetLength(1);
            var shared = a.GetLength(1);

            var result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < shared; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return result;
        }
    }
}
