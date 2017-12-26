using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{
    public class Sum
    {
        public int[] Input { get; set; }
        public Sum(int[] S)
        {
            Input = S;
        }
        public int couple(string[] str)
        {
            double[] b = new double[str.Length];
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                b[i] = double.Parse(str[i]);
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (b[i] == (-b[i + 1]))
                {
                    count++;
                    i += 1;
                }
            }
            return count;
        }
        public int summa(int[] s)
        {                  
            int max = Input[0], sum = 0;
            int i1 = 0, i2 = 0;
            int min = Input[0];
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i] > max)
                {
                    max = Input[i];
                    i1 = i;
                }
            }
            for (int i = Input.Length - 1; i >= 0; i--)
            {
                if (Input[i] < min)
                {
                    min =Input[i];
                    i2 = i;
                }
            }
            int c = i1;
            int d = i2;
            if (i1 > i2)
            {
                i2 = c;
                i1 = d;
            }
            for (int k = i1 + 1; k < i2; k++)
            {
                sum += Input[k];
            }
            return sum;
        }
    }
}
