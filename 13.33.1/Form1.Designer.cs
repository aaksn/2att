namespace _13._33._1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }        

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.paintCellDataGridView = new System.Windows.Forms.DataGridView();
            this.ballslabel = new System.Windows.Forms.Label();
            this.ballscount = new System.Windows.Forms.Label();
            this.scorecount = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.gamestatus = new System.Windows.Forms.Label();
            this.newgame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintCellDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // paintCellDataGridView
            // 
            this.paintCellDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paintCellDataGridView.Location = new System.Drawing.Point(72, 67);
            this.paintCellDataGridView.Name = "paintCellDataGridView";
            this.paintCellDataGridView.RowTemplate.Height = 50;
            this.paintCellDataGridView.Size = new System.Drawing.Size(163, 151);
            this.paintCellDataGridView.TabIndex = 15;
            this.paintCellDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.paintCellDataGridView_CellMouseClick);
            this.paintCellDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.paintCellDataGridView_CellPainting);
            // 
            // ballslabel
            // 
            this.ballslabel.AutoSize = true;
            this.ballslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ballslabel.Location = new System.Drawing.Point(12, 9);
            this.ballslabel.Name = "ballslabel";
            this.ballslabel.Size = new System.Drawing.Size(166, 55);
            this.ballslabel.TabIndex = 16;
            this.ballslabel.Text = "Шары:";
            // 
            // ballscount
            // 
            this.ballscount.AutoSize = true;
            this.ballscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ballscount.Location = new System.Drawing.Point(166, 9);
            this.ballscount.Name = "ballscount";
            this.ballscount.Size = new System.Drawing.Size(51, 55);
            this.ballscount.TabIndex = 17;
            this.ballscount.Text = "0";
            // 
            // scorecount
            // 
            this.scorecount.AutoSize = true;
            this.scorecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scorecount.Location = new System.Drawing.Point(295, 9);
            this.scorecount.Name = "scorecount";
            this.scorecount.Size = new System.Drawing.Size(176, 55);
            this.scorecount.TabIndex = 18;
            this.scorecount.Text = "Очков:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.Location = new System.Drawing.Point(457, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(51, 55);
            this.score.TabIndex = 19;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gamestatus
            // 
            this.gamestatus.AutoSize = true;
            this.gamestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamestatus.Location = new System.Drawing.Point(12, 527);
            this.gamestatus.Name = "gamestatus";
            this.gamestatus.Size = new System.Drawing.Size(205, 38);
            this.gamestatus.TabIndex = 20;
            this.gamestatus.Text = "Статус игры";
            // 
            // newgame
            // 
            this.newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newgame.Location = new System.Drawing.Point(388, 525);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(201, 49);
            this.newgame.TabIndex = 21;
            this.newgame.Text = "Новая игра";
            this.newgame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 575);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.gamestatus);
            this.Controls.Add(this.score);
            this.Controls.Add(this.scorecount);
            this.Controls.Add(this.ballslabel);
            this.Controls.Add(this.paintCellDataGridView);
            this.Controls.Add(this.ballscount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paintCellDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView paintCellDataGridView;
        private System.Windows.Forms.Label ballslabel;
        private System.Windows.Forms.Label ballscount;
        private System.Windows.Forms.Label scorecount;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label gamestatus;
        private System.Windows.Forms.Button newgame;
    }
}

