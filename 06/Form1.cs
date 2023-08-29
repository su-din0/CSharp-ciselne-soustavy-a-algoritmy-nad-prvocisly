using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Navrhněte metodu DecToHex s jedním parametrem typu celé číslo, která převede
        desítkové číslo na číslo šestnáctkové ve tvaru řetězce znaků. Ověřte použitím v projektu.
        Nepoužívejte standardní metody pro konverzi!
        */

        private string DecToHex(int dec)
        {
            string hex = "";
            while (dec > 0)
            {
                int zbytek = dec % 16;

                if (zbytek < 10) hex = zbytek + hex;
                else hex = (char)(zbytek + 55) + hex;

                /*
                Nebo Takhle
                if (zbytek < 10)
                {
                    hex = hex.Insert(0, zbytek.ToString());
                }
                else
                {
                    switch (zbytek)
                    {
                        case 10:
                            hex = hex.Insert(0, "A");
                            break;
                        case 11:
                            hex = hex.Insert(0, "B");
                            break;
                        case 12:
                            hex = hex.Insert(0, "C");
                            break;
                        case 13:
                            hex = hex.Insert(0, "D");
                            break;
                        case 14:
                            hex = hex.Insert(0, "E");
                            break;
                        case 15:
                            hex = hex.Insert(0, "F");
                            break;
                        default:
                            break;
                    }
                }
                */


                dec /= 16;
            }

            return hex;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(textBox1.Text);
            textBox2.Text = DecToHex(dec);
        }
    }
}
