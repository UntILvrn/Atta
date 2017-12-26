using System;
 using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = 0;
            while ((h >= 0))
            {
                Console.WriteLine("Введите отрицательное число если хотите закрыть программу");
                h = Input("h");
                double vvod = Drawing(h);
                if (h < 0)
                {
                    break;
                }
            }
        }


        static double Input(string varName)
        {
            double x = 0;
            bool b;
            do
            {
                try
                {
                    Console.Write("Введите четное число {0}: ", varName);

                    x = Convert.ToDouble(Console.ReadLine());

                    if (x < 0)
                    {
                        Console.Write("");
                        b = false;
                        return -1;
                    }
                    if (x % 2 != 0)
                    {
                        Console.WriteLine("Число должно быть четным");
                        b = false;
                        //return -1;
                    }
                    else
                        b = true;

                }
                catch
                {

                    Console.WriteLine("Недопустимое значение");
                    b = false;
                }
            }
            while (b == false);
            return x;
        }
        static double Drawing(double s)
        {
            for (double r = s / 2; r < s; r++)
            {
                for (int c = 0; c < s; c++)
                {
                    char ch = ' ';
                    if (r == s - 1)
                        ch = '_';

                    if (c == r)
                        ch = '\\';

                    if (s - c == r + 1)
                        ch = '/';

                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            return s;
        }
    }
}
    
