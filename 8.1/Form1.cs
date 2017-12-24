using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassL;

namespace _8._1
{
    public partial class Form1 : Form
    {
        /*
         * 1.	Перевернуть числа в списке слева направо | В input ввести строку с числами, разделённую пробелами
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
                Text = "Результат:"
            };
            this.Controls.Add(label4);
            List<double> list = UtilsW.StringToList<double>(input.Text, ' ');
            Eight logic = new Eight(list);            
            List<double> ll = logic.ListReverse();
            label2.Text = UtilsW.ListtoString<double>(ll, ' ');
        }
    }
}

