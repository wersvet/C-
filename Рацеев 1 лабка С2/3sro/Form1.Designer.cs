namespace _3sro
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(363, 571);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 77);
            this.textBox1.TabIndex = 1;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.output.Enabled = false;
            this.output.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(421, 301);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(188, 77);
            this.output.TabIndex = 15;
            this.output.Text = "Посчитать";
            this.output.UseVisualStyleBackColor = false;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clear.Enabled = false;
            this.clear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(421, 406);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(188, 77);
            this.clear.TabIndex = 16;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // leave
            // 
            this.leave.BackColor = System.Drawing.Color.Tomato;
            this.leave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leave.Location = new System.Drawing.Point(421, 503);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(188, 77);
            this.leave.TabIndex = 17;
            this.leave.Text = "Выйти";
            this.leave.UseVisualStyleBackColor = false;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_3sro.Properties.Resources._3sro7;
            this.pictureBox2.Location = new System.Drawing.Point(381, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 50);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_3sro.Properties.Resources._3sro5;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 51);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(410, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Введите значение Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Максимальное среди значений функции, имеющих целую часть, крат-ную Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "количество таких максимальных значений";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 586);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 77);
            this.textBox2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(623, 711);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.output);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button output;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

