namespace _10sroC_
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.VivodList = new System.Windows.Forms.Button();
            this.RemoveQb = new System.Windows.Forms.Button();
            this.DubliR = new System.Windows.Forms.Button();
            this.SortTb = new System.Windows.Forms.Button();
            this.ClearSpisok = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 55);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 228);
            this.listBox1.TabIndex = 2;
            // 
            // VivodList
            // 
            this.VivodList.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.VivodList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VivodList.Location = new System.Drawing.Point(12, 79);
            this.VivodList.Name = "VivodList";
            this.VivodList.Size = new System.Drawing.Size(151, 57);
            this.VivodList.TabIndex = 56;
            this.VivodList.Text = "Вывод в listbox";
            this.VivodList.UseVisualStyleBackColor = false;
            this.VivodList.Click += new System.EventHandler(this.VivodList_Click);
            // 
            // RemoveQb
            // 
            this.RemoveQb.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RemoveQb.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveQb.Location = new System.Drawing.Point(183, 79);
            this.RemoveQb.Name = "RemoveQb";
            this.RemoveQb.Size = new System.Drawing.Size(151, 57);
            this.RemoveQb.TabIndex = 57;
            this.RemoveQb.Text = "Удаление Q";
            this.RemoveQb.UseVisualStyleBackColor = false;
            this.RemoveQb.Click += new System.EventHandler(this.RemoveQb_Click);
            // 
            // DubliR
            // 
            this.DubliR.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.DubliR.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DubliR.Location = new System.Drawing.Point(357, 79);
            this.DubliR.Name = "DubliR";
            this.DubliR.Size = new System.Drawing.Size(171, 57);
            this.DubliR.TabIndex = 58;
            this.DubliR.Text = "Дублирование R";
            this.DubliR.UseVisualStyleBackColor = false;
            this.DubliR.Click += new System.EventHandler(this.DubliR_Click);
            // 
            // SortTb
            // 
            this.SortTb.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SortTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortTb.Location = new System.Drawing.Point(554, 79);
            this.SortTb.Name = "SortTb";
            this.SortTb.Size = new System.Drawing.Size(151, 57);
            this.SortTb.TabIndex = 59;
            this.SortTb.Text = "Сортировка T";
            this.SortTb.UseVisualStyleBackColor = false;
            this.SortTb.Click += new System.EventHandler(this.SortTb_Click);
            // 
            // ClearSpisok
            // 
            this.ClearSpisok.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClearSpisok.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearSpisok.Location = new System.Drawing.Point(727, 79);
            this.ClearSpisok.Name = "ClearSpisok";
            this.ClearSpisok.Size = new System.Drawing.Size(159, 57);
            this.ClearSpisok.TabIndex = 60;
            this.ClearSpisok.Text = "Удалить список";
            this.ClearSpisok.UseVisualStyleBackColor = false;
            this.ClearSpisok.Click += new System.EventHandler(this.ClearSpisok_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(183, 139);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(151, 228);
            this.listBox2.TabIndex = 61;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(357, 139);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(171, 228);
            this.listBox3.TabIndex = 62;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(554, 142);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(151, 228);
            this.listBox4.TabIndex = 63;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(727, 142);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(159, 228);
            this.listBox5.TabIndex = 64;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 383);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ClearSpisok);
            this.Controls.Add(this.SortTb);
            this.Controls.Add(this.DubliR);
            this.Controls.Add(this.RemoveQb);
            this.Controls.Add(this.VivodList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button VivodList;
        private System.Windows.Forms.Button RemoveQb;
        private System.Windows.Forms.Button DubliR;
        private System.Windows.Forms.Button SortTb;
        private System.Windows.Forms.Button ClearSpisok;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
    }
}

