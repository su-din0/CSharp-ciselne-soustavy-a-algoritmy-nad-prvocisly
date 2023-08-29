using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Napište metodu, která ověří, že zadané číslo je prvočíslo. Algoritmus v metodě
        maximálně optimalizujte.
        Na vstupu je číslo N a N-prvková posloupnost náhodných celých čísel z intervalu 1..120
        včetně. Obsahuje posloupnost prvočíslo a jaké je první z nich? Pro zkrácení cyklu
        procházejícího prvky posloupnosti použijte typ bool.
        */

        private bool JePrvocislo(int cislo)
        {
            bool jePrvocislo = true;
            if (cislo == 1 || (cislo % 2 == 0 && cislo != 2)) jePrvocislo = false;
            for (int i = 3; i < Math.Sqrt(cislo) && jePrvocislo; i+=2)
            {
                if (cislo % i == 0) jePrvocislo = false;
            }

            return jePrvocislo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = int.Parse(textBox1.Text);

            listBox1.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                int cislo = rnd.Next(1, 121);
                listBox1.Items.Add(cislo);
            }

            bool obsahujePrvocislo = false;
            for (int i = 0; i < listBox1.Items.Count && !obsahujePrvocislo; i++)
            {
                int cislo = int.Parse(listBox1.Items[i].ToString());
                if (this.JePrvocislo(cislo)) {
                    obsahujePrvocislo = true;
                    MessageBox.Show($"První prvočíslo je {cislo}");
                }
            }
        }
    }
}
