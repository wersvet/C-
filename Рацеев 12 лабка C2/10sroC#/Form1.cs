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
using System.Xml.Linq;

namespace _10sroC_
{
    public partial class Form1 : Form
    {
        private LinkedList<int> list = new LinkedList<int>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 1;
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Columns[i].Width = 60;
            }
            dataGridView1.Rows[0].Cells[0].Value = 45.ToString();
            dataGridView1.Rows[0].Cells[1].Value = 23.ToString();
            dataGridView1.Rows[0].Cells[2].Value = 22.ToString();
            dataGridView1.Rows[0].Cells[3].Value = 79.ToString();
            dataGridView1.Rows[0].Cells[4].Value = 14.ToString();
            dataGridView1.Rows[0].Cells[5].Value = 5.ToString();
            dataGridView1.Rows[0].Cells[6].Value = 32.ToString();
            dataGridView1.Rows[0].Cells[7].Value = 7.ToString();
            dataGridView1.Rows[0].Cells[8].Value = 95.ToString();
            dataGridView1.Rows[0].Cells[9].Value = 43.ToString();
        }
        private void VivodList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                list.AddLast(Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value));
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("Исходный список:");
            foreach (int item in list)
            {
                listBox1.Items.Add(item);
            }
        }
        private void RemoveQb_Click(object sender, EventArgs e)
        {
            LinkedListNode<int> current = list.First;
            while (current != null)
            {
                bool containsOne = false;
                for (int i = 0; i < current.Value.ToString().Length; i++)
                {
                    if (current.Value.ToString()[i] == '1')
                    {
                        containsOne = true;
                        break;
                    }
                }
                if (!containsOne)
                {
                    current = current.Next;
                }
                else
                {
                    list.Remove(current);
                    current = current.Next;
                }
            }
            listBox2.Items.Clear();
            listBox2.Items.Add("Список без элементов со свойством Q:");
            foreach (int item2 in list)
            {
                listBox2.Items.Add(item2);
            }
        }

        private void DubliR_Click(object sender, EventArgs e)
        {
            LinkedListNode<int> currentNode = list.First; 

            while (currentNode != null)
            {
                int item = currentNode.Value;
                if (IsComposite(item))
                {
                    LinkedListNode<int> nextNode = currentNode.Next; 
                    list.AddBefore(currentNode, item);
                    currentNode = nextNode;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
            listBox3.Items.Clear();
            listBox3.Items.Add("Список с дублированными элементами со свойством R:");
            foreach (int item3 in list)
            {
                listBox3.Items.Add(item3);
            }
        }
        private bool IsComposite(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void SortTb_Click(object sender, EventArgs e)
        {
            int indec = 0;
            List<int> newindex = new List<int>();
            List<int> newList = new List<int>();
            foreach (int item in list)
            {
                if (!IsComposite(item))
                {
                    newList.Add(item);
                    indec++;
                    newindex.Add(indec);
                }
                else
                {
                    indec++;
                }
            }
            quickSort1(newList, 0, newList.Count - 1);
            LinkedListNode<int> current = list.First;

            int i = 0;
            while (current != null)
            {
                if (newList.Contains(current.Value))
                {
                    current.Value = newList[i];
                    i++;
                }
                current = current.Next;
            }
            listBox4.Items.Clear();
            listBox4.Items.Add("Список с сортированными элементами со свойствами T:");
            foreach (int item4 in list)
            {
                listBox4.Items.Add(item4);
            }
        }
        void quickSort1(List<int> arr4, int left, int right)
        {
            if (left > right) return;
            int p = arr4[(left + right) / 2];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (arr4[i] < p) i++;
                while (arr4[j] > p) j--;
                if (i <= j)
                {
                    int temp = arr4[i];
                    arr4[i] = arr4[j];
                    arr4[j] = temp;
                    i++;
                    j--;
                }
            }
            quickSort1(arr4, left, j);
            quickSort1(arr4, i, right);
        }
        private void ClearSpisok_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            dataGridView1.Rows.Clear();
            listBox5.Items.Add("Пустой список:");
        }
    }
}
