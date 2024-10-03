using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12sro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand1 = new Random();
        public void InitRandom(int[] a, int n, int a1, int a2)
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = rand1.Next(a1, a2);
            }
        }
        public void PrintArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = a[i].ToString();
                dataGridView1.Columns[i].Width = 30;
            }
        }
        public void PrintArray2(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                 dataGridView2.Rows[0].Cells[i].Value = a[i].ToString();
                 dataGridView2.Columns[i].Width = 30;
            }
        }
        public int CountPositive(int[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public int CountPositiveRecur(int[] a, int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (a[n - 1] > 0)
            {
                return 1 + CountPositiveRecur(a, n - 1);
            }
            return CountPositiveRecur(a, n - 1);
        }
        // Итеративная свойство T
        public int IterT(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsOneDoubleDigit(a[i]))
                {
                    sum += a[i];
                }
            }
            return sum;
        }
        // Рекурсия свойствыа T
        public int IterTRecur(int[] a, int n)
        {
             if (n == 0)
             {
                 return 0;
             }
             int sum = IterTRecur(a, n - 1);
             if (IsOneDoubleDigit(a[n - 1]))
             {
                 sum += a[n - 1];
             }
             return sum;
        }
        // Итеративная логическа Q
        public bool IterativeLogikaQ(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] > 0)
                {
                    return true;
                }
            }
            return false;
        }
        // Рекурсивная логика Q
        public bool RecurLogikaQ(int[] a, int n)
        {
            if (n == 0)
            {
                return false;
            }
            if (a[n - 1] > 0)
            {
                return true;
            }
            return RecurLogikaQ(a, n - 1);
        }

        public static bool IsOneDoubleDigit(int n)
        {
            if (Math.Abs(n) <= 9)
            {
                return false;
            }

            int[] digitCounts = new int[10];
            for (int i = 0; i < 10; i++)
            {
                digitCounts[i] = 0;
            }
            while (n > 0)
            {
                digitCounts[n % 10]++;
                n /= 10;
            }
            int digitCount = 0;
            for (int i = 0; i < 10; i++)
            {
                if (digitCounts[i] == 2)
                {
                    digitCount++;
                }
                else if (digitCounts[i] > 2)
                {
                    return false;
                }
            }
            return digitCount == 1;
        }
        // Иетаривка логики T
        public static bool IterativeLogikaT(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (!IsOneDoubleDigit(a[i]))
                {
                    return false;
                }
            }
            return true;
        }
        // Рекурсия логики T
        public static bool RecurLogikaT(int[] a, int n)
        {
            if (n == 0)
            {
                return true;
            }
            if (!IsOneDoubleDigit(a[n - 1]))
            {
                return false;
            }
            return RecurLogikaT(a, n - 1);
        }

        static void insertionSortRecursive(int[] a, int n)
        {
            if (n <= 1)
                return;
            insertionSortRecursive(a, n - 1);
            int last = a[n - 1];
            int j = n - 2;
            while (j >= 0 && a[j] > last)
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = last;
        }

        private void VivodList_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int a1 = Convert.ToInt32(textBox2.Text);
            int a2 = Convert.ToInt32(textBox3.Text);
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = n;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = n;
            int[] a = new int[n];
            InitRandom(a, n, a1, a2);
            PrintArray(a, n);
            int Count1Q = CountPositive(a, n);
            label6.Text = "Итеративная количество элементов массива, обладающих свойством Q " + Count1Q.ToString();
            int SvoistvaT1 = IterT(a, n);
            label7.Text = "Итеративная сумма элементов массива, обладающих свойством T " + SvoistvaT1.ToString();
            bool Qproverka1 = IterativeLogikaQ(a, n);
            if (Qproverka1 == true)
            {
                label8.Text = "итеративная логическая функция, проверяющая, обладает ли хотя бы один элемент массива свойством Q: ДА";
            }
            else if (Qproverka1 == false)
            {
                label8.Text = "итеративная логическая функция, проверяющая, обладает ли хотя бы один элемент массива свойством Q: НЕТ";
            }
            bool Tproverka1 = IterativeLogikaT(a, n);
            if (Tproverka1 == true)
            {
                label9.Text = "итеративная логическая функция, проверяющая, обладает ли хотя бы один элемент массива свойством Т: ДА";
            }
            else if (Tproverka1 == false)
            {
                label9.Text = "итеративная логическая функция, проверяющая, все ли элементы массива a обладают свойством T: НЕТ";
            }
            int Count2Q = CountPositiveRecur(a, n);
            label10.Text = "Рекурсивная количество элементов массива, обладающих свойством Q " + Count2Q.ToString();

            int SvoistvaT2 = IterTRecur(a, n);
            label11.Text = "Рекурсивная сумма элементов массива, обладающих свойством T " + SvoistvaT2.ToString();
           
            bool Qproverka2 = RecurLogikaQ(a, n);
            if (Qproverka2 == true)
            {
                label12.Text = "Рекурсивная логическая функция, проверяющая, обладает ли хотя бы один элемент массива свойством Q: ДА";
            }
            else if (Qproverka2 == false)
            {
                label12.Text = "Рекурсивная логическая функция, проверяющая, обладает ли хотя бы один элемент массива свойством Q: НЕТ";
            }
            bool Tproverka2 = RecurLogikaT(a, n);
            if (Tproverka2 == true)
            {
                label13.Text = "Рекурсивная логическая функция, проверяющая, обладает ли хотя бы один элемент массива свойством Т: ДА";
            }
            else if (Tproverka2 == false)
            {
                label13.Text = "Рекурсивная логическая функция, проверяющая, все ли элементы массива a обладают свойством T: НЕТ";
            }
            insertionSortRecursive(a, n);
            PrintArray2(a, n);
        }
    }
}
