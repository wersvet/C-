using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _6sroCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                output.Enabled = true;
            }
            else
            {
                output.Enabled = false;
            }
        }
        private void leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void output_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            char[,] arr = new char[n, m];
            Random rand1 = new Random();
            dataGridView1.RowCount = n + 20;
            dataGridView1.ColumnCount = m + 20;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = (char)rand1.Next(33, 126);
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j].ToString();
                }
            }
            int ror = n;
            int col = 0;
            for (int i = 0; i < n; i++)
            {
                char[] numbers = new char[m];
                int sum = 0;
                int count = 0;
                for (int j = 0; j < m; j++)
                {
                    if (Char.IsDigit((char)arr[i, j]))
                    {
                        numbers[count] = arr[i, j];
                        count++;
                        int intValue = int.Parse(arr[i,j].ToString());
                        sum += intValue;
                    }
                    else if (!Char.IsDigit((char)arr[i, j]))
                    {
                        if (count >= 2)
                        {
                            for (int f = 0; f < count; f++)
                            {
                                ror++;
                                dataGridView1.Rows[ror].Cells[col].Value = numbers[f].ToString();
                            }
                            col++;
                            dataGridView1.Rows[ror + 1].Cells[col + 1].Value = sum.ToString();
                        }
                        for (int ij = 0; ij < numbers.Length; ij++)
                        {
                            numbers[ij] = '\0';
                            count = 0;
                            sum = 0;
                        }
                    }
                }
            }
           
            for (int j = 0; j < m; j++)
            {
                char[] numbers2 = new char[n];
                int sum2 = 0;
                int count2 = 0;
                for (int i = 0; i < n; i++)
                {
                    if (Char.IsDigit((char)arr[i, j]))
                    {
                        numbers2[count2] = arr[i, j];
                        count2++;
                        int intValue = int.Parse(arr[i, j].ToString());
                        sum2 += intValue;
                    }
                    else if (!Char.IsDigit((char)arr[i, j]))
                    {
                        if (count2 >= 2)
                        {
                            for (int f = 0; f < count2; f++)
                            {
                                ror++;
                                dataGridView1.Rows[ror].Cells[col].Value = numbers2[f].ToString();
                            }
                            col++;
                            dataGridView1.Rows[ror + 1].Cells[col + 1].Value = sum2.ToString();
                        }
                        for (int ij = 0; ij < numbers2.Length; ij++)
                        {
                            numbers2[ij] = '\0';
                            count2 = 0;
                            sum2 = 0;
                        }
                    }
                }
            }




          //  dataGridView1.Rows[13].Cells[0].Value = "!".ToString();
          //  dataGridView1.Rows[13].Cells[1].Value = "F".ToString();
          //  dataGridView1.Rows[13].Cells[2].Value = "v".ToString();
          //  dataGridView1.Rows[13].Cells[3].Value = "2".ToString();
          // 
          //  dataGridView1.Rows[14].Cells[0].Value = "s".ToString();
          //  dataGridView1.Rows[14].Cells[1].Value = "f".ToString();
          //  dataGridView1.Rows[14].Cells[2].Value = "0".ToString();
          //  dataGridView1.Rows[14].Cells[3].Value = "[".ToString();
          // 
          //  dataGridView1.Rows[15].Cells[0].Value = "p".ToString();
          //  dataGridView1.Rows[15].Cells[1].Value = "N".ToString();
          //  dataGridView1.Rows[15].Cells[2].Value = "d".ToString();
          //  dataGridView1.Rows[15].Cells[3].Value = "d".ToString();
          // 
          //  dataGridView1.Rows[16].Cells[0].Value = "x".ToString();
          //  dataGridView1.Rows[16].Cells[1].Value = "|".ToString();
          //  dataGridView1.Rows[16].Cells[2].Value = "{".ToString();
          //  dataGridView1.Rows[16].Cells[3].Value = "/".ToString();
          // 
          //  dataGridView1.Rows[17].Cells[0].Value = "*".ToString();
          //  dataGridView1.Rows[17].Cells[1].Value = "L".ToString();
          //  dataGridView1.Rows[17].Cells[2].Value = ",".ToString();
          //  dataGridView1.Rows[17].Cells[3].Value = "[".ToString();
          // 
          //  dataGridView1.Rows[18].Cells[0].Value = "K".ToString();
          //  dataGridView1.Rows[18].Cells[1].Value = "q".ToString();
          //  dataGridView1.Rows[18].Cells[2].Value = "@".ToString();
          //  dataGridView1.Rows[18].Cells[3].Value = "d".ToString();
          // 
          //  dataGridView1.Rows[19].Cells[0].Value = "?".ToString();
          //  dataGridView1.Rows[19].Cells[1].Value = "K".ToString();
          //  dataGridView1.Rows[19].Cells[2].Value = "#".ToString();
          //  dataGridView1.Rows[19].Cells[3].Value = "G".ToString();
          // 
          //  dataGridView1.Rows[20].Cells[0].Value = "f".ToString();
          //  dataGridView1.Rows[20].Cells[1].Value = "&".ToString();
          //  dataGridView1.Rows[20].Cells[2].Value = "h".ToString();
          //  dataGridView1.Rows[20].Cells[3].Value = ")".ToString();
          //
          //  dataGridView1.Rows[21].Cells[0].Value = "7".ToString();
          //  dataGridView1.Rows[21].Cells[1].Value = "5".ToString();
          //  dataGridView1.Rows[21].Cells[2].Value = "12".ToString();
          //
          //  dataGridView1.Rows[22].Cells[0].Value = "2".ToString();
          //  dataGridView1.Rows[22].Cells[1].Value = "6".ToString();
          //  dataGridView1.Rows[22].Cells[2].Value = "8".ToString();
          //
          //  dataGridView1.Rows[23].Cells[0].Value = "1".ToString();
          //  dataGridView1.Rows[23].Cells[1].Value = "5".ToString();
          //  dataGridView1.Rows[23].Cells[2].Value = "6".ToString();
          //
          //  dataGridView1.Rows[24].Cells[0].Value = "6".ToString();
          //  dataGridView1.Rows[24].Cells[1].Value = "8".ToString();
          //  dataGridView1.Rows[24].Cells[2].Value = "14".ToString();
        }
    }
}
