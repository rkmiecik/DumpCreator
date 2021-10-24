using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace DumpCreator
{
    public partial class Gerar : Form
    {
        string diretorio = Application.StartupPath + "/questions";
        public Gerar()
        {
            InitializeComponent();
        }

        private void Gerar_Load(object sender, EventArgs e)
        {
            string altcorretaA;
            string altcorretaB;
            string altcorretaC;
            string altcorretaD;
            string altcorretaE;
            string altcorretaF;
            string altcorretaG;
            string altcorretaH;
            string altcorretaI;

            

            if (Form1.trueA == true)
            {
                altcorretaA = "correct";
            }
            else
            {
                altcorretaA = "incorrect";
            }

            if (Form1.trueB == true)
            {
                altcorretaB = "correct";
            }
            else
            {
                altcorretaB = "incorrect";
            }

            if (Form1.trueC == true)
            {
                altcorretaC = "correct";
            }
            else
            {
                altcorretaC = "incorrect";
            }

            if (Form1.trueD == true)
            {
                altcorretaD = "correct";
            }
            else
            {
                altcorretaD = "incorrect";
            }

            if (Form1.trueE == true)
            {
                altcorretaE = "correct";
            }
            else
            {
                altcorretaE = "incorrect";
            }

            if (Form1.trueF == true)
            {
                altcorretaF = "correct";
            }
            else
            {
                altcorretaF = "incorrect";
            }

            if (Form1.trueG == true)
            {
                altcorretaG = "correct";
            }
            else
            {
                altcorretaG = "incorrect";
            }

            if (Form1.trueH == true)
            {
                altcorretaH = "correct";
            }
            else
            {
                altcorretaH = "incorrect";
            }

            if (Form1.trueI == true)
            {
                altcorretaI = "correct";
            }
            else
            {
                altcorretaI = "incorrect";
            }

            string line1 = "<!------------------------------------------------------------------->";
            string line2 = "";
            string line3 = "<div class= \"question\" id= \"" + 1000 + Form1.numquest + "\"> ";
            string line4 = "<div class=\"qnumber\"> Question " + Form1.numquest + "</div>";
            string line5 = "<p><input class= \"hide-checkbox\" id= \"qcb" + Form1.numquest + "\"/>";
            string line6 = "<label for= \"checkbox\"></label></p>";
            string line7a = "<p>";
            string line7b = "</p>";
            string line8a = "<p>";
            string line8b = "</p>";
            string line9a = "<div class= \"table\">";
            string line9b = "</div>";
            string line10a = "<p>";
            string line10b = "</p>";
            string line11 = "<!---*************************************************************--->";
            string line12 = "<table width= \"100%\" border= \"0\" class= \"code\" id= \"" + Form1.numquest + "\"> ";
            string line13 = "  <tr>";
            string line14 = "    <td width= \"3%\"></td>";
            string line15 = "    <td width= \"97%\" bgcolor= \"#FFFFFF\"></td>";
            string line16 = "  </tr>";
            string line17 = "  <tr>";
            string line18 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "a\" id= \"cb" + Form1.numquest + "a\" onmousedown= \"strike_r(event, this);\"></td>";
            string line19a = "    <td class= \"" + altcorretaA + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "a\" onmousedown= \"strike_r(event, this);\">";
            string line19b = "</label></td>";
            string line20 = "  </tr>";
            string line21 = "  <tr>";
            string line22 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "b\" id= \"cb" + Form1.numquest + "b\" onmousedown= \"strike_r(event, this);\"></td>";
            string line23a = "    <td class= \"" + altcorretaB + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "b\" onmousedown= \"strike_r(event, this);\">";
            string line23b = "</label></td>";
            string line24 = "  </tr>";
            string line25 = "  <tr>";
            string line26 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "c\" id= \"cb" + Form1.numquest + "c\" onmousedown= \"strike_r(event, this);\"></td>";
            string line27a = "    <td class= \"" + altcorretaC + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "c\" onmousedown= \"strike_r(event, this);\">";
            string line27b = "</label></td>";
            string line28 = "  </tr>";
            string line29 = "  <tr>";
            string line30 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "d\" id= \"cb" + Form1.numquest + "d\" onmousedown= \"strike_r(event, this);\"></td>";
            string line31a = "    <td class= \"" + altcorretaD + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "d\" onmousedown= \"strike_r(event, this);\">";
            string line31b = "</label></td>";
            string line32 = "  </tr>";
            string line33 = "  <tr>";
            string line34 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "e\" id= \"cb" + Form1.numquest + "e\" onmousedown= \"strike_r(event, this);\"></td>";
            string line35a = "    <td class= \"" + altcorretaE + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "e\" onmousedown= \"strike_r(event, this);\">";
            string line35b = "</label></td>";
            string line36 = "  </tr>";
            string line37 = "  <tr>";
            string line38 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "f\" id= \"cb" + Form1.numquest + "f\" onmousedown= \"strike_r(event, this);\"></td>";
            string line39a = "    <td class= \"" + altcorretaF + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "f\" onmousedown= \"strike_r(event, this);\">";
            string line39b = "</label></td>";
            string line40 = "  </tr>";
            string line41 = "  <tr>";
            string line42 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "g\" id= \"cb" + Form1.numquest + "g\" onmousedown= \"strike_r(event, this);\"></td>";
            string line43a = "    <td class= \"" + altcorretaG + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "g\" onmousedown= \"strike_r(event, this);\">";
            string line43b = "</label></td>";
            string line44 = "  </tr>";
            string line45 = "  <tr>";
            string line46 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "h\" id= \"cb" + Form1.numquest + "h\" onmousedown= \"strike_r(event, this);\"></td>";
            string line47a = "    <td class= \"" + altcorretaH + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "h\" onmousedown= \"strike_r(event, this);\">";
            string line47b = "</label></td>";
            string line48 = "  </tr>";
            string line49 = "  <tr>";
            string line50 = "    <td><input type= \"checkbox\" name= \"cb" + Form1.numquest + "i\" id= \"cb" + Form1.numquest + "i\" onmousedown= \"strike_r(event, this);\"></td>";
            string line51a = "    <td class= \"" + altcorretaI + Form1.numquest + "\"  style= \"background: linear-gradient(#E6E6E6, #FFFFFF); padding-left:5px;\"><label for= \"cb" + Form1.numquest + "i\" onmousedown= \"strike_r(event, this);\">";
            string line51b = "</label></td>";
            string line52 = "  </tr>";
            string line53 = "</table>";
            string line54 = "<div class= \"button\">";
            string line55 = "<button class= \"correct" + Form1.numquest + "\" onClick= \"reply_click(this.className)\"> SHOW CORRECT ANSWER</button><br/><br/>";
            string line56 = "  <input name= \"\" value= \"SHOW EXPLANATION\" type= \"button\" class= \"reveal more\"> ";
            string line57 = "</div>";
            string line58 = "<!---=============================================================--->";
            string line59 = "<div class= \"slider\" style= \"display: none;\"> ";
            string line60 = "<div class= \"explanation\"> EXPLANATION:</div>";
            string line61 = "";
            string line62 = "<div class= \"endalternative\"> &nbsp;</div>";
            string line63 = "";
            string line64a = "<p class= \"" + altcorretaA + "\">" + altcorretaA.ToUpper() + ": <br/>";
            string line64b = "</p>";
            string line65a = "<p>";
            string line65b = "</p>";
            string line66 = "";
            string line67 = "<p>Code example:</p>";
            string line68 = "<div class= \"hrschema\">";
            string line69a = "<span class= \"code\">";
            string line69b = "</span></div>";
            string line70 = "";
            string line71 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line72 = "";
            string line73a = "<p class= \"" + altcorretaB + "\">" + altcorretaB.ToUpper() + ": <br/>";
            string line73b = "</p>";
            string line74a = "<p>";
            string line74b = "</p>";
            string line75 = "";
            string line76 = "<p>Code example:</p>";
            string line77 = "<div class= \"hrschema\">";
            string line78a = "<span class= \"code\">";
            string line78b = "</span></div>";
            string line79 = "";
            string line80 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line81 = "";
            string line82a = "<p class= \"" + altcorretaC + "\">" + altcorretaC.ToUpper() + ": <br/>";
            string line82b =  "</p>";
            string line83a = "<p>";
            string line83b = "</p>";
            string line84 = "";
            string line85 = "<p>Code example:</p>";
            string line86 = "<div class= \"hrschema\">";
            string line87a = "<span class= \"code\">";
            string line87b = "</span></div>";
            string line88 = "";
            string line89 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line90 = "";
            string line91a = "<p class= \"" + altcorretaD + "\">" + altcorretaD.ToUpper() + ": <br/>";
            string line91b = "</p>";
            string line92a = "<p>";
            string line92b = "</p>";
            string line93 = "";
            string line94 = "<p>Code example:</p>";
            string line95 = "<div class= \"hrschema\">";
            string line96a = "<span class= \"code\">";
            string line96b = "</span></div>";
            string line97 = "";
            string line98 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line99 = "";
            string line100a = "<p class= \"" + altcorretaE + "\">" + altcorretaE.ToUpper() + ": <br/>";
            string line100b = "</p>";
            string line101a = "<p>";
            string line101b = "</p>";
            string line102 = "";
            string line103 = "<p>Code example:</p>";
            string line104 = "<div class= \"hrschema\">";
            string line105a = "<span class= \"code\">";
            string line105b = "</span></div>";
            string line106 = "";
            string line107 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line108 = "";
            string line109a = "<p class= \"" + altcorretaF + "\">" + altcorretaF.ToUpper() + ": <br/>";
            string line109b = "</p>";
            string line110a = "<p>" ;
            string line110b = "</p>";
            string line111 = "";
            string line112 = "<p>Code example:</p>";
            string line113 = "<div class= \"hrschema\">";
            string line114a = "<span class= \"code\">";
            string line114b = "</span></div>";
            string line115 = "";
            string line116 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line117 = "";
            string line118a = "<p class= \"" + altcorretaG + "\">" + altcorretaG.ToUpper() + ": <br/>";
            string line118b = "</p>";
            string line119a = "<p>";
            string line119b = "</p>";
            string line120 = "";
            string line121 = "<p>Code example:</p>";
            string line122 = "<div class= \"hrschema\">";
            string line123a = "<span class= \"code\">";
            string line123b = "</span></div>";
            string line124 = "";
            string line125 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line126 = "";
            string line127a = "<p class= \"" + altcorretaH + "\">" + altcorretaH.ToUpper() + ": <br/>";
            string line127b = "</p>";
            string line128a = "<p>" ;
            string line128b = "</p>";
            string line129 = "";
            string line130 = "<p>Code example:</p>";
            string line131 = "<div class= \"hrschema\">";
            string line132a = "<span class= \"code\">";
            string line132b = "</span></div>";
            string line133 = "";
            string line134 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line135 = "";
            string line136a = "<p class= \"" + altcorretaI + "\">" + altcorretaI.ToUpper() + ": <br/>";
            string line136b = "</p>";
            string line137a = "<p>";
            string line137b = "</p>";
            string line138 = "";
            string line139 = "<p>Code example:</p>";
            string line140 = "<div class= \"hrschema\">";
            string line141a = "<span class= \"code\">";
            string line141b = "</span></div>";
            string line142 = "";
            string line143 = "<div class= \"endalternative\"> &nbsp;</div> <br/>";
            string line144 = "";
            string line145 = "</div>";
            string line146 = "<div class= \"button\">";
            string line147 = "<p><button onclick= \"randomQuestion()\">NEXT QUESTION</button></p>";
            string line148 = "</div>";
            string line149 = "<div class= \"qstnnum\">";
            string line150 = "</div>";
            string line151 = "</div>";
            string line152 = "";
            string line153 = "<!------------------------------------------------------------------->";

            richTextBox1.AppendText(line1 + Environment.NewLine);
            richTextBox1.AppendText(line2 + Environment.NewLine);
            richTextBox1.AppendText(line3 + Environment.NewLine);
            richTextBox1.AppendText(line4 + Environment.NewLine);
            richTextBox1.AppendText(line5 + Environment.NewLine);
            richTextBox1.AppendText(line6 + Environment.NewLine);
            richTextBox1.AppendText(line7a + Environment.NewLine);
            foreach (string str in Form1.intro)
            {
                richTextBox1.AppendText(str+"<br/>" + Environment.NewLine);
            }
            richTextBox1.AppendText(line7b + Environment.NewLine);
            richTextBox1.AppendText(line8a + Environment.NewLine);
            foreach (string str in Form1.emba)
            {
                richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
            }
            richTextBox1.AppendText(line8b + Environment.NewLine);
            richTextBox1.AppendText(line9a + Environment.NewLine);
            foreach (string str in Form1.tabela)
            {
                richTextBox1.AppendText(str + Environment.NewLine);
            }
            richTextBox1.AppendText(line9b + Environment.NewLine);
            richTextBox1.AppendText(line10a + Environment.NewLine);
            foreach (string str in Form1.pergunta)
            {
                richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
            }
            richTextBox1.AppendText(line10b + Environment.NewLine);
            richTextBox1.AppendText(line11 + "<br/>" + Environment.NewLine);
            richTextBox1.AppendText(line12  + Environment.NewLine);
            richTextBox1.AppendText(line13  + Environment.NewLine);
            richTextBox1.AppendText(line14  + Environment.NewLine);
            richTextBox1.AppendText(line15  + Environment.NewLine);
            richTextBox1.AppendText(line16  + Environment.NewLine);
            if (Form1.habA == true)
            {
                richTextBox1.AppendText(line17  + Environment.NewLine);
                richTextBox1.AppendText(line18  + Environment.NewLine);
                richTextBox1.AppendText(line19a + Environment.NewLine);
                foreach (string str in Form1.alternA)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line19b + Environment.NewLine);
                richTextBox1.AppendText(line20 + Environment.NewLine);
            }
            if (Form1.habB == true)
            {
                richTextBox1.AppendText(line21  + Environment.NewLine);
                richTextBox1.AppendText(line22  + Environment.NewLine);
                richTextBox1.AppendText(line23a + Environment.NewLine);
                foreach (string str in Form1.alternB)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line23b + Environment.NewLine);
                richTextBox1.AppendText(line24 + Environment.NewLine);
                }
            if (Form1.habC == true)
            {
                richTextBox1.AppendText(line25 + Environment.NewLine);
                richTextBox1.AppendText(line26 + Environment.NewLine);
                richTextBox1.AppendText(line27a + Environment.NewLine);
                foreach (string str in Form1.alternC)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line27b + Environment.NewLine);
                richTextBox1.AppendText(line28 + Environment.NewLine);
            }
            if (Form1.habD == true)
            {
                richTextBox1.AppendText(line29 + Environment.NewLine);
                richTextBox1.AppendText(line30 + Environment.NewLine);
                richTextBox1.AppendText(line31a + Environment.NewLine);
                foreach (string str in Form1.alternD)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line31b + Environment.NewLine);
                richTextBox1.AppendText(line32 + Environment.NewLine);
            }
            if (Form1.habE == true)
            {
                richTextBox1.AppendText(line33 + Environment.NewLine);
                richTextBox1.AppendText(line34 + Environment.NewLine);
                richTextBox1.AppendText(line35a + Environment.NewLine);
                foreach (string str in Form1.alternE)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line35b + Environment.NewLine);
                richTextBox1.AppendText(line36 + Environment.NewLine);
            }
            if (Form1.habF == true)
            {
                richTextBox1.AppendText(line37  + Environment.NewLine);
                richTextBox1.AppendText(line38 + Environment.NewLine);
                richTextBox1.AppendText(line39a + Environment.NewLine);
                foreach (string str in Form1.alternF)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line39b + Environment.NewLine);
                richTextBox1.AppendText(line40 + Environment.NewLine);
            }
            if (Form1.habG == true)
            {
                richTextBox1.AppendText(line41 + Environment.NewLine);
                richTextBox1.AppendText(line42 + Environment.NewLine);
                richTextBox1.AppendText(line43a + Environment.NewLine);
                foreach (string str in Form1.alternG)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line43b + Environment.NewLine);
                richTextBox1.AppendText(line44 + Environment.NewLine);
            }
            if (Form1.habH == true)
            {
                richTextBox1.AppendText(line45  + Environment.NewLine);
                richTextBox1.AppendText(line46  + Environment.NewLine);
                richTextBox1.AppendText(line47a + Environment.NewLine);
                foreach (string str in Form1.alternH)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line47b + Environment.NewLine);
                richTextBox1.AppendText(line48 + Environment.NewLine);
            }
            if (Form1.habI == true)
            {
                richTextBox1.AppendText(line49  + Environment.NewLine);
                richTextBox1.AppendText(line50  + Environment.NewLine);
                richTextBox1.AppendText(line51a + Environment.NewLine);
                foreach (string str in Form1.alternI)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line51b + Environment.NewLine);
                richTextBox1.AppendText(line52 + Environment.NewLine);

            }
            richTextBox1.AppendText(line53 + Environment.NewLine);
            richTextBox1.AppendText(line54 + Environment.NewLine);
            richTextBox1.AppendText(line55 + Environment.NewLine);
            richTextBox1.AppendText(line56 + Environment.NewLine);
            richTextBox1.AppendText(line57 + Environment.NewLine);
            richTextBox1.AppendText(line58 + Environment.NewLine);
            richTextBox1.AppendText(line59 + Environment.NewLine);
            richTextBox1.AppendText(line60 + Environment.NewLine);
            richTextBox1.AppendText(line61 + Environment.NewLine);
            richTextBox1.AppendText(line62 + Environment.NewLine);
            richTextBox1.AppendText(line63 + Environment.NewLine);

            if (Form1.habA == true)
            {
                richTextBox1.AppendText(line64a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternA)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line64b + Environment.NewLine);

                richTextBox1.AppendText(line65a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplA)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line65b + Environment.NewLine);

                richTextBox1.AppendText(line66 + Environment.NewLine);
                richTextBox1.AppendText(line67 + Environment.NewLine);
                richTextBox1.AppendText(line68 + Environment.NewLine);
                richTextBox1.AppendText(line69a + Environment.NewLine);
                foreach (string str in Form1.codeA)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line69b + Environment.NewLine);
                richTextBox1.AppendText(line70 + Environment.NewLine);
                richTextBox1.AppendText(line71 + Environment.NewLine);
                richTextBox1.AppendText(line72 + Environment.NewLine);
            }
            if (Form1.habB == true)
            {
                richTextBox1.AppendText(line73a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternB)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line73b + Environment.NewLine);

                richTextBox1.AppendText(line74a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplB)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line74b + Environment.NewLine);

                richTextBox1.AppendText(line75 + Environment.NewLine);
                richTextBox1.AppendText(line76 + Environment.NewLine);
                richTextBox1.AppendText(line77 + Environment.NewLine);
                richTextBox1.AppendText(line78a + Environment.NewLine);
                foreach (string str in Form1.codeB)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line78b + Environment.NewLine);
                richTextBox1.AppendText(line79 + Environment.NewLine);
                richTextBox1.AppendText(line80 + Environment.NewLine);
                richTextBox1.AppendText(line81 + Environment.NewLine);
            }
            if (Form1.habC == true)
            {
                richTextBox1.AppendText(line82a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternC)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line82b + Environment.NewLine);

                richTextBox1.AppendText(line83a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplC)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line83b + Environment.NewLine);

                richTextBox1.AppendText(line84 + Environment.NewLine);
                richTextBox1.AppendText(line85 + Environment.NewLine);
                richTextBox1.AppendText(line86 + Environment.NewLine);
                richTextBox1.AppendText(line87a + Environment.NewLine);
                foreach (string str in Form1.codeC)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line87b + Environment.NewLine);
                richTextBox1.AppendText(line88 + Environment.NewLine);
                richTextBox1.AppendText(line89 + Environment.NewLine);
                richTextBox1.AppendText(line90 + Environment.NewLine);
            }
            if (Form1.habD == true)
            {
                richTextBox1.AppendText(line91a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternD)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line91b + Environment.NewLine);

                richTextBox1.AppendText(line92a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplD)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line92b + Environment.NewLine);

                richTextBox1.AppendText(line93 + Environment.NewLine);
                richTextBox1.AppendText(line94 + Environment.NewLine);
                richTextBox1.AppendText(line95 + Environment.NewLine);
                richTextBox1.AppendText(line96a + Environment.NewLine);
                foreach (string str in Form1.codeD)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line96b + Environment.NewLine);
                richTextBox1.AppendText(line97 + Environment.NewLine);
                richTextBox1.AppendText(line98 + Environment.NewLine);
                richTextBox1.AppendText(line99 + Environment.NewLine);
            }
            if (Form1.habE == true)
            {
                richTextBox1.AppendText(line100a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternE)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line100b + Environment.NewLine);

                richTextBox1.AppendText(line101a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplE)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line101b + Environment.NewLine);

                richTextBox1.AppendText(line102 + Environment.NewLine);
                richTextBox1.AppendText(line103 + Environment.NewLine);
                richTextBox1.AppendText(line104 + Environment.NewLine);
                richTextBox1.AppendText(line105a + Environment.NewLine);
                foreach (string str in Form1.codeE)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line105b + Environment.NewLine);
                richTextBox1.AppendText(line106 + Environment.NewLine);
                richTextBox1.AppendText(line107 + Environment.NewLine);
                richTextBox1.AppendText(line108 + Environment.NewLine);
            }
            if (Form1.habF == true)
            {
                richTextBox1.AppendText(line109a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternF)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line109b + Environment.NewLine);

                richTextBox1.AppendText(line110a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplF)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line110b + Environment.NewLine);

                richTextBox1.AppendText(line111 + Environment.NewLine);
                richTextBox1.AppendText(line112 + Environment.NewLine);
                richTextBox1.AppendText(line113 + Environment.NewLine);
                richTextBox1.AppendText(line114a + Environment.NewLine);
                foreach (string str in Form1.codeF)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line114b + Environment.NewLine);
                richTextBox1.AppendText(line115 + Environment.NewLine);
                richTextBox1.AppendText(line116 + Environment.NewLine);
                richTextBox1.AppendText(line117 + Environment.NewLine);
            }
            if (Form1.habG == true)
            {
                richTextBox1.AppendText(line118a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternG)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line118b + Environment.NewLine);

                richTextBox1.AppendText(line119a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplG)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line119b + Environment.NewLine);

                richTextBox1.AppendText(line120 + Environment.NewLine);
                richTextBox1.AppendText(line121 + Environment.NewLine);
                richTextBox1.AppendText(line122 + Environment.NewLine);
                richTextBox1.AppendText(line123a + Environment.NewLine);
                foreach (string str in Form1.codeG)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line123b + Environment.NewLine);
                richTextBox1.AppendText(line124 + Environment.NewLine);
                richTextBox1.AppendText(line125 + Environment.NewLine);
                richTextBox1.AppendText(line126 + Environment.NewLine);
            }
            if (Form1.habH == true)
            {
                richTextBox1.AppendText(line127a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternH)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line127b + Environment.NewLine);

                richTextBox1.AppendText(line128a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplH)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line128b + Environment.NewLine);

                richTextBox1.AppendText(line129 + Environment.NewLine);
                richTextBox1.AppendText(line130 + Environment.NewLine);
                richTextBox1.AppendText(line131 + Environment.NewLine);
                richTextBox1.AppendText(line132a + Environment.NewLine);
                foreach (string str in Form1.codeH)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line132b + Environment.NewLine);
                richTextBox1.AppendText(line133 + Environment.NewLine);
                richTextBox1.AppendText(line134 + Environment.NewLine);
                richTextBox1.AppendText(line135 + Environment.NewLine);
            }
            if (Form1.habI == true)
            {
                richTextBox1.AppendText(line136a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.alternI)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line136b + Environment.NewLine);

                richTextBox1.AppendText(line137a + "<br/>" + Environment.NewLine);
                foreach (string str in Form1.textExplI)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line137b + Environment.NewLine);

                richTextBox1.AppendText(line138 + Environment.NewLine);
                richTextBox1.AppendText(line139 + Environment.NewLine);
                richTextBox1.AppendText(line140 + Environment.NewLine);
                richTextBox1.AppendText(line141a + Environment.NewLine);
                foreach (string str in Form1.codeI)
                {
                    richTextBox1.AppendText(str + "<br/>" + Environment.NewLine);
                }
                richTextBox1.AppendText(line141b + Environment.NewLine);
                richTextBox1.AppendText(line142 + Environment.NewLine);
                richTextBox1.AppendText(line143 + Environment.NewLine);
                richTextBox1.AppendText(line144 + Environment.NewLine);
            }
            richTextBox1.AppendText(line145 + Environment.NewLine);
            richTextBox1.AppendText(line146 + Environment.NewLine);
            richTextBox1.AppendText(line147 + Environment.NewLine);
            richTextBox1.AppendText(line148 + Environment.NewLine);
            richTextBox1.AppendText(line149 + Environment.NewLine);
            richTextBox1.AppendText(line150 + Environment.NewLine);
            richTextBox1.AppendText(line151 + Environment.NewLine);
            richTextBox1.AppendText(line152 + Environment.NewLine);
            richTextBox1.AppendText(line153 + Environment.NewLine);

            //salvar arquivo
            if (Directory.Exists(diretorio))
            {
                salvararquivo();
            }
            else
            {
                Directory.CreateDirectory(diretorio);
                salvararquivo();
            }
        }

        private void salvararquivo()
        {
            string arquivo = diretorio + "/" + Form1.numquest + ".txt";
            if (File.Exists(arquivo))
            {
                DialogResult dialogResult = MessageBox.Show("A pergunta " + Form1.numquest + " já existe, desdeja substituir o conteúdo dela?", "Substituir conteúdo?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    escrevearquivo(arquivo);
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
                
            }
            else
            {
                var myFile = File.Create(arquivo);
                myFile.Close();
                escrevearquivo(arquivo);

            }
        }

        private void escrevearquivo(string arquivo)
        {
            try
            {

                ////declarando a variavel do tipo StreamWriter para
                //abrir ou criar um arquivo para escrita
                StreamWriter x;

                ////Colocando o caminho fisico e o nome do arquivo a ser criado
                //finalizando com .txt
                string CaminhoNome = arquivo;

                //utilizando o metodo para criar um arquivo texto
                //e associando o caminho e nome ao metodo
                x = File.CreateText(CaminhoNome);

                //aqui, exemplo de escrever no arquivo texto
                                //escrevendo conteúdo
                foreach (string str in Form1.intro)
                {
                    //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                    x.WriteLine("intro: "+ str, true);
                }
                
                //pulando linha sem escrita
                x.WriteLine();

                foreach (string str in Form1.emba)
                {
                    //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                    x.WriteLine("emba: " + str, true);
                }

                //pulando linha sem escrita
                x.WriteLine();

                foreach (string str in Form1.tabela)
                {
                    //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                    x.WriteLine("tabela: " + str, true);
                }

                //pulando linha sem escrita
                x.WriteLine();

                foreach (string str in Form1.pergunta)
                {
                    //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                    x.WriteLine("pergunta: " + str, true);
                }

                //pulando linha sem escrita
                x.WriteLine();


                //pulando linha sem escrita
                x.WriteLine();

                if (Form1.habA)
                {
                    x.WriteLine("habA: " + Form1.habA);
                    x.WriteLine("trueA: " + Form1.trueA);
                    foreach (string str in Form1.alternA)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternA: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplA)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplA: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeA)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeA: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }
                if (Form1.habB)
                {
                    x.WriteLine("habB: " + Form1.habB);
                    x.WriteLine("trueB: " + Form1.trueB);
                    foreach (string str in Form1.alternB)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternB: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplB)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplB: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeB)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeB: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }
                if (Form1.habC)
                {
                    x.WriteLine("habC: " + Form1.habC);
                    x.WriteLine("trueC: " + Form1.trueC);
                    foreach (string str in Form1.alternC)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternC: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplC)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplC: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeC)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeC: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }
                if (Form1.habD)
                {
                    x.WriteLine("habD: " + Form1.habD);
                    x.WriteLine("trueD: " + Form1.trueD);
                    foreach (string str in Form1.alternD)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternD: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplD)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplD: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeD)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeD: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }
                if (Form1.habE)
                {
                    x.WriteLine("habE: " + Form1.habE);
                    x.WriteLine("trueE: " + Form1.trueE);
                    foreach (string str in Form1.alternE)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternE: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplE)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplE: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeE)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeE: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }
                if (Form1.habF)
                {
                    x.WriteLine("habF: " + Form1.habF);
                    x.WriteLine("trueF: " + Form1.trueF);
                    foreach (string str in Form1.alternF)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternF: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplF)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplF: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeF)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeF: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }
                if (Form1.habG)
                {
                    x.WriteLine("habG: " + Form1.habG);
                    x.WriteLine("trueG: " + Form1.trueG);
                    foreach (string str in Form1.alternG)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternG: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplG)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplG: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeG)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeG: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }
                if (Form1.habH)
                {
                    x.WriteLine("habH: " + Form1.habH);
                    x.WriteLine("trueH: " + Form1.trueH);
                    foreach (string str in Form1.alternH)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternH: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplH)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplH: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeH)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeH: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }
                if (Form1.habI)
                {
                    x.WriteLine("habI: " + Form1.habI);
                    x.WriteLine("trueI: " + Form1.trueI);
                    foreach (string str in Form1.alternI)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("alternI: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.textExplI)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("textExplI: " + str, true);
                    }
                    //pulando linha sem escrita
                    x.WriteLine();
                    foreach (string str in Form1.codeI)
                    {
                        //o true substitui todo o conteudo do arquivo, se tirar o true ele insere a linha abaixo das outras
                        x.WriteLine("codeI: " + str, true);
                    }

                    //pulando linha sem escrita
                    x.WriteLine();
                }

                //fechando o arquivo texto com o método .Close()
                x.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
