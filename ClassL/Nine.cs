using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassL
{
    public class Nine
    {
        public int[,] Mas { get; set; }

        public Nine(int[,] mas)
        {
            Mas = mas;
        }
        public void Process(out int[,] res) 
        {
            res = Mas;            
            
        }
    }
}
