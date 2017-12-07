using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassL;


namespace _6._1
{
    public partial class Form1 : Form
    {
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
                Location = new System.Drawing.Point(140, 30),
                Name = "label3",
                Size = new System.Drawing.Size(108, 22),
                TabIndex = 0,
                Text = "Количество слов:"
            };
            this.Controls.Add(label4);
            Six logic = new Six(input.Text);
            int Count;
            logic.CountA(out Count, 3, 'а');
            label2.Text = Convert.ToString(Count);
        }
    }
}
