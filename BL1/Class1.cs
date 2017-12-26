using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{
    public class ex7
    {
        public string Imput { get; set; }
        public ex7(string str)
        {
            Imput = str;
        }
        public string couple()
        {
            char[] delimeters = { ' ', '.', ',', ';' };
            string[] a = Imput.Split(delimeters);
            double[] b = new double[a.Length];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
                b[i] = double.Parse(a[i]);
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (b[i] == (-b[i + 1]))
                {
                    count++;
                    i += 1;
                }
            }
            string output = Convert.ToString(count);
            return output;
        }
    }
    public class Utility
    {
        public string Imput { get; set; }
        public Utility(string str)
        {
            Imput = str;
        }
        public string getdat()
        {
            string s=Imput, s1 = null;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    s1 = s1 + String.Copy(s[i] + "");
                }
                if ((i != 0) && (i != (s.Length - 1)))
                {
                    if ((s[i] == ' ') && (s[i - 1] != ' '))
                    {
                        s1 = s1 + ".";
                    }
                }
            }
            string output = Convert.ToString(s1);
            return output;
        }
    }
}


