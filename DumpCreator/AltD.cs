﻿using System;
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
    public partial class AltD : Form
    {
        public AltD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.alternD.Clear();
            var lines = richTextBox1.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                Form1.alternD.Add(lines[i]);
            }


            Close();
        }

        private void AltD_Load(object sender, EventArgs e)
        {
            this.ActiveControl = richTextBox1;
            int numlines = 0;
            int counter = 0;
            foreach (string str in Form1.alternD)
            {
                numlines++;
            }
            foreach (string str in Form1.alternD)
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
