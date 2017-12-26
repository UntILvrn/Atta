using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{
    class Task9
    {
        public class Task_9
        {
            public int[,] Input { get; set; }

            public Task_9(int[,] array)
            {
                Input = array;
            }

            public int[,] DelitedStrAndCol()
            {
                int[,] matrix = Input;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    bool checker = true;
                    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                        if (matrix[i,j] != 0) checker = false;
                    if (checker) DelitedAndMovedMatrixStr(i, ref matrix);
                }

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool checker = true;
                    for (int t = 0; t < matrix.GetLength(0) - 1; t++)
                        if (!(matrix[t, j] == matrix[t + 1, j])) checker = false;
                    if (checker) DelitedAndMovedMatrixCol(j, ref matrix);
                }
                return matrix;
            }

            public void DelitedAndMovedMatrixStr(int i, ref int[,] matrix)
            {
                int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                    for (int y = 0; y < i; y++)
                        result[y, j] = matrix[y, j];
                for (int j = 0; j < matrix.GetLength(1); j++)
                    for (int y = i; y < matrix.GetLength(0) - 1; y++)
                        result[y, j] = matrix[y + 1, j];
                matrix = (int[,])result.Clone();
            }

            public void DelitedAndMovedMatrixCol(int j, ref int[,] matrix)
            {
                int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int y = 0; y < j; y++)
                        result[i, y] = matrix[i, y];
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int y = j; y < matrix.GetLength(1) - 1; y++)
                        result[i, y] = matrix[i, y + 1];
                matrix = (int[,])result.Clone();
            }
        }
    }
}
