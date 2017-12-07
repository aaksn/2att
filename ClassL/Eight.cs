using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassL
{
    public class Eight
    {
        public List<double> List { get; set; }

        public Eight(List<double> list)
        {
            List = list;
        }
        public void ListReverse(out List<double> ll)
        {
            ll = List;            
            ll.Reverse();
        }
    }
}
