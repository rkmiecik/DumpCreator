using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace DumpCreator
{
    
    public partial class Form1 : Form
    {
        public static int numquest = 0;
        public static bool trueA = false;
        public static bool trueB = false;
        public static bool trueC = false;
        public static bool trueD = false;
        public static bool trueE = false;
        public static bool trueF = false;
        public static bool trueG = false;
        public static bool trueH = false;
        public static bool trueI = false;
        public static bool habA = true;
        public static bool habB = true;
        public static bool habC = true;
        public static bool habD = true;
        public static bool habE = true;
        public static bool habF = true;
        public static bool habG = true;
        public static bool habH = true;
        public static bool habI = true;
        public static List<string> intro = new List<string>();
        public static List<string> emba = new List<string>();
        public static List<string> tabela = new List<string>();
        public static List<string> pergunta = new List<string>();
        public static List<string> alternA = new List<string>();
        public static List<string> alternB = new List<string>();
        public static List<string> alternC = new List<string>();
        public static List<string> alternD = new List<string>();
        public static List<string> alternE = new List<string>();
        public static List<string> alternF = new List<string>();
        public static List<string> alternG = new List<string>();
        public static List<string> alternH = new List<string>();
        public static List<string> alternI = new List<string>();
        public static List<string> textExplA = new List<string>();
        public static List<string> textExplB = new List<string>();
        public static List<string> textExplC = new List<string>();
        public static List<string> textExplD = new List<string>();
        public static List<string> textExplE = new List<string>();
        public static List<string> textExplF = new List<string>();
        public static List<string> textExplG = new List<string>();
        public static List<string> textExplH = new List<string>();
        public static List<string> textExplI = new List<string>();
        public static List<string> codeA = new List<string>();
        public static List<string> codeB = new List<string>();
        public static List<string> codeC = new List<string>();
        public static List<string> codeD = new List<string>();
        public static List<string> codeE = new List<string>();
        public static List<string> codeF = new List<string>();
        public static List<string> codeG = new List<string>();
        public static List<string> codeH = new List<string>();
        public static List<string> codeI = new List<string>();

        int doubleclick;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Introducao Intro = new Introducao();
            Intro.Show();     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmbaTxt EmbTxt = new EmbaTxt();
            EmbTxt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmbaTab EmbTab = new EmbaTab();
            EmbTab.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pergunta Perg = new Pergunta();
            Perg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AltA AlA = new AltA();
            AlA.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AltB AlB = new AltB();
            AlB.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AltC AlC = new AltC();
            AlC.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AltD AlD = new AltD();
            AlD.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AltE AlE = new AltE();
            AlE.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AltF AlF = new AltF();
            AlF.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AltG AlG = new AltG();
            AlG.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AltH AlH = new AltH();
            AlH.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AltI AlI = new AltI();
            AlI.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ExpA ExA = new ExpA();
            ExA.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ExpB ExB = new ExpB();
            ExB.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ExpC ExC = new ExpC();
            ExC.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ExpD ExD = new ExpD();
            ExD.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ExpE ExE = new ExpE();
            ExE.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ExpF ExF = new ExpF();
            ExF.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ExpG ExG = new ExpG();
            ExG.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ExpH ExH = new ExpH();
            ExH.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ExpI ExI = new ExpI();
            ExI.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(textBox1.Text, out int n);
            if (isNumber)
            {
                numquest = Int32.Parse(textBox1.Text);
                if (checkBox1.Checked == true)
                {
                    trueA = true;
                }
                else
                {
                    trueA = false;
                }
                if (checkBox2.Checked == true)
                {
                    trueB = true;
                }
                else
                {
                    trueB = false;
                }
                if (checkBox3.Checked == true)
                {
                    trueC = true;
                }
                else
                {
                    trueC = false;
                }
                if (checkBox4.Checked == true)
                {
                    trueD = true;
                }
                else
                {
                    trueD = false;
                }
                if (checkBox5.Checked == true)
                {
                    trueE = true;
                }
                else
                {
                    trueE = false;
                }
                if (checkBox6.Checked == true)
                {
                    trueF = true;
                }
                else
                {
                    trueF = false;
                }
                if (checkBox7.Checked == true)
                {
                    trueG = true;
                }
                else
                {
                    trueG = false;
                }
                if (checkBox8.Checked == true)
                {
                    trueH = true;
                }
                else
                {
                    trueH = false;
                }
                if (checkBox9.Checked == true)
                {
                    trueI = true;
                }
                else
                {
                    trueI = false;
                }
                Gerar Gera = new Gerar();
                Gera.Show();
            }
            else
            {
                MessageBox.Show("Digite um número para a questão!");
            }
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            timer1.Start();
            doubleclick++;
            if (doubleclick >= 2)
            {
                numquest = 0;
                trueA = false;
                trueB = false;
                trueC = false;
                trueD = false;
                trueE = false;
                trueF = false;
                trueG = false;
                trueH = false;
                trueI = false;
                habA = true;
                habB = false;
                habC = false;
                habD = false;
                habE = false;
                habF = false;
                habG = false;
                habH = false;
                habI = false;
                intro.Clear();
                emba.Clear();
                tabela.Clear();
                pergunta.Clear();
                alternA.Clear();
                alternB.Clear();
                alternC.Clear();
                alternD.Clear();
                alternE.Clear();
                alternF.Clear();
                alternG.Clear();
                alternH.Clear();
                alternI.Clear();
                textExplA.Clear();
                textExplB.Clear();
                textExplC.Clear();
                textExplD.Clear();
                textExplE.Clear();
                textExplF.Clear();
                textExplG.Clear();
                textExplH.Clear();
                textExplI.Clear();
                codeA.Clear();
                codeB.Clear();
                codeC.Clear();
                codeD.Clear();
                codeE.Clear();
                codeF.Clear();
                codeG.Clear();
                codeH.Clear();
                codeI.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = true;
                HDA();
                HDB();
                HDC();
                HDD();
                HDE();
                HDF();
                HDG();
                HDH();
                HDI();

                label2.Text = "Limpo!";
                timer2.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            doubleclick = 0;
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = "Clique 2 vezes para limpar";
            timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HDA();
            HDB();
            HDC();
            HDD();
            HDE();
            HDF();
            HDG();
            HDH();
            HDI();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            CoddA CoA = new CoddA();
            CoA.Show();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            CoddB CoB = new CoddB();
            CoB.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            CoddC CoC = new CoddC();
            CoC.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            CoddD CoD = new CoddD();
            CoD.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            CoddE CoE = new CoddE();
            CoE.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            CoddF CoF = new CoddF();
            CoF.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            CoddG CoG = new CoddG();
            CoG.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            CoddH CoH = new CoddH();
            CoH.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            CoddI CoI = new CoddI();
            CoI.Show();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            HDA();
        }


        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            HDB();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            HDC();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            HDD();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            HDE();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            HDF();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            HDG();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            HDH();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            HDI();
        }
        private void HDA()
        {
            if (checkBox18.Checked == true)
            {
                checkBox1.Visible = true;
                button5.Visible = true;
                button22.Visible = true;
                button33.Visible = true;
                checkBox17.Visible = true;
                habA = true;
            }
            else
            {
                checkBox1.Visible = false;
                button5.Visible = false;
                button22.Visible = false;
                button33.Visible = false;
                checkBox17.Checked = false;
                checkBox16.Checked = false;
                checkBox15.Checked = false;
                checkBox14.Checked = false;
                checkBox13.Checked = false;
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                checkBox10.Checked = false;
                checkBox17.Visible = false;
                checkBox16.Visible = false;
                checkBox15.Visible = false;
                checkBox14.Visible = false;
                checkBox13.Visible = false;
                checkBox12.Visible = false;
                checkBox11.Visible = false;
                checkBox10.Visible = false;

                habA = false;
            }
        }


        private void HDB()
        {
            if (checkBox17.Checked == true)
            {
                checkBox2.Visible = true;
                button6.Visible = true;
                button21.Visible = true;
                button32.Visible = true;
                checkBox16.Visible = true;
                habB = true;
            }
            else
            {
                checkBox2.Visible = false;
                button6.Visible = false;
                button21.Visible = false;
                button32.Visible = false;
                checkBox16.Checked = false;
                checkBox15.Checked = false;
                checkBox14.Checked = false;
                checkBox13.Checked = false;
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                checkBox10.Checked = false;

                checkBox16.Visible = false;
                checkBox15.Visible = false;
                checkBox14.Visible = false;
                checkBox13.Visible = false;
                checkBox12.Visible = false;
                checkBox11.Visible = false;
                checkBox10.Visible = false;
                habB = false;
            }
        }
        private void HDC()
        {
            if (checkBox16.Checked == true)
            {
                checkBox3.Visible = true;
                button7.Visible = true;
                button20.Visible = true;
                button31.Visible = true;
                checkBox15.Visible = true;
                habC = true;
            }
            else
            {
                checkBox3.Visible = false;
                button7.Visible = false;
                button20.Visible = false;
                button31.Visible = false;
                checkBox15.Checked = false;
                checkBox14.Checked = false;
                checkBox13.Checked = false;
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                checkBox10.Checked = false;

                checkBox15.Visible = false;
                checkBox14.Visible = false;
                checkBox13.Visible = false;
                checkBox12.Visible = false;
                checkBox11.Visible = false;
                checkBox10.Visible = false;
                habC = false;
            }
        }
        private void HDD()
        {
            if (checkBox15.Checked == true)
            {
                checkBox4.Visible = true;
                button8.Visible = true;
                button19.Visible = true;
                button30.Visible = true;
                checkBox14.Visible = true;
                habD = true;
            }
            else
            {
                checkBox4.Visible = false;
                button8.Visible = false;
                button19.Visible = false;
                button30.Visible = false;
                checkBox14.Checked = false;
                checkBox13.Checked = false;
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                checkBox10.Checked = false;

                checkBox14.Visible = false;
                checkBox13.Visible = false;
                checkBox12.Visible = false;
                checkBox11.Visible = false;
                checkBox10.Visible = false;
                habD = false;
            }
        }
        private void HDE()
        {
            if (checkBox14.Checked == true)
            {
                checkBox5.Visible = true;
                button9.Visible = true;
                button18.Visible = true;
                button29.Visible = true;
                checkBox13.Visible = true;
                habE = true;
            }
            else
            {
                checkBox5.Visible = false;
                button9.Visible = false;
                button18.Visible = false;
                button29.Visible = false;
                checkBox13.Checked = false;
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                checkBox10.Checked = false;
                button29.Visible = false;

                checkBox13.Visible = false;
                checkBox12.Visible = false;
                checkBox11.Visible = false;
                checkBox10.Visible = false;
                habE = false;
            }
        }
        private void HDF()
        {
            if (checkBox13.Checked == true)
            {
                checkBox6.Visible = true;
                button10.Visible = true;
                button17.Visible = true;
                button28.Visible = true;
                button29.Visible = true;
                checkBox12.Visible = true;
                habF = true;
            }
            else
            {
                checkBox6.Visible = false;
                button10.Visible = false;
                button17.Visible = false;
                button28.Visible = false;
                checkBox12.Checked = false;
                checkBox11.Checked = false;
                checkBox10.Checked = false;

                checkBox12.Visible = false;
                checkBox11.Visible = false;
                checkBox10.Visible = false;
                habF = false;
            }
        }
        private void HDG()
        {
            if (checkBox12.Checked == true)
            {
                checkBox7.Visible = true;
                button11.Visible = true;
                button16.Visible = true;
                button27.Visible = true;
                checkBox11.Visible = true;
                habG = true;
            }
            else
            {
                checkBox7.Visible = false;
                button11.Visible = false;
                button16.Visible = false;
                button27.Visible = false;
                checkBox11.Checked = false;
                checkBox10.Checked = false;

                checkBox11.Visible = false;
                checkBox10.Visible = false;
                habG = false;
            }
        }
        private void HDH()
        {
            if (checkBox11.Checked == true)
            {
                checkBox8.Visible = true;
                button12.Visible = true;
                button15.Visible = true;
                button26.Visible = true;
                checkBox10.Visible = true;
                habH = true;
            }
            else
            {
                checkBox8.Visible = false;
                button12.Visible = false;
                button15.Visible = false;
                button26.Visible = false;
                checkBox10.Checked = false;

                checkBox10.Visible = false;
                habH = false;
            }
        }
        private void HDI()
        {
            if (checkBox10.Checked == true)
            {
                checkBox9.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button25.Visible = true;
                habI = true;
            }
            else
            {
                checkBox9.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                button25.Visible = false;
                habI = false;
            }

        }


        private void button34_Click(object sender, EventArgs e)
        {
            string diretorio = Application.StartupPath + "\\questions";
            OpenFileDialog dlg = new OpenFileDialog();
            
            dlg.Filter = "txt files (*.txt)|*.txt";
            dlg.InitialDirectory = diretorio;
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                string fileDescription;
                fileName = dlg.FileName;
                fileDescription = (Path.GetFileName(fileName).Replace(".txt",""));

                //escreve no campo do número
                textBox1.Text = fileDescription;

                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(fileName);
                trueA = false;
                trueB = false;
                trueC = false;
                trueD = false;
                trueE = false;
                trueF = false;
                trueG = false;
                trueH = false;
                trueI = false;
                habA = true;
                habB = false;
                habC = false;
                habD = false;
                habE = false;
                habF = false;
                habG = false;
                habH = false;
                habI = false;
                intro.Clear();
                emba.Clear();
                tabela.Clear();
                pergunta.Clear();
                alternA.Clear();
                alternB.Clear();
                alternC.Clear();
                alternD.Clear();
                alternE.Clear();
                alternF.Clear();
                alternG.Clear();
                alternH.Clear();
                alternI.Clear();
                textExplA.Clear();
                textExplB.Clear();
                textExplC.Clear();
                textExplD.Clear();
                textExplE.Clear();
                textExplF.Clear();
                textExplG.Clear();
                textExplH.Clear();
                textExplI.Clear();
                codeA.Clear();
                codeB.Clear();
                codeC.Clear();
                codeD.Clear();
                codeE.Clear();
                codeF.Clear();
                codeG.Clear();
                codeH.Clear();
                codeI.Clear();
                int ilinecounter = 0;
                string condition;
                foreach (string line in lines)
                {

                    if (line.StartsWith("intro: "))
                    {
                        intro.Add(lines[ilinecounter].Replace("intro: ", ""));
                    }

                    else if (line.StartsWith("emba: "))
                    {
                        
                        emba.Add(lines[ilinecounter].Replace("emba: ", ""));
                    }

                    else if (line.StartsWith("tabela: "))
                    {
                        tabela.Add((lines[ilinecounter]).Replace("tabela: ", ""));
                    }

                    else if (line.StartsWith("pergunta: "))
                    {
                        pergunta.Add((lines[ilinecounter]).Replace("pergunta: ", ""));
                    }

                    else if (line.StartsWith("habA: "))
                    {
                        condition = (line.Replace("habA: ", ""));
                        if (condition == "True")
                        {
                            checkBox18.Checked = true;
                        }
                        else
                        {
                            checkBox18.Checked = false;
                        }
                        HDA();
                    }

                    else if (line.StartsWith("trueA: "))
                    {
                        condition = (line.Replace("trueA: ", ""));
                        if (condition == "True")
                        {
                            checkBox1.Checked = true;
                        }
                        else
                        {
                            checkBox1.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternA: "))
                    {
                        alternA.Add((lines[ilinecounter]).Replace("alternA: ", ""));
                    }

                    else if (line.StartsWith("textExplA: "))
                    {
                        textExplA.Add((lines[ilinecounter]).Replace("textExplA: ", ""));
                    }

                    else if (line.StartsWith("codeA: "))
                    {
                        codeA.Add((lines[ilinecounter]).Replace("codeA: ", ""));
                    }




                    else if (line.StartsWith("habB: "))
                    {
                        condition = (line.Replace("habB: ", ""));
                        if (condition == "True")
                        {
                            checkBox17.Checked = true;
                        }
                        else
                        {
                            checkBox17.Checked = false;
                        }
                        HDB();
                    }

                    else if (line.StartsWith("trueB: "))
                    {
                        condition = (line.Replace("trueB: ", ""));
                        if (condition == "True")
                        {
                            checkBox2.Checked = true;
                        }
                        else
                        {
                            checkBox2.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternB: "))
                    {
                        alternB.Add((lines[ilinecounter]).Replace("alternB: ", ""));
                    }

                    else if (line.StartsWith("textExplB: "))
                    {
                        textExplB.Add((lines[ilinecounter]).Replace("textExplB: ", ""));
                    }

                    else if (line.StartsWith("codeB: "))
                    {
                        codeB.Add((lines[ilinecounter]).Replace("codeB: ", ""));
                    }




                    else if (line.StartsWith("habC: "))
                    {
                        condition = (line.Replace("habC: ", ""));
                        if (condition == "True")
                        {
                            checkBox16.Checked = true;
                        }
                        else
                        {
                            checkBox16.Checked = false;
                        }
                        HDC();
                    }

                    else if (line.StartsWith("trueC: "))
                    {
                        condition = (line.Replace("trueC: ", ""));
                        if (condition == "True")
                        {
                            checkBox3.Checked = true;
                        }
                        else
                        {
                            checkBox3.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternC: "))
                    {
                        alternC.Add((lines[ilinecounter]).Replace("alternC: ", ""));
                    }

                    else if (line.StartsWith("textExplC: "))
                    {
                        textExplC.Add((lines[ilinecounter]).Replace("textExplC: ", ""));
                    }

                    else if (line.StartsWith("codeC: "))
                    {
                        codeC.Add((lines[ilinecounter]).Replace("codeC: ", ""));
                    }




                    else if (line.StartsWith("habD: "))
                    {
                        condition = (line.Replace("habD: ", ""));
                        if (condition == "True")
                        {
                            checkBox15.Checked = true;
                        }
                        else
                        {
                            checkBox15.Checked = false;
                        }
                        HDD();
                    }

                    else if (line.StartsWith("trueD: "))
                    {
                        condition = (line.Replace("trueD: ", ""));
                        if (condition == "True")
                        {
                            checkBox4.Checked = true;
                        }
                        else
                        {
                            checkBox4.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternD: "))
                    {
                        alternD.Add((lines[ilinecounter]).Replace("alternD: ", ""));
                    }

                    else if (line.StartsWith("textExplD: "))
                    {
                        textExplD.Add((lines[ilinecounter]).Replace("textExplD: ", ""));
                    }

                    else if (line.StartsWith("codeD: "))
                    {
                        codeD.Add((lines[ilinecounter]).Replace("codeD: ", ""));
                    }





                    else if (line.StartsWith("habE: "))
                    {
                        condition = (line.Replace("habE: ", ""));
                        if (condition == "True")
                        {
                            checkBox14.Checked = true;
                        }
                        else
                        {
                            checkBox14.Checked = false;
                        }
                        HDE();
                    }

                    else if (line.StartsWith("trueE: "))
                    {
                        condition = (line.Replace("trueE: ", ""));
                        if (condition == "True")
                        {
                            checkBox5.Checked = true;
                        }
                        else
                        {
                            checkBox5.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternE: "))
                    {
                        alternE.Add((lines[ilinecounter]).Replace("alternE: ", ""));
                    }

                    else if (line.StartsWith("textExplE: "))
                    {
                        textExplE.Add((lines[ilinecounter]).Replace("textExplE: ", ""));
                    }

                    else if (line.StartsWith("codeE: "))
                    {
                        codeE.Add((lines[ilinecounter]).Replace("codeE: ", ""));
                    }




                    else if (line.StartsWith("habF: "))
                    {
                        condition = (line.Replace("habF: ", ""));
                        if (condition == "True")
                        {
                            checkBox13.Checked = true;
                        }
                        else
                        {
                            checkBox13.Checked = false;
                        }
                        HDF();
                    }

                    else if (line.StartsWith("trueF: "))
                    {
                        condition = (line.Replace("trueF: ", ""));
                        if (condition == "True")
                        {
                            checkBox6.Checked = true;
                        }
                        else
                        {
                            checkBox6.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternF: "))
                    {
                        alternF.Add((lines[ilinecounter]).Replace("alternF: ", ""));
                    }

                    else if (line.StartsWith("textExplF: "))
                    {
                        textExplF.Add((lines[ilinecounter]).Replace("textExplF: ", ""));
                    }

                    else if (line.StartsWith("codeF: "))
                    {
                        codeF.Add((lines[ilinecounter]).Replace("codeF: ", ""));
                    }




                    else if (line.StartsWith("habG: "))
                    {
                        condition = (line.Replace("habG: ", ""));
                        if (condition == "True")
                        {
                            checkBox12.Checked = true;
                        }
                        else
                        {
                            checkBox12.Checked = false;
                        }
                        HDF();
                    }

                    else if (line.StartsWith("trueG: "))
                    {
                        condition = (line.Replace("trueG: ", ""));
                        if (condition == "True")
                        {
                            checkBox7.Checked = true;
                        }
                        else
                        {
                            checkBox7.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternG: "))
                    {
                        alternG.Add((lines[ilinecounter]).Replace("alternG: ", ""));
                    }

                    else if (line.StartsWith("textExplG: "))
                    {
                        textExplG.Add((lines[ilinecounter]).Replace("textExplG: ", ""));
                    }

                    else if (line.StartsWith("codeG: "))
                    {
                        codeG.Add((lines[ilinecounter]).Replace("codeG: ", ""));
                    }




                    else if (line.StartsWith("habH: "))
                    {
                        condition = (line.Replace("habH: ", ""));
                        if (condition == "True")
                        {
                            checkBox11.Checked = true;
                        }
                        else
                        {
                            checkBox11.Checked = false;
                        }
                        HDF();
                    }

                    else if (line.StartsWith("trueH: "))
                    {
                        condition = (line.Replace("trueH: ", ""));
                        if (condition == "True")
                        {
                            checkBox8.Checked = true;
                        }
                        else
                        {
                            checkBox8.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternH: "))
                    {
                        alternH.Add((lines[ilinecounter]).Replace("alternH: ", ""));
                    }

                    else if (line.StartsWith("textExplH: "))
                    {
                        textExplH.Add((lines[ilinecounter]).Replace("textExplH: ", ""));
                    }

                    else if (line.StartsWith("codeH: "))
                    {
                        codeH.Add((lines[ilinecounter]).Replace("codeH: ", ""));
                    }


                    else if (line.StartsWith("habI: "))
                    {
                        condition = (line.Replace("habI: ", ""));
                        if (condition == "True")
                        {
                            checkBox10.Checked = true;
                        }
                        else
                        {
                            checkBox10.Checked = false;
                        }
                        HDF();
                    }

                    else if (line.StartsWith("trueI: "))
                    {
                        condition = (line.Replace("trueI: ", ""));
                        if (condition == "True")
                        {
                            checkBox9.Checked = true;
                        }
                        else
                        {
                            checkBox9.Checked = false;
                        }
                    }

                    else if (line.StartsWith("alternI: "))
                    {
                        alternI.Add((lines[ilinecounter]).Replace("alternI: ", ""));
                    }

                    else if (line.StartsWith("textExplI: "))
                    {
                        textExplI.Add((lines[ilinecounter]).Replace("textExplI: ", ""));
                    }

                    else if (line.StartsWith("codeI: "))
                    {
                        codeI.Add((lines[ilinecounter]).Replace("codeI: ", ""));

                    }
                    ilinecounter++;
                }
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\base.html";
            if (File.Exists(path))
            {
                Process.Start(new ProcessStartInfo(path));
            }
        }
    }
}
