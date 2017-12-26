using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{    
    public class WorkNumber
    {
        public string Imput { get; set; }
        public WorkNumber (string S)
        {
            Imput = S;
        }

        public string getdat()
        {
            string s=Imput, s1 = null;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    s1 += s[i];
                }
                if ((i != 0) && (i != (s.Length - 1)))
                {
                    if ((s[i] == ' ') && (s[i - 1] != ' '))
                    {
                        s1 = s1 + ".";
                    }
                }
            }
            return s1;
        }
    }       
}


