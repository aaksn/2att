using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassL;

namespace _7._1
{
    public partial class Form1 : Form
    {
        /*
 * 1.	Дан массив размера N. Вычислить сумму произведений всех пар соседних чисел.
 * | В input ввести строку с числами, разделённую пробелами
 * */
        public Form1()
        {
            InitializeComponent();
        }        
        private void Go_Click(object sender, EventArgs e)
        {            
            //1
            Label label4 = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial Narrow", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new System.Drawing.Point(12, 50),
                Name = "label3",
                Size = new System.Drawing.Size(108, 22),
                TabIndex = 0,
                Text = "Сумма:"
            };
            this.Controls.Add(label4);
            double[] words = UtilsW.StrToArray<double>(input.Text);
            Seven logic = new Seven(words);            
            label2.Text = Convert.ToString(logic.ProductOfN());
        }
    }
}
