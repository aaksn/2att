using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassL
{
    public class Six
    {
        public string Str { get; set; }
        public Six(string str)
        {
            Str = str;
        }
        //h - количество символов w для поиска
        public void CountA(out int sum, int h, char w)
        {
            sum = 0;
            string[] words = UtilsW.StrToArray<string>(Str);
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                foreach (char c in words[i])
                    if (c == w)
                    {
                        count++;
                        if (count == h)
                        {
                            sum++;
                        }
                    }
            }            
        }
    }
}
