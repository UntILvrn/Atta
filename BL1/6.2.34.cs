using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{
    public class WorkCounting
    {
        public double X { get; set; }
        public double N { get; set; }
        public double E { get; set; }
        public WorkCounting(double x, int n, double e)
        {
            X = x;
            N = n;
            E = e;
        }
        public void Funсtion(out double Sn, out double Se, out double See, out double formula)
        {
            double a = X;
            Sn = 0; Se = 0; See = 0;
            int ne = 0, ne2 = 0;
            int i = 1;
            while (i <= N || Math.Abs(a) > E / 10)
            {
                if (i <= N)
                    Sn += a;
                if (Math.Abs(a) > E)
                {
                    Se += a;
                    ne++;
                }
                if (Math.Abs(a) > E / 10)
                {
                    See += a;
                    ne2++;
                }
                i++;
                a = -a * (X * X * i * i) / ((i + 4) * (i + 2));
            }
            formula = Math.Log(X + Math.Sqrt(X * X + 1));
        }
    }
}
