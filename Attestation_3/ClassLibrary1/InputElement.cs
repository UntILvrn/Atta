using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class InputElement
    {
        public static int RetunValue(string str)
        {
            int value = 0;
            bool b;
            do
            {
                try
                {
                    Console.Write("Ведите колличество " + str);

                    value = Convert.ToInt32(Console.ReadLine());
                    b = true;
                }
                catch
                {
                    Console.WriteLine("Недопустимое знаечение");
                    b = false;
                }
            }
            while (b == false);


            return value;
        }
        public static int[] Input(int col)
        {
            bool b = true;
            int i = -1;
            int[] mass = new int[col];
            do
            {
                i++;
                if (i == col)
                    i = 0;
                try
                {
                    string[] parts = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if ((parts.Length != 0) && (parts.Length == col))
                        for (int j = 0; j < parts.Length; j++)
                        {
                            mass[j] = int.Parse(parts[j]);
                            b = true;
                        }
                    else
                    {
                        Console.WriteLine("Недопустимое знаечение");
                        b = false;
                    }
                    if (b != false)
                    {
                        b = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Недопустимое знаечение");
                    b = false;
                }
            }
            while (b == false);
            return mass;
        }
    }
}
