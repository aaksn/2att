namespace _9._1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        private void InitializeComponent()
        {
            this.arr2ToDataGridView = new System.Windows.Forms.DataGridView();
            this.arr2FromDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RndTextInfo = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.frominput = new System.Windows.Forms.TextBox();
            this.toinput = new System.Windows.Forms.TextBox();
            this.xcount = new System.Windows.Forms.TextBox();
            this.ycount = new System.Windows.Forms.TextBox();
            this.xlabel = new System.Windows.Forms.Label();
            this.Rndinputgrid = new System.Windows.Forms.Button();
            this.inputOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.inputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Go = new System.Windows.Forms.Button();
            this.inputFromFileButton = new System.Windows.Forms.Button();
            this.inputToFileButton = new System.Windows.Forms.Button();
            this.outputToFileButton = new System.Windows.Forms.Button();
            this.outputSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arr2ToDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arr2FromDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // arr2ToDataGridView
            // 
            this.arr2ToDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arr2ToDataGridView.Location = new System.Drawing.Point(480, 62);
            this.arr2ToDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.arr2ToDataGridView.Name = "arr2ToDataGridView";
            this.arr2ToDataGridView.Size = new System.Drawing.Size(417, 204);
            this.arr2ToDataGridView.TabIndex = 11;
            // 
            // arr2FromDataGridView
            // 
            this.arr2FromDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arr2FromDataGridView.Location = new System.Drawing.Point(13, 62);
            this.arr2FromDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.arr2FromDataGridView.Name = "arr2FromDataGridView";
            this.arr2FromDataGridView.Size = new System.Drawing.Size(417, 204);
            this.arr2FromDataGridView.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ввод:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(480, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Вывод:";
            // 
            // RndTextInfo
            // 
            this.RndTextInfo.AutoSize = true;
            this.RndTextInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RndTextInfo.Location = new System.Drawing.Point(15, 326);
            this.RndTextInfo.Name = "RndTextInfo";
            this.RndTextInfo.Size = new System.Drawing.Size(299, 25);
            this.RndTextInfo.TabIndex = 13;
            this.RndTextInfo.Text = "Заполнить таблицу размером";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.from.Location = new System.Drawing.Point(15, 363);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(243, 25);
            this.from.TabIndex = 14;
            this.from.Text = "случайными числами от";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to.Location = new System.Drawing.Point(312, 363);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(35, 25);
            this.to.TabIndex = 15;
            this.to.Text = "до";
            // 
            // frominput
            // 
            this.frominput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frominput.Location = new System.Drawing.Point(264, 360);
            this.frominput.Name = "frominput";
            this.frominput.Size = new System.Drawing.Size(42, 30);
            this.frominput.TabIndex = 16;
            this.frominput.Text = "1";
            this.frominput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toinput
            // 
            this.toinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toinput.Location = new System.Drawing.Point(353, 360);
            this.toinput.Name = "toinput";
            this.toinput.Size = new System.Drawing.Size(42, 30);
            this.toinput.TabIndex = 17;
            this.toinput.Text = "50";
            this.toinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xcount
            // 
            this.xcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xcount.Location = new System.Drawing.Point(320, 323);
            this.xcount.Name = "xcount";
            this.xcount.Size = new System.Drawing.Size(42, 30);
            this.xcount.TabIndex = 18;
            this.xcount.Text = "10";
            this.xcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ycount
            // 
            this.ycount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ycount.Location = new System.Drawing.Point(396, 323);
            this.ycount.Name = "ycount";
            this.ycount.ReadOnly = true;
            this.ycount.Size = new System.Drawing.Size(42, 30);
            this.ycount.TabIndex = 18;
            this.ycount.Text = "3";
            this.ycount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xlabel.Location = new System.Drawing.Point(368, 326);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(22, 25);
            this.xlabel.TabIndex = 19;
            this.xlabel.Text = "x";
            // 
            // Rndinputgrid
            // 
            this.Rndinputgrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rndinputgrid.Location = new System.Drawing.Point(64, 396);
            this.Rndinputgrid.Name = "Rndinputgrid";
            this.Rndinputgrid.Size = new System.Drawing.Size(283, 44);
            this.Rndinputgrid.TabIndex = 20;
            this.Rndinputgrid.Text = "Заполнить";
            this.Rndinputgrid.UseVisualStyleBackColor = true;
            this.Rndinputgrid.Click += new System.EventHandler(this.Rndinputgrid_Click);
            // 
            // inputOpenFileDialog
            // 
            this.inputOpenFileDialog.DefaultExt = "txt";
            this.inputOpenFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // inputSaveFileDialog
            // 
            this.inputSaveFileDialog.DefaultExt = "txt";
            this.inputSaveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Go.Location = new System.Drawing.Point(535, 396);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(283, 44);
            this.Go.TabIndex = 21;
            this.Go.Text = "Решение";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // inputFromFileButton
            // 
            this.inputFromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFromFileButton.Location = new System.Drawing.Point(13, 273);
            this.inputFromFileButton.Name = "inputFromFileButton";
            this.inputFromFileButton.Size = new System.Drawing.Size(218, 44);
            this.inputFromFileButton.TabIndex = 22;
            this.inputFromFileButton.Text = "Загрузить из файла";
            this.inputFromFileButton.UseVisualStyleBackColor = true;
            this.inputFromFileButton.Click += new System.EventHandler(this.inputFromFileButton_Click);
            // 
            // inputToFileButton
            // 
            this.inputToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputToFileButton.Location = new System.Drawing.Point(237, 273);
            this.inputToFileButton.Name = "inputToFileButton";
            this.inputToFileButton.Size = new System.Drawing.Size(192, 43);
            this.inputToFileButton.TabIndex = 23;
            this.inputToFileButton.Text = "Сохранить в файл";
            this.inputToFileButton.UseVisualStyleBackColor = true;
            this.inputToFileButton.Click += new System.EventHandler(this.inputToFileButton_Click);
            // 
            // outputToFileButton
            // 
            this.outputToFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputToFileButton.Location = new System.Drawing.Point(535, 273);
            this.outputToFileButton.Name = "outputToFileButton";
            this.outputToFileButton.Size = new System.Drawing.Size(283, 44);
            this.outputToFileButton.TabIndex = 24;
            this.outputToFileButton.Text = "Сохранить в файл";
            this.outputToFileButton.UseVisualStyleBackColor = true;
            this.outputToFileButton.Click += new System.EventHandler(this.outputToFileButton_Click);
            // 
            // outputSaveFileDialog
            // 
            this.outputSaveFileDialog.DefaultExt = "txt";
            this.outputSaveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(663, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "N";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(514, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Количество параллельных линий";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputToFileButton);
            this.Controls.Add(this.inputToFileButton);
            this.Controls.Add(this.inputFromFileButton);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Rndinputgrid);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.xcount);
            this.Controls.Add(this.ycount);
            this.Controls.Add(this.toinput);
            this.Controls.Add(this.frominput);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.RndTextInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arr2ToDataGridView);
            this.Controls.Add(this.arr2FromDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "9.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arr2ToDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arr2FromDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView arr2ToDataGridView;
        private System.Windows.Forms.DataGridView arr2FromDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RndTextInfo;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.TextBox frominput;
        private System.Windows.Forms.TextBox toinput;
        private System.Windows.Forms.TextBox xcount;
        private System.Windows.Forms.TextBox ycount;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Button Rndinputgrid;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.OpenFileDialog inputOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog inputSaveFileDialog;
        private System.Windows.Forms.Button inputFromFileButton;
        private System.Windows.Forms.Button inputToFileButton;
        private System.Windows.Forms.Button outputToFileButton;
        private System.Windows.Forms.SaveFileDialog outputSaveFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

