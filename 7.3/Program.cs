using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._1
{
    static class Program
    {
        public static string TextPrint(string z)
        {            
            string k = Sumresult(Inpt(z));
            return k;
        }
        public static List<int> Inpt(string z)
        {
            List<int> parts = new List<int>();
            string[] words = z.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (int.TryParse(words[i], out int n))
                { 
                    parts.Add(n);
                }
                else
                {
                    parts.Clear();
                    break;
                }
            }            
            return parts;
        }
        public static string Sumresult(List<int> list)
        {
            int k = list.Count<int>();
            if (k==0)
            {
                return "Err";
            }
            else
            {
                list.Reverse();
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (int item in list)
                {
                    string j = Convert.ToString(item);
                    sb.Append(j+" ");
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

