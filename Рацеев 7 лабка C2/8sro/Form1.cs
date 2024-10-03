using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _8sro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.RowCount = 6;
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 530;
        }
        private void output_Click(object sender, EventArgs e)
        {
            string s = "bana?na hav.e also aass many diDkDыdikы wiwi кор.оче тут дол!жна быть какая word pтаiDтDpiа сл:эш rree";
            List<string> words = Razdel(s);
            string videl = string.Join(" ", words);

            int countQ = svoistvoQ(words);

            lecporyadok(words);
            string sortedWords = string.Join(" ", words);

            string longword = Dlinnoeslovo(words);

            string t = String.Empty;
            t = svoistvoT(longword);

            dataGridView1.Rows[0].Cells[0].Value = "Строка-предложении s".ToString();
            dataGridView1.Rows[0].Cells[1].Value = s.ToString();
            dataGridView1.Rows[1].Cells[0].Value = "Разделенная строка:".ToString();
            dataGridView1.Rows[1].Cells[1].Value = videl.ToString();
            dataGridView1.Rows[2].Cells[0].Value = "Сортированные слова:".ToString();
            dataGridView1.Rows[2].Cells[1].Value = sortedWords.ToString();
            dataGridView1.Rows[3].Cells[0].Value = "Количество слов с свойством Q:".ToString();
            dataGridView1.Rows[3].Cells[1].Value = countQ.ToString();
            dataGridView1.Rows[4].Cells[0].Value = "Слово максимальной длины:".ToString();
            dataGridView1.Rows[4].Cells[1].Value = longword.ToString();
            dataGridView1.Rows[5].Cells[0].Value = "Слово после удаления символов с свойством T:".ToString();
            dataGridView1.Rows[5].Cells[1].Value = t.ToString();
        }
        private List<string> Razdel(string s)
        {
            List<string> words = new List<string>();
            string word = string.Empty;

            foreach (char c in s)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                {
                    word += c;
                }
                else if ((int)c == 32 || (int)c == 9 || (int)c == 46 || (int)c == 58 || (int)c == 59 || (int)c == 63 || (int)c == 33)
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        words.Add(word);
                    }
                    word = string.Empty;
                }
            }

            if (!string.IsNullOrEmpty(word))
            {
                words.Add(word);
            }

            return words;
        }

        private int svoistvoQ(List<string> words)
        {
            int count = 0;
            List<char> proverkaslova = new List<char>();

            foreach (string word in words)
            {
                proverkaslova.Clear();
                bool vsenorm = true;

                foreach (char c in word)
                {
                    if (proverkaslova.Contains(c))
                    {
                        continue;
                    }
                    int chetchik = word.Count(x => x == c);
                    if (chetchik == 1)
                    {
                        vsenorm = false;
                        break;
                    }

                    proverkaslova.Add(c);
                }

                if (vsenorm == true)
                {
                    count++;
                }
            }
            return count;
        }
        private void lecporyadok(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words.Count - i - 1; j++)
                {
                    if (string.Compare(words[j], words[j + 1]) > 0)
                    {
                        string temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                    }
                }
            }
        }

        private string Dlinnoeslovo(List<string> words)
        {
            string longword = "";
            foreach (string word in words)
            {
                if (word.Length > longword.Length)
                {
                    longword = word;
                }
            }
            return longword;
        }

        private string svoistvoT(string longword)
        {
            string t = string.Empty;
            foreach (char c in longword)
            {
                if ((int)c < 65 || (int)c > 90)
                {
                    t += c;
                }
            }
            return t;
        }


    }
}
