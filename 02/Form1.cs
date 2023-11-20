using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Vytvořte datový soubor cisla,dat, který bude obsahovat všechna prvočísla z intervalu
        (1;1000>. Soubor zobrazte. Vypiš počet prvočísel. Algoritmus pro nalezení prvočísla co
        nejvíce optimalizujte.
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("cisla.dat", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            int pocetPrvocisel = 0;
            for (int i = 1; i < 1001; i++)
            {
                if(JePrvocislo(i))
                {
                    bw.Write(i);
                    pocetPrvocisel++;
                }
            }

            fs.Position = 0;
            BinaryReader br = new BinaryReader(fs);
            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                int cislo = br.ReadInt32();
                listBox1.Items.Add(cislo);
            }

            br.Close();
            bw.Close();

            MessageBox.Show($"V intervalu (1; 1000> je {pocetPrvocisel}");
        }
    }
}
