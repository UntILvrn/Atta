using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{
    public class WorkList
    {
        public List<int> List { get; set; }
        public WorkList(List<int> l)
        {
            List = l;
        }
        public List<int> Uniq()
        {
            List<int> newList = new List<int>();
            foreach (int i in List)
            {               
                if (IndexOf(List, i)==false)
                    newList.Add(i);
            }
            return newList;
        }
        public bool IndexOf(List<int> list, int test)
        {
            foreach (int element in list)
            {
                if (element == test)
                    return false;
            }
            return true;
        }
    }
}