using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Navrhněte metodu DecToBin s jedním parametrem typu celé číslo, která převede
        desítkové číslo na číslo binární ve tvaru řetězce znaků. Ověřte použitím v projektu.
        Nepoužívejte standardní metody pro konverzi!
        */

        private string DecToBin(int cislo)
        {
            /*
             * Neustále musíme dělit číslo 2 a zbytek z dělení ukládat do řetězce.
            */
            string bin = "";
            while (cislo > 0)
            {
                bin = (cislo % 2) + bin;
                cislo /= 2;
            }

            //Musíme zajistit aby byl řetězec vždy 4 znaky dlouhý
            while (bin.Length % 4 != 0)
            {
                bin = bin.Insert(0, "0");
            }
            
            return bin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);

            textBox2.Text = this.DecToBin(n);
        }
    }
}
