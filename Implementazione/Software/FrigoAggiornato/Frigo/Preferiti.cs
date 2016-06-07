using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frigo
{
    public partial class Preferiti : UserControl
    {
        ConnessioneDB conn = new ConnessioneDB();
        bool var = false;
        public Preferiti()
        {
            InitializeComponent();
            conn.ComboBoxUtenti(comboBox_utente);
        }

        public void Preferiti_Load(object sender, EventArgs e)
        {
            //clicco in modo automatico il bottone
            start.PerformClick();

            if (var == true)
            {
                //avvio il timer
                timer1.Interval = 5000;
                timer1.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            string utente = comboBox_utente.Text;
            conn.VisualizzaPreferiti(textBox_listaPreferiti, utente);
            var = true;
        }

        private void bnt_aggiungiP_Click(object sender, EventArgs e)
        {
            string pref = textBox_preferito.Text;
            string utente = comboBox_utente.Text;
            conn.AggiungiPreferito(pref, utente);
        }

        private void btn_eliminaP_Click(object sender, EventArgs e)
        {
            string pref = textBox_preferito.Text;
            string utente = comboBox_utente.Text;
            conn.EliminaPreferito(pref, utente);
        }
    }
}
