using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using U

namespace _9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(arr1FromDataGridView, 40, false, false, true, false, true);
            DataGridViewUtils.InitGridForArr(arr1ToDataGridView, 40, true, false, false, false, false);

            DataGridViewUtils.InitGridForArr(arr2FromDataGridView, 40, false, true, true, true, true);
            DataGridViewUtils.InitGridForArr(arr2ToDataGridView, 40, true, true, true, true, true);

        }
    }
}
