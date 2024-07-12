using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class Form1 : Form
    {
        class CnodeN 
        {
            public string x;
        }
        List<CnodeN> L = new List<CnodeN>();
        List<CnodeN> LNums = new List<CnodeN>();
        string Num;
        float sum;
        float x;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            AddAll("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            AddAll("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            AddAll("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            AddAll("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            AddAll("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            AddAll("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            AddAll("7");

        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            AddAll("8");

        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            AddAll("9");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
            AddAll("0");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
            AddAll("+");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
            AddAll("-");
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
            AddAll("*");
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
            AddAll("/");
        }
        private void button15_Click(object sender, EventArgs e)
        {
            collect();
            calc();
            textBox1.Text = sum +"";
        }
        void AddAll(string N)
        {
           CnodeN pnn = new CnodeN();
            pnn.x = N;
            L.Add(pnn);
        }
        void AddN(string N)
        {
            CnodeN pnn = new CnodeN();
            pnn.x = N;
            LNums.Add(pnn);
        }
        void collect()
        {
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].x == "+" || L[i].x == "-" || L[i].x == "/" || L[i].x == "*" || L[i].x == "%") 
                {
                    AddN(Num);
                    Num = "";
                    AddN(L[i].x);
                    Num = "";
                }
                else
                {
                    Num += L[i].x;
                    if (i == L.Count - 1) 
                    {
                        AddN(Num);
                        Num = "";
                    }
                }
            }                                    
        }
        void calc()
        {
            for(int i = 0;i < LNums.Count;i++)
            {
                if (LNums[i].x == "/")
                {
                    sum = float.Parse(LNums[i - 1].x) / float.Parse(LNums[i + 1].x);
                    LNums.Remove(LNums[i + 1]);
                    LNums.Remove(LNums[i]);
                    LNums[i - 1].x = sum + "";
                }  
            }

            for (int i = 0; i < LNums.Count; i++)
            {
                if (LNums[i].x == "*")
                {
                    sum = float.Parse(LNums[i - 1].x) * float.Parse(LNums[i + 1].x);
                    LNums.Remove(LNums[i + 1]);
                    LNums.Remove(LNums[i]);
                    LNums[i - 1].x = sum + "";
                }
            }
            for (int i = 0; i < LNums.Count; i++)
            {
                if (LNums[i].x == "+")
                {
                    sum = float.Parse(LNums[i - 1].x) + float.Parse(LNums[i + 1].x);
                    LNums.Remove(LNums[i + 1]);
                    LNums.Remove(LNums[i]);
                    LNums[i - 1].x = sum + "";
                }
            }
            for (int i = 0; i < LNums.Count; i++)
            {
                if (LNums[i].x == "-")
                {
                    sum = float.Parse(LNums[i - 1].x) - float.Parse(LNums[i + 1].x);
                    LNums.Remove(LNums[i + 1]);
                    LNums.Remove(LNums[i]);
                    LNums[i - 1].x = sum + "";
                }
            }
            for (int i = 0; i < LNums.Count; i++)
            {
                if (LNums[i].x == "%")
                {
                    sum = float.Parse(LNums[i - 1].x) / float.Parse(LNums[i + 1].x);
                    int y = int.Parse(LNums[i - 1].x) / int.Parse(LNums[i + 1].x);
                    sum -= y;
                    sum *= float.Parse(LNums[i + 1].x);

                    LNums.Remove(LNums[i + 1]);
                    LNums.Remove(LNums[i]);
                    LNums[i - 1].x = sum + "";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            LNums.Clear();
            L.Clear();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            AddAll(".");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
            AddAll("%");
        }
        private void button19_Click(object sender, EventArgs e)
        {
            string D;
            D = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
            textBox1.Text = D;
            L.RemoveAt(L.Count - 1);
        }
    }
}
