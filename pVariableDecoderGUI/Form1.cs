using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pVariableDecoderGUI
{
    public partial class Form1 : Form
    {
        #region variables
        string l1 = "z", l38 = "y", l854 = "v", l21 = "x", l293 = "w", l231 = "ü", l123 = "u", l32 = "t", l27 = "ş", l22 = "r", l36 = "ö", l58 = "o", l23 = "n", l259 = "m", l385 = "l", l463 = "k", ll453 = "j", l0 = "i", l933 = "ı", l128 = "h", l5320 = "g", l192 = "f", l723 = "e", l2495 = "d", l238 = "ç", l333 = "c", l444 = "b", l756 = "a", l3432 = ".", l5567 = "/", l5568 = "\\", l2277 = "'", l2278 = "\"", l949 = "&&", l630 = " ", l631 = "+", l632 = ";", l101 = "p", l102 = "s", l103 = "%", l9999 = "*", l3263 = "q", l00="0",l01="1",l02="2",l03="3",l04="4",l05="5",l06="6",l07="7",l08="8",l09="9",l241="(",l653=")",l341="-",l527="_",l97="[",l96="]",l95=":",l94="=",l93=">",l92="<",l91="#",l90=",",l89="S",l88="I",l87="D",l86="|",l85="$",l79="X";

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        #endregion

        #region create_lists
        List<string> variables = new List<string>();
        List<string> letters = new List<string>();
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            #region add_variables
            variables.Add("l1");
            variables.Add("l38");
            variables.Add("l854");
            variables.Add("l21");
            variables.Add("l293");
            variables.Add("l231");
            variables.Add("l123");
            variables.Add("l32");
            variables.Add("l27");
            variables.Add("l22");
            variables.Add("l36");
            variables.Add("l58");
            variables.Add("l23");
            variables.Add("l259");
            variables.Add("l385");
            variables.Add("l463");
            variables.Add("ll453");
            variables.Add("l0");
            variables.Add("l933");
            variables.Add("l128");
            variables.Add("l5320");
            variables.Add("l192");
            variables.Add("l723");
            variables.Add("l2495");
            variables.Add("l238");
            variables.Add("l333");
            variables.Add("l444");
            variables.Add("l756");
            variables.Add("l3432");
            variables.Add("l5567");
            variables.Add("l5568");
            variables.Add("l2277");
            variables.Add("l2278");
            variables.Add("l949");
            variables.Add("l630");
            variables.Add("l631");
            variables.Add("l632");
            variables.Add("l101");
            variables.Add("l102");
            variables.Add("l103");
            variables.Add("l9999");
            variables.Add("l3263");
            variables.Add("l00");
            variables.Add("l01");
            variables.Add("l02");
            variables.Add("l03");
            variables.Add("l04");
            variables.Add("l05");
            variables.Add("l06");
            variables.Add("l07");
            variables.Add("l08");
            variables.Add("l09");
            variables.Add("l241");
            variables.Add("l653");
            variables.Add("l341");
            variables.Add("l527");
            variables.Add("l97");
            variables.Add("l96");
            variables.Add("l95");
            variables.Add("l94");
            variables.Add("l93");
            variables.Add("l92");
            variables.Add("l91");
            variables.Add("l90");
            variables.Add("l89");
            variables.Add("l88");
            variables.Add("l87");
            variables.Add("l86");
            variables.Add("l85");
            variables.Add("l79");
            #endregion
            #region add_letters
            letters.Add("z");
            letters.Add("y");
            letters.Add("v");
            letters.Add("x");
            letters.Add("w");
            letters.Add("ü");
            letters.Add("u");
            letters.Add("t");
            letters.Add("ş");
            letters.Add("r");
            letters.Add("ö");
            letters.Add("o");
            letters.Add("n");
            letters.Add("m");
            letters.Add("l");
            letters.Add("k");
            letters.Add("j");
            letters.Add("i");
            letters.Add("ı");
            letters.Add("h");
            letters.Add("g");
            letters.Add("f");
            letters.Add("e");
            letters.Add("d");
            letters.Add("ç");
            letters.Add("c");
            letters.Add("b");
            letters.Add("a");
            letters.Add(".");
            letters.Add("/");
            letters.Add("\\");
            letters.Add("'");
            letters.Add("\"");
            letters.Add("&&");
            letters.Add(" ");
            letters.Add("+");
            letters.Add(";");
            letters.Add("p");
            letters.Add("s");
            letters.Add("%");
            letters.Add("*");
            letters.Add("q");
            letters.Add("0");
            letters.Add("1");
            letters.Add("2");
            letters.Add("3");
            letters.Add("4");
            letters.Add("5");
            letters.Add("6");
            letters.Add("7");
            letters.Add("8");
            letters.Add("9");
            letters.Add("(");
            letters.Add(")");
            letters.Add("-");
            letters.Add("_");
            letters.Add("[");
            letters.Add("]");
            letters.Add(":");
            letters.Add("=");
            letters.Add(">");
            letters.Add("<");
            letters.Add("#");
            letters.Add(",");
            letters.Add("S");
            letters.Add("I");
            letters.Add("D");
            letters.Add("|");
            letters.Add("$");
            letters.Add("X");
            #endregion
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region sifrele
            string output = "";
            string input = richTextBox1.Text.ToString();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < letters.Count; j++)
                {
                    if (input[i].ToString() == letters[j])
                    {
                        output += variables[j];
                        output += l631;
                    }
                }
            }
            if (output != null && output != " ")
                output = output.Substring(0, output.Length - 1);
            richTextBox2.Text = output;
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region çöz
            string reverse_output = "";
            string input = richTextBox1.Text.ToString();
            input = input.Replace(" ", "");
            string[] outputs = input.Split('+');
            for (int i = 0; i < outputs.Length; i++)
            {
                for (int j = 0; j < variables.Count; j++)
                    if (outputs[i].ToString() == variables[j])
                        reverse_output += letters[j];
            }
            richTextBox2.Text= reverse_output;
            #endregion
        }
    }
}
