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
            ((System.ComponentModel.ISupportInitialize)(this.arr2ToDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arr2FromDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // arr2ToDataGridView
            // 
            this.arr2ToDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arr2ToDataGridView.Location = new System.Drawing.Point(10, 50);
            this.arr2ToDataGridView.Name = "arr2ToDataGridView";
            this.arr2ToDataGridView.Size = new System.Drawing.Size(313, 166);
            this.arr2ToDataGridView.TabIndex = 11;
            // 
            // arr2FromDataGridView
            // 
            this.arr2FromDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arr2FromDataGridView.Location = new System.Drawing.Point(360, 50);
            this.arr2FromDataGridView.Name = "arr2FromDataGridView";
            this.arr2FromDataGridView.Size = new System.Drawing.Size(313, 166);
            this.arr2FromDataGridView.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ввод:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(360, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Вывод:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arr2ToDataGridView);
            this.Controls.Add(this.arr2FromDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "9.1";
            ((System.ComponentModel.ISupportInitialize)(this.arr2ToDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arr2FromDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView arr2ToDataGridView;
        private System.Windows.Forms.DataGridView arr2FromDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

