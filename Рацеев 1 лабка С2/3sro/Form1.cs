using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3sro
{
    public partial class Form1 : Form
    {
        public struct User
        {
            public double znakX;
            public double znakY;

            public User(double _znakX, double _znakY)
            {
                znakX = _znakX;
                znakY = _znakY;
            }
        }
        List<User> users = new List<User>();  
        
        private const double A = -5.0;
        private const double B = 5.0;
        private const double H = 0.1;
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox_KeyPress;
            textBox1.TextChanged += textBox_TextChanged;
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '-' && ((TextBox)sender).SelectionStart > 0) // если это знак "-" и он не первый то блокируем
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(",")) // если это запятая "," и ты уже ввел запятую, то больше вводить ее ты не модешь.
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Length == 0) // если ты ввел запятую и она первая, то вместо нее ставим "0,"
            {
                e.Handled = true;
                ((TextBox)sender).Text = "0,";
                ((TextBox)sender).SelectionStart = 2; // после изменение после какого символа пишешь дальше
            }
            else if (((TextBox)sender).Text == "-,")
            {
                e.Handled = true;
                ((TextBox)sender).Text = "-0,";
                ((TextBox)sender).SelectionStart = 3;
            }
            else if (((TextBox)sender).Text == "00")
            {
                e.Handled = true;
                ((TextBox)sender).Text = "0,0";
                ((TextBox)sender).SelectionStart = 3;
            }
            else if (((TextBox)sender).Text == "0")
            {
                e.Handled = true;
                ((TextBox)sender).Text = "0,";
                ((TextBox)sender).SelectionStart = 2;
            }

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                output.Enabled = true;
                clear.Enabled = true;
            }
            else
            {
                output.Enabled = false;
                clear.Enabled = false;
            }
        }
        private double ParseNumber(string input) // потому что мы не заменяем "-" в "0" сразу, а только когда он нажмет вычислить 
        {
            if (input == "-")
            {
                input = "0";
            }
            return double.Parse(input);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double Function(double x)
        {
            return x * Math.Exp(x) + 2 * Math.Sin(x) - Math.Sqrt(Math.Abs(Math.Pow(x, 3) - Math.Pow(x, 2)));
        }

        private void output_Click(object sender, EventArgs e)
        {
            double Z = double.Parse(textBox1.Text);
            Z = Math.Truncate(Z);
            DataTable table = new DataTable();
            table.Columns.Add("Значение x", typeof(double));
            table.Columns.Add("f(x)", typeof(double));

            double maxResult = 0;
            double dlyax = 0;
            int count = 0;
            int ii = 0;
            //int craska = 1;
            for (double x = A; x <= B; x += H)
            {
                double y = Function(x);
                y = Math.Round(y, 4);
                x = Math.Round(x, 4);
                users.Add(new User(x, y));
                table.Rows.Add(users[ii].znakX, users[ii].znakY);
                double okrugY = Math.Truncate(y);
                if (okrugY % Z == 0)
                {
                    if (y > maxResult)
                    {
                        maxResult = y;
                        dlyax = Math.Round(x, 4);
                        count = 1;
                      //  craska = ii;
                    }
                    else if (y == maxResult)
                    {
                        count++;
                    }
                }
                ii++;
            }
           // craska = (int)((dlyax * 10) + 50);
            //dataGridView1.Rows[craska].DefaultCellStyle.BackColor = Color.Yellow;
            if (maxResult == 0)
            {
                label2.Text = "среди значений функции, имеющих целую часть, Нет кратных Z";
                label3.Text = "0";
            }
            table.Rows.Add(dlyax, Math.Floor(maxResult));
            table.Rows.Add(dlyax, count);
            dataGridView1.DataSource = table;
            double faf = -70 + new Random().Next(101);
            label2.Text = "Максимальное среди значений функции, имеющих целую часть, крат-ную Z: " + Math.Truncate(maxResult);
            label3.Text = "количество таких максимальных значений: " + count;
            textBox2.Text = faf.ToString();
        }
    }
}
