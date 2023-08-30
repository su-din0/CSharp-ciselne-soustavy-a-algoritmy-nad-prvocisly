using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Navrhněte metodu HexToBin s jedním parametrem typu String, která převede
        šestnáctkové číslo ve tvaru řetězce znaků na číslo binární ve tvaru řetězce znaků. Ověřte
        použitím v projektu. Nepoužívejte standardní metody pro konverzi!
        */

        private string HexToBin(string hex)
        {
            string bin = "";
            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '0':
                        bin += "0000";
                        break;
                    case '1':
                        bin += "0001 ";
                        break;
                    case '2':
                        bin += "0010 ";
                        break;
                    case '3':
                        bin += "0011 ";
                        break;
                    case '4':
                        bin += "0100 ";
                        break;
                    case '5':
                        bin += "0101 ";
                        break;
                    case '6':
                        bin += "0110 ";
                        break;
                    case '7':
                        bin += "0111 ";
                        break;
                    case '8':
                        bin += "1000 ";
                        break;
                    case '9':
                        bin += "1001 ";
                        break;
                    case 'A':
                        bin += "1010 ";
                        break;
                    case 'B':
                        bin += "1011 ";
                        break;
                    case 'C':
                        bin += "1100 ";
                        break;
                    case 'D':
                        bin += "1101 ";
                        break;
                    case 'E':
                        bin += "1110 ";
                        break;
                    case 'F':
                        bin += "1111 ";
                        break;
                    default:
                        break;
                }
            }

            return bin;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string hex = textBox1.Text;
            textBox2.Text = HexToBin(hex);
        }
    }
}
