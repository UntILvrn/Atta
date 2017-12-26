using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1
{
    public class WorkList1
    {
        public List<int> List { get; set; }
        public WorkList1(List<int> l)
        {
            List = l;
        }
        public List<int> Uniq()
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < List.Count; i++)
            {
                if (!newList.Contains(List[i]))
                {
                    newList.Add(List[i]);
                }
            }
            return newList;
        }

        public bool IndexOf(List<int> list, int value)
        {
            bool prov = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                    prov = true;
            }
            return prov;
        }
    }
}