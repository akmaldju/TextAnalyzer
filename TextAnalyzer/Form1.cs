using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public partial class Form1 : Form
    {
        String[] separator = { " ", ", ", ". ", ".", ",", "  ", "   ", "?", "!", "— ", "—" };
        String[] exceptions = { "and" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstWords.Items.Clear();
            lstNames.Items.Clear();
            String text = txtContent.Text;
            String[] wordsList = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (String word in wordsList)
            {
                try
                {
                    wordsCount.Add(word, 1);
                }
                catch (ArgumentException)
                {
                    wordsCount[word] = wordsCount[word]+1;
                }
            }

            var wordList = wordsCount.ToList();
            wordList.Sort((x, y) => y.Value.CompareTo(x.Value));

            foreach (KeyValuePair<string, int> kvp in wordList)
            {
                if (exceptions.Any(kvp.Key.Contains))
                {

                }
                else
                {
                    if (Char.IsUpper(kvp.Key, 0))
                    {
                        lstNames.Items.Add(kvp.Key + " - " + kvp.Value);
                    }
                    else
                    {
                        lstWords.Items.Add(kvp.Key + " - " + kvp.Value);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dlgOpenFile.ShowDialog();
            if(dlgOpenFile.FileName != "")
            {
                var OpenFile = new System.IO.StreamReader(dlgOpenFile.FileName);
                txtContent.Text = OpenFile.ReadToEnd();
                OpenFile.Close();
            }
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSeparators_Click(object sender, EventArgs e)
        {
            dlgOpenFile.ShowDialog();
            if (dlgOpenFile.FileName != "")
            {
                var OpenFile = new System.IO.StreamReader(dlgOpenFile.FileName);
                String[] sep = { "\r\n" };
                separator = OpenFile.ReadToEnd().Split(sep, StringSplitOptions.RemoveEmptyEntries); ;
                OpenFile.Close();
            }
        }

        private void btnExceptions_Click(object sender, EventArgs e)
        {
            dlgOpenFile.ShowDialog();
            if (dlgOpenFile.FileName != "")
            {
                var OpenFile = new System.IO.StreamReader(dlgOpenFile.FileName);
                String[] sep = { "\r\n" };
                exceptions = OpenFile.ReadToEnd().Split(sep, StringSplitOptions.RemoveEmptyEntries); ;
                OpenFile.Close();
            }
        }
    }
}
