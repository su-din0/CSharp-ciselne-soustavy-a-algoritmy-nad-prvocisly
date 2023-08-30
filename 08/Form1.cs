using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Navrhněte metodu BinToDec s jedním parametrem typu String, která převede binární
        číslo ve tvaru řetězce znaků na číslo desítkové. Ověřte použitím v projektu.
        Nepoužívejte standardní metody pro konverzi!
        */

        private int BinToDec(string bin)
        {
            int dec = 0;
            int hodnota = 1;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '1') dec += hodnota;
                hodnota *= 2;
            }

            /*
            Nebo takhle
            char[] array = bin.ToCharArray();
            Array.Reverse(array);

            int dec = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    dec += (int)Math.Pow(2, i);
                }
            }
            */


            return dec;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string bin = textBox1.Text;
            textBox2.Text = this.BinToDec(bin).ToString();
        }
    }
}
