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

namespace _5sroCsharp
{
    public partial class Form1 : Form
    {
        public struct User
        {
            public int znakX;
            public int znakY;

            public User(int _znakX, int _znakY)
            {
                znakX = _znakX;
                znakY = _znakY;
            }
        }
        List<User> users = new List<User>();

        public struct User2
        {
            public int znakX2;
            public int znakY2;

            public User2(int _znakX2, int _znakY2)
            {
                znakX2 = _znakX2;
                znakY2 = _znakY2;
            }
        }
        List<User2> users2 = new List<User2>();

        public struct User3
        {
            public int znakX3;
            public int znakY3;

            public User3(int _znakX3, int _znakY3)
            {
                znakX3 = _znakX3;
                znakY3 = _znakY3;
            }
        }
        List<User3> users3 = new List<User3>();


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
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                output.Enabled = true;
            }
            else
            {
                output.Enabled = false;
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


        private static int[] RemoveNumbersWithTwoSameDigits(int[] arr)
        {
            int[] filteredArr = new int[arr.Length];

            int filteredArrIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool hasTwoSameDigits = false;
                var digits = arr[i].ToString().ToCharArray();
                for (int j = 0; j < digits.Length; j++)
                {
                    for (int k = j + 1; k < digits.Length; k++)
                    {
                        if (digits[j] == digits[k])
                        {
                            hasTwoSameDigits = true;
                            break;
                        }
                    }
                }

                if (!hasTwoSameDigits)
                {
                    filteredArr[filteredArrIndex++] = arr[i];
                }
            }

            // Возвращаем новый массив.
            return filteredArr;
        }

        private object random;
       // private const int A = -50;
       // private const int B = 30;
       // int n = B - A;
        int dlyax = 0;
        int dlyay = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyPress += textBox_KeyPress;
            textBox2.KeyPress += textBox_KeyPress;
            textBox1.TextChanged += textBox_TextChanged;
            textBox2.TextChanged += textBox_TextChanged;
        }

        private void output_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);
            int n = B - A;
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            table.Columns.Add("Номер", typeof(int));
            table.Columns.Add("Числа", typeof(int));
            table2.Columns.Add("Номер", typeof(int));
            table2.Columns.Add("Числа", typeof(int));
            table3.Columns.Add("Номер", typeof(int));
            table3.Columns.Add("Числа", typeof(int));
            int[] arr = new int[n];
            int[] positiveIndexes = new int[n];
            int[] znachpos = new int[n];
            Random rand1 = new Random();
            for (int ii = 0; ii < n; ii++)
            {
                dlyax = ii;
                arr[ii] = rand1.Next(A, B);
                //array[ii] = new Random().Next(-30, 30);
                dlyay = arr[ii];
                users.Add(new User(ii, arr[ii]));
                table.Rows.Add(users[ii].znakX, users[ii].znakY);
            }
            dataGridView1.DataSource = table;

            // 2 Массив
            int jager = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    positiveIndexes[jager] = arr[i];
                    znachpos[jager] = i;
                    jager++;
                }
            }
            Array.Sort(positiveIndexes);
            int count = 0;
            for (int i = 0; i < positiveIndexes.Length; i++)
            {
                if (positiveIndexes[i] != 0)
                {
                    positiveIndexes[count++] = positiveIndexes[i];
                }
            }
            for (int sosik = 0; sosik < jager; sosik++)
            {
                arr[znachpos[sosik]] = positiveIndexes[sosik];
            }
            for (int j = 0; j < n; j++)
            {
                dlyax = j;
                dlyay = arr[j];
                users2.Add(new User2(j, arr[j]));
                table2.Rows.Add(users2[j].znakX2, users2[j].znakY2);
            }
            dataGridView2.DataSource = table2;

            // 3 массив
            arr = RemoveNumbersWithTwoSameDigits(arr);
            for (int k = 0; k < arr.Length; k++)
            {
                dlyax = k;
                dlyay = arr[k];
                users3.Add(new User3(k, arr[k]));
                table3.Rows.Add(users3[k].znakX3, users3[k].znakY3);
            }
            dataGridView3.DataSource = table3;
        }

        private void leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}