using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DumpCreator
{
    public partial class CoddB : Form
    {
        public CoddB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.codeB.Clear();
            var lines = richTextBox1.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                Form1.codeB.Add(lines[i]);
            }


            Close();
        }

        private void CoddB_Load(object sender, EventArgs e)
        {
            this.ActiveControl = richTextBox1;
            int numlines = 0;
            int counter = 0;
            foreach (string str in Form1.codeB)
            {
                numlines++;
            }
            foreach (string str in Form1.codeB)
            {
                counter++;
                if (counter < numlines)
                {
                    richTextBox1.AppendText(str + Environment.NewLine);
                }
                else
                {
                    richTextBox1.AppendText(str);
                }
            }

        }
    }
}
