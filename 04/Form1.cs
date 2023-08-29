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

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        Na disku je dán soubor cisla.dat. Vytvoř soubor prvocisla.dat, který bude obsahovat
        pouze prvočísla z prvního datového souboru. Algoritmus pro nalezení prvočísla co
        nejvíce optimalizujte.
        */

        private bool JePrvocislo(int cislo)
        {
            bool jePrvocislo = true;
            if (cislo == 1 || (cislo % 2 == 0 && cislo != 2)) jePrvocislo = false;
            for (int i = 3; i < Math.Sqrt(cislo) && jePrvocislo; i += 2)
            {
                if (cislo % i == 0) jePrvocislo = false;
            }

            return jePrvocislo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            FileStream fsCisla = new FileStream("cisla.dat", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fsCisla);


            int n = int.Parse(textBox1.Text);

            for (int i = 0; i < n; i++)
            {
                int cislo = rnd.Next(1, 1001);
                bw.Write(cislo);
            }



            fsCisla.Position = 0;
            BinaryReader brCisla = new BinaryReader(fsCisla);

            FileStream fsPrvocisla = new FileStream("prvocisla.dat", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bwPrvocisla = new BinaryWriter(fsPrvocisla);

            listBox1.Items.Clear();
            while (brCisla.BaseStream.Position < brCisla.BaseStream.Length)
            {
                int cislo = brCisla.ReadInt32();
                listBox1.Items.Add(cislo);
                if (JePrvocislo(cislo))
                {
                    bwPrvocisla.Write(cislo);
                }
            }

            fsCisla.Close();

            fsPrvocisla.Position = 0;
            BinaryReader brPrvocisla = new BinaryReader(fsPrvocisla);

            listBox2.Items.Clear();
            while (brPrvocisla.BaseStream.Position < brPrvocisla.BaseStream.Length)
            {
                int cislo = brPrvocisla.ReadInt32();
                listBox2.Items.Add(cislo);
            }

            fsPrvocisla.Close();
        }
    }
}
