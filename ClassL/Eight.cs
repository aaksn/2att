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
        public List<double> ListReverse()
        {
            List.Reverse();
            return List;
        }
    }
}
