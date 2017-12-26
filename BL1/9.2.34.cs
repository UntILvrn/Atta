using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{
    class Logic34
    {
        public int[,] Arr { get; set; }
        public Logic34(int[,] arr)
        {
            Arr = arr;
        }
        public int[,] NewMatrix(int[,] arr)
        {
            int check = CountOfValueInRow(Arr);
            if (check > 0)
            {
                ColRight(arr);
                RowDown(arr);
            }
            return Arr;


        }
        public int CountOfValueInRow(int[,] arr)
        {
            int count = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                count = i;
            }
            return count;
        }
        public int[,] ColRight(int[,] arr)
        {
            int k;
            int sort = Arr.Length;
            int rowCount = arr.GetLength(0);
            int colCount = arr.GetLength(1);
            for (int r = 0; r < rowCount; r++)
            {
                bool f = true;
                for (int c = 0; c < colCount; c++)
                {
                    if (Arr[r, c] != 0 && Arr[r + 1, c] != 0)
                    {
                        f = false;
                    }
                }
                if (f == true)
                {
                    for (int c = 0; c < colCount; c++)
                    {
                        k = Arr[sort, c];
                        Arr[sort, c] = Arr[r, c];
                        Arr[r, c] = k;
                    }
                    sort++;
                }

            }
            return Arr;
        }


        public int[,] RowDown(int[,] arr)
        {
            int k;
            int sort = arr.Length;
            int rowCount = arr.GetLength(0);
            int colCount = arr.GetLength(1);
            for (int r = 0; r < rowCount; r++)
            {
                bool f = true;
                for (int c = 0; c < colCount; c++)
                {
                    if (Arr[r, c] != 0 && Arr[r, c + 1] != 0)
                    {
                        f = false;
                    }
                }
                if (f == true)
                {
                    for (int c = 0; c < colCount; c++)
                    {
                        k = Arr[sort, c];
                        Arr[sort, c] = Arr[r, c];
                        Arr[r, c] = k;
                    }
                    sort++;
                }
            }
            return Arr;
        }
    }
}