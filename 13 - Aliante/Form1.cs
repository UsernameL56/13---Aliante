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
            aliante = new Aliante(new List<Componente>());
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

        private void Aggiunta_Click(object sender, EventArgs e)
        {
            if (ala == true)
            {
                if (double.TryParse(alaLunghezza.Text, out double _alaLunghezza) && double.TryParse(alaApertura.Text, out double _alaApertura) && double.TryParse(alaPrezzo.Text, out double _alaPrezzo))
                {
                    Ala ala = new Ala(_alaLunghezza, _alaApertura, _alaPrezzo);
                    aliante.Add(ala);
                    MessageBox.Show("Operazione conclusa con successo", "info");
                    return;
                }
                else
                    MessageBox.Show("Inserire gli input richiesti correttamente", "info");
            }
            else if(fusoliera == true)
            {
                if(!String.IsNullOrEmpty(fusolieraMateriale?.Text) && double.TryParse(fusolieraLunghezza?.Text, out double _fusolieraLunghezza) && double.TryParse(fusolieraPrezzo?.Text, out double _fusolieraPrezzo))
                {
                    Fusoliera fusoliera = new Fusoliera(fusolieraMateriale.Text, _fusolieraLunghezza, _fusolieraPrezzo);
                    aliante.Add(fusoliera);
                    MessageBox.Show("Operazione conclusa con successo", "info");
                    return;
                }
                else
                    MessageBox.Show("Inserire gli input richiesti correttamente", "info");
            }
            else if(coda == true)
            {
                if(double.TryParse(codaLunghezza.Text, out double _codaLunghezza) && double.TryParse(codaPrezzo.Text, out double _codaPrezzo))
                {
                    Coda coda = new Coda(_codaLunghezza, _codaPrezzo);
                    aliante.Add(coda);
                    MessageBox.Show("Operazione conclusa con successo", "info");
                    return;
                }
                else
                    MessageBox.Show("Inserire gli input richiesti correttamente", "info");
            }
            else if(ruota == true)
            {
                if (double.TryParse(cerchionePollici.Text, out double _cerchionePollici) && !String.IsNullOrEmpty(cerchioneMateriale.Text) && double.TryParse(cerchionePrezzo.Text, out double _cerchionePrezzo)
                    && double.TryParse(gommaAltezza.Text, out double _gommaAltezza) && double.TryParse(gommaLarghezza.Text, out double _gommaLarghezza) && double.TryParse(gommaRaggio.Text, out double _gommaRaggio) && double.TryParse(gommaPrezzo.Text, out double _gommaPrezzo))
                {
                    Cerchione cerchione = new Cerchione(_cerchionePollici, cerchioneMateriale.Text, _cerchionePrezzo);
                    Gomma gomma = new Gomma(_gommaAltezza, _gommaLarghezza, _gommaRaggio, _gommaPrezzo);

                    Ruota ruota = new Ruota(cerchione, gomma);
                    aliante.Add(ruota);
                    MessageBox.Show("Operazione conclusa con successo", "info");
                    return;
                }
                else
                    MessageBox.Show("Inserire gli input richiesti correttamente", "info");
            }
            else
            {
                MessageBox.Show("selezionare un argomento", "info");
            }
        }

        private void Stampa_Click(object sender, EventArgs e)
        {
            if(aliante.Componenti.Count < 1)
            {
                MessageBox.Show("Inserire almeno un elemento nella lista");
            }
            else
            {

                listView1.Items.Add(aliante.Descrizione());
            }
        }
    }
}
