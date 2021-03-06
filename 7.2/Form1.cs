﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassL;

namespace _7._2
{
    public partial class Form1 : Form
    {
        /*
 * 32.	Вводится массив целых чисел.
 * Определить позицию первого отрицательного элемента в четной позиции или, что такого элемента не существует
 * (для этого реализовать функцию, которая будет возвращать позицию найденного элемента или -1 в случае его отсутствия).
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
                Text = "Позиция:"
            };
            this.Controls.Add(label4);
            int[] words = UtilsW.StrToArray<int>(input.Text);
            Seven2 logic = new Seven2(words);            
            label2.Text = Convert.ToString(logic.MinusEPosition());
        }
    }
}
