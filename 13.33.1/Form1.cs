using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using ClassL;
using System.Diagnostics;

namespace _13._33._1
{
    public partial class Form1 : Form
    {
        /*
         * 33.	Игра "Линии". Подробнее о правилах в GameInfo.doc
         * */

        private Game game = new Game();
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateView()
        {
            switch (game.State)
            {
                case GameState.PLAYING:
                    gamestatus.Text = "Игра идет";
                    gamestatus.ForeColor = Color.Gray;
                    break;                
                case GameState.FAIL:
                    gamestatus.Text = "Поражение :(";
                    gamestatus.ForeColor = Color.Red;
                    break;
            }

            ballscount.Invalidate();
            ballscount.Text = game.Ballsonfield.ToString();
            score.Invalidate();
            score.Text = game.Score.ToString();
            paintCellDataGridView.Invalidate();
        }
        private void paintCellDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {            
            GameCell cell = game[e.RowIndex, e.ColumnIndex];
            
            // отрисовка фона
            e.CellStyle.BackColor = cell.choose == true ? Color.Yellow : Color.White;
            // прорисовываем фон (собственно прорисовывает DataGridView)            
            e.PaintBackground(e.CellBounds, false);            

            // отрисовка содержимого
            
            if (cell.state == CellState.BALL)
            {
                // уменьшаем размеры области ячейки для прорисовки круга
                Rectangle ellipseRect = e.CellBounds;
                ellipseRect.Inflate(-10, -10);
                // включаем антиалиасинг
                SmoothingMode smoothingModeOriginal = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                // прорисовываем круг в зависимости от заданного цвета                
                e.Graphics.FillEllipse(new SolidBrush(Color.FromName(cell.color.ToString())), ellipseRect);
                e.Graphics.DrawEllipse(new Pen(Color.FromName(cell.color.ToString())), ellipseRect);
                // выключаем антиалиасинг (иначе могут наблюдаться артефакты при прорисовке границ)
                e.Graphics.SmoothingMode = smoothingModeOriginal;
            }
            else if (cell.state == CellState.NEWBALL)
            {
                // уменьшаем размеры области ячейки для прорисовки круга
                Rectangle ellipseRect = e.CellBounds;
                ellipseRect.Inflate(-10, -10);
                // включаем антиалиасинг
                SmoothingMode smoothingModeOriginal = e.Graphics.SmoothingMode;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                // прорисовываем границы появляющегося круга в зависимости от заданного цвета
                e.Graphics.DrawEllipse(new Pen(Color.FromName(cell.newcolor.ToString())), ellipseRect);
                // выключаем антиалиасинг (иначе могут наблюдаться артефакты при прорисовке границ)
                e.Graphics.SmoothingMode = smoothingModeOriginal;
            }
            // предотвращаем дальнейшую прорисовку ячейки DataGridView
            e.Handled = true;
        }


        private void paintCellDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                game.LeftMouseClick(e.RowIndex, e.ColumnIndex);
                UpdateView();
            }           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cellSize = paintCellDataGridView.RowTemplate.Height;
            DataGridViewUtils.InitGridForArr(paintCellDataGridView, cellSize, true, false, false, false, false);
            paintCellDataGridView.RowCount = 9;
            paintCellDataGridView.ColumnCount = 9;
            paintCellDataGridView.Width = paintCellDataGridView.ColumnCount * cellSize + 3;
            paintCellDataGridView.Height = paintCellDataGridView.RowCount * cellSize + 3;
            newgame.PerformClick();
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            game.NewGame(9);
            UpdateView();
        }
    }
}
