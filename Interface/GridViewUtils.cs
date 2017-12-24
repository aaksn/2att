using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utils
{
    public class GridViewUtils
    {
        public static void Arr2ToGridView<T>(DataGridView dgv, T[,] data) {
            int rowCount = data.GetLength(0),
                colCount = data.GetLength(1);

            dgv.RowCount = rowCount;
            dgv.ColumnCount = colCount;
            for (int r = 0; r < rowCount; r++)
                for (int c = 0; c < colCount; c++)
                    dgv[c, r].Value = data[r, c].ToString();
        }
    }
}
