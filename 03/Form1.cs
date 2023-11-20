using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Navrhněte projekt, který bude obsahovat metodu JePrvocislo s parametrem typu int.
        Metoda zjistí, zda zadané číslo je prvočíslo. Algoritmus v metodě, co nejvíce
        optimalizujte. Vypište největší prvočíslo menší než 1000.
        */

        private bool JePrvocislo(int cislo)
        {
            bool jePrvocislo = true;
            if (cislo == 1 || (cislo % 2 == 0 && cislo != 2)) jePrvocislo = false;
            for (int i = 3; i <= Math.Sqrt(cislo) && jePrvocislo; i += 2)
            {
                if (cislo % i == 0) jePrvocislo = false;
            }

            return jePrvocislo;
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nejvetsiPrvocislo = -1;
            for (int i = 1; i < 1001; i++)
            {
                if (this.JePrvocislo(i)) nejvetsiPrvocislo = i;
            }
            if (nejvetsiPrvocislo != -1) MessageBox.Show($"Největší prvočíslo je {nejvetsiPrvocislo}");
            else MessageBox.Show("Neobsahuje prvočíslo");
        }
    }
}
