using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Calculator
    {
        public List<Line> Lines { get; set; }

        public Calculator(List<Line> line)
        {
            Lines = line;
        }
        
        public  List<Line> CalcMaxLine(int index)
        {
            List<int> NewList = new List<int>();
            List<Line> List1 = new List<Line>();
            List<Line> List2 = new List<Line>();

            foreach (Line el in Lines)
            {
                for (int i = 0; i < Lines.Count -1; i++)
                {
                    for (int j = 1; j < Lines.Count -1; j++)
                    {
                        if (Lines[i].A * Lines[i + 1].B - Lines[i + 1].A * Lines[i].B == 0)
                        {
                            if (el.B != 0)
                            {
                                List1.Add(el);
                            }
                            else
                            {
                                List2.Add(el);
                            }
                        }

                    }
                }
            }
            if (index == 0)
                return List1;
            else
                return List2;
        }

        public Line ReturnMaxLine(List<Line> list1, List<Line> list2)
        {
            Line val = null;
            foreach (Line l in list1)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    for (int j = 1; j < list1.Count; j++)
                    {
                        if ((list1[i].C > 0 && list1[j].C > 0) || (list1[i].C < 0 && list1[j].C < 0))
                        {
                            if ((list1[i].B / list1[i].C) > (list1[j].B / list1[j].C))
                            {
                                val = list1[i];
                            }
                            else
                            {
                                val = list1[j];
                            }
                        }
                        if ((list1[i].C > 0 && list1[j].C < 0) || (list1[i].C < 0 && list1[j].C > 0))
                        {
                            if (Math.Abs((list1[i].B / list1[i].C)) < Math.Abs((list1[j].B / list1[j].C)))
                            {
                                val = list1[i];
                            }
                            else
                            {
                                val = list1[j];
                            }
                        }
                    }
                }
            }

            foreach (Line l in list2)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    for (int j = 1; j < list2.Count; j++)
                    {                       
                        if ((list2[i].C > 0) && (list2[j].C < 0))
                        {
                            val = list2[j];
                        }
                        else
                        {
                            val = list2[i];
                        }                        
                    }
                }
            }
            return val;
        }
    }
}