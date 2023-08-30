using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Navrhněte metodu BinToHex s jedním parametrem typu String, která převede binární
        číslo ve tvaru řetězce znaků na číslo šestnáctkové ve tvaru řetězce znaků. Ověřte
        použitím v projektu. Nepoužívejte standardní metody pro konverzi!
        */

        private string BinToHex(string bin)
        {
            string hex = "", subString;
            int hodnota = 1, hodnotaDec = 0;

            //Aby vzdy sedel pocet
            while (bin.Length % 4 != 0) bin = bin.Insert(0, "0");
            while (bin.Length > 0)
            {
                subString = bin.Substring(0, 4);
                for (int i = subString.Length - 1; i >= 0; i--)
                {
                    if (subString[i] == '1') hodnotaDec += hodnota;
                    hodnota *= 2;
                }

                if (hodnotaDec < 10) hex += hodnotaDec;
                else hex += (char)(hodnotaDec + 55);
                
                hodnotaDec = 0;
                hodnota = 1;
                bin = bin.Remove(0, 4);
            }
            return hex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bin = textBox1.Text;
            textBox2.Text = this.BinToHex(bin);
        }
    }
}
