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
using System.IO;



namespace _9._2
{
    public partial class Form1 : Form
    {
        /*
         * 32.	В заданной матрице А(nn) найти минимум всех сумм абсолютных величин элементов матрицы по столбцам.
         * | Для работы через консоль в параметрах командной строки (Свойства проекта - Отладка) указать --input-file='Путь к входным данным' --output-file='Путь к выходным данным'
         * (я использую --input-file=./in.txt --output-file=./out.txt )
         * */
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
                logic.Process2(out int[,] res, out int resmin);                 
                DataGridViewUtils.ArrayToGrid(arr2ToDataGridView, res);
                labelres.Text = resmin.ToString();
                label3.Show();
            }
            catch (Exception except)
            {
                FormsUtils.ErrorMessageBox(except);
            }
        }

        private void inputFromFileButton_Click(object sender, EventArgs e)
        {
            if (inputOpenFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputOpenFileDialog.InitialDirectory = Path.GetDirectoryName(inputOpenFileDialog.FileName);

                    int[,] input;
                    UtilsW.ReadInputFromFile(inputOpenFileDialog.FileName,' ', out input);
                    DataGridViewUtils.ArrayToGrid(arr2FromDataGridView, input);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }

        private void inputToFileButton_Click(object sender, EventArgs e)
        {
            if (inputSaveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    inputSaveFileDialog.InitialDirectory = Path.GetDirectoryName(inputSaveFileDialog.FileName);

                    int[,] input = DataGridViewUtils.GridToArray2<int>(arr2FromDataGridView);
                    UtilsW.WriteInputIntoFile(inputSaveFileDialog.FileName, input);
                    Console.WriteLine(inputSaveFileDialog.FileName);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }

        }

        private void outputToFileButton_Click(object sender, EventArgs e)
        {
            if (outputSaveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    outputSaveFileDialog.InitialDirectory = Path.GetDirectoryName(outputSaveFileDialog.FileName);
                    int[,] output = DataGridViewUtils.GridToArray2<int>(arr2ToDataGridView);
                    UtilsW.WriteInputIntoFile(outputSaveFileDialog.FileName, output);

                    /*IList<int> output = DataGridViewUtils.GridToList<int>(arr2ToDataGridView);
                    Nine.WriteOutputIntoFile(outputSaveFileDialog.FileName, output);
                    */
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }

        private void xcount_TextChanged(object sender, EventArgs e)
        {
            ycount.Text = xcount.Text;
        }
    }
}
