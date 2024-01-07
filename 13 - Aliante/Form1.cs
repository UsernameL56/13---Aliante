using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classi;
namespace _13___Aliante
{
    public partial class Form1 : Form
    {
        bool ala;
        bool fusoliera;
        bool coda;
        bool ruota;
        Aliante aliante;
        public Form1()
        {
            InitializeComponent();
            ala = false;
            fusoliera = false;
            coda = false;
            ruota = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void alaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ala = true; fusoliera = false; coda = false; ruota = false;
            groupBox1.Show();
        }

        private void fusolieraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ala = false; fusoliera = true; coda = false; ruota = false;
            groupBox2.Show();
        }

        private void codaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ala = false; fusoliera = false; coda = true; ruota = false;
            groupBox3.Show();
        }

        private void ruotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ala = false; fusoliera = false; coda = false; ruota = true;
            groupBox4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ala == true)
            {
                if(double.TryParse(alaLunghezza.Text, out double _alaLunghezza) && double.TryParse(alaApertura.Text, out double _alaApertura))
                {
                    Ala ala = new Ala(_alaLunghezza, _alaApertura);
                }
            }
        }
    }
}
