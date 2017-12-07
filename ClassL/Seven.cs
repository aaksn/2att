using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassL
{
    public class Seven
    {
        public double[] Str { get; set; }

        public Seven(double[] str)
        {
            Str = str;
        }
        public void ProductOfN(out double sum)
        {
            sum = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str.Length == 1)
                {
                    sum = 0;
                }
                else
                {
                    if (i != Str.Length - 1)
                    {
                        sum += Str[i] * Str[i + 1];
                    }
                }
            }
        }
    }
    public class Seven2
    {
        public int[] Str { get; set; }

        public Seven2(int[] str)
        {
            Str = str;
        }
        public void MinusEPosition(out int sum)
        {
            sum = 0;
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str.Length == 1)
                {
                    sum = -1;
                }
                else
                {
                    int duo = i % 2;
                    if (duo != 0 && Str[i] < 0)
                    {
                        sum = i + 1;
                        break;
                    }
                    else
                    {
                        sum = -1;
                    }
                }
            }
        }
    }
}
