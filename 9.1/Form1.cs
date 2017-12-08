using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using ClassL;


namespace _9._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputOpenFileDialog.InitialDirectory = IOUtils.ExeDir;
            inputSaveFileDialog.InitialDirectory = IOUtils.ExeDir;
            outputSaveFileDialog.InitialDirectory = IOUtils.ExeDir;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {           

            DataGridViewUtils.InitGridForArr(arr2FromDataGridView, 40, false, true, true, true, true);
            DataGridViewUtils.InitGridForArr(arr2ToDataGridView, 40, true, true, true, true, true);

        }

        private void Rndinputgrid_Click(object sender, EventArgs e)
        {
            int[,] arr2 = ArrayUtils.CreateRandomArray2(Convert.ToInt32(xcount.Text), Convert.ToInt32(ycount.Text), Convert.ToInt32(frominput.Text), Convert.ToInt32(toinput.Text));
            DataGridViewUtils.ArrayToGrid(arr2FromDataGridView, arr2);
        }

        private void Go_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] arr2 = DataGridViewUtils.GridToArray2<int>(arr2FromDataGridView);
                Nine logic = new Nine(arr2);
                logic.Process(out int[,] res);                 
                DataGridViewUtils.ArrayToGrid(arr2ToDataGridView, res);
            }
            catch (Exception except)
            {
                FormsUtils.ErrorMessageBox(except);
            }
        }

        private void inputFromFileButton_Click(object sender, EventArgs e)
        {
            
        }

        private void inputToFileButton_Click(object sender, EventArgs e)
        {

        }

        private void outputToFileButton_Click(object sender, EventArgs e)
        {

        }
    }
}
