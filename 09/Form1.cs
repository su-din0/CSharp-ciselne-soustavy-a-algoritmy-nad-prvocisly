using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Navrhněte metodu HexToDec s jedním parametrem typu String, která převede
        šestnáctkové číslo ve tvaru řetězce znaků na číslo desítkové. Ověřte použitím v projektu.
        Nepoužívejte standardní metody pro konverzi!
        */
        private int HexToDec(string hex)
        {
            /*
            1. způsob
            int dec = 0;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int hodnota = 0;
                if (hex[i] >= '0' && hex[i] <= '9') hodnota = hex[i] - '0';
                else hodnota = hex[i] - 'A' + 10;
                dec += hodnota * (int)Math.Pow(16, hex.Length - 1 - i);
            }


            return dec;   
            */

            // 2. způsob
            int dec = 0;
            int cislo;
            int hodnota = 1;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(hex[i]))
                {
                    cislo = int.Parse(hex[i].ToString());
                    dec += cislo * hodnota;
                }
                else
                {
                    switch (hex[i])
                    {
                        case 'A':
                            dec += 10 * hodnota;
                            break;
                        case 'B':
                            dec += 11 * hodnota;
                            break;
                        case 'C':
                            dec += 12 * hodnota;
                            break;
                        case 'D':
                            dec += 13 * hodnota;
                            break;
                        case 'E':
                            dec += 14 * hodnota;
                            break;
                        case 'F':
                            dec += 15 * hodnota;
                            break;
                        default:
                            break;
                    }
                }
                hodnota = hodnota * 16;
            }
            return dec;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string hex = textBox1.Text;
            textBox2.Text = HexToDec(hex).ToString();
        }
    }
}
