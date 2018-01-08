using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class InputABC
    {
        public static List<Line> ReturnList(int[,] Mass)
        {
            List<Line> LinelList = new List<Line>();
            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                int A = Mass[i, 0];
                int B = Mass[i, 1];
                int C = Mass[i, 2];
                LinelList.Add(new Line(A, B, C));
            }
            return LinelList;
        }
    }
}

