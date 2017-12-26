using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{
    class Task_10
    {
         
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Task_10()
        {
            a = a;
            b = b;
            c = c;
        }

        public class FindPoint
        {
            public List<Straight> Lines { get; set; }

            public FindPoint(List<Straight> Lines) => this.Lines = Lines;

            public List<IntersectedLines> AreTheLinesIntersected1()
            {
                List<IntersectedLines> ILines = new List<IntersectedLines>();

                for (int i = 0; i < Lines.Count - 1; i++)
                {
                    for (int j = 0; j < Lines.Count-1; j++)
                    {
                        if ((Lines[i].a == Lines[j].b && Lines[i].b * Lines[j].a && Lines[i].a * Lines[j].c != Lines[i].c * Lines[j].a)
                            || Lines[i].a * Lines[j].b != Lines[i].b * Lines[j].a)
                        {

                            double x = (Lines[i].c * Lines[j].b - Lines[i].b * Lines[j].c) / (Lines[i].b * Lines[j].a - Lines[i].a * Lines[j].b);
                            double y = (Lines[i].a * Lines[j].c - Lines[i].c * Lines[j].a) / (Lines[i].b * Lines[j].a - Lines[i].a * Lines[j].b);

                            IntersectedLines lines = new IntersectedLines(Lines[i].a, Lines[i].b, Lines[i].c, Lines[j].a, Lines[j].b, Lines[j].c, x, y);


                            ILines.Add(lines);
                        }
                    }

                }
                IEnumerable<IntersectedLines> newList = ILines.Distinct();
                List<IntersectedLines> lll = newList.ToList<IntersectedLines>();
                return lll;

            }

            public List<Coords> FindNearestDistance1(List<IntersectedLines> list, out double min, out int indexOfMin)
            {
                double distance = 0;
                IEnumerable<IntersectedLines> newList = list.Distinct();


                List<Coords> coords = new List<Coords>();

                for (int i = 0; i < newList.Count(); i++)
                {

                    distance = Math.Sqrt(Math.Pow(newList.ElementAt(i).x - 0, 2) + Math.Pow(newList.ElementAt(i).y - 0, 2));
                    Coords crds = new Coords(newList.ElementAt(i).x, newList.ElementAt(i).y, distance);
                    coords.Add(crds);

                }

                min = coords[0].distance;
                indexOfMin = 0;
                for (int i = 1; i < coords.Count; i++)
                {

                    if (coords[i].distance < min)
                    {
                        min = coords[i].distance;
                        indexOfMin = i;
                    }

                }

                return coords;

            }



            private List<IntersectedLines> SortList(List<IntersectedLines> list)
            {
                List<IntersectedLines> newList = new List<IntersectedLines>();

                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i].a == list[j].a && list[i].b == list[j].b && list[i].c == list[j].c &&
                            list[i].a1 == list[j].a1 && list[i].b1 == list[j].b1 && list[i].c1 == list[j].c1)
                        {
                            list.Remove(list[j]);
                        }
                        else newList.Add(list[i]);
                    }
                }
                return list;
            }





        }
    }
}
}
