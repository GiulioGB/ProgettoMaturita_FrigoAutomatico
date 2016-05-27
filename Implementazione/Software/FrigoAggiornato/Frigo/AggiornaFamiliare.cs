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
    public partial class AggiornaFamiliare : UserControl
    {
        string nomeFrigo;
        ConnessioneDB conn = new ConnessioneDB();

        public AggiornaFamiliare(string nome)
        {
            InitializeComponent();
            nomeFrigo = nome;
        }

        //metodo di controllo se siamo in presenza di una stringa o di un intero
        bool IsInteger(string text)
        {
            try
            {
                int i = Convert.ToInt32(text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Reset()
        {
            comboBox2.SelectedIndex = 0;
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void AGGIORNA_Click(object sender, EventArgs e)
        {
            

            //controllo che siano stati compilati i campi
            if (comboBox1.SelectedIndex < 0|| comboBox2.SelectedIndex < 0 || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Compila tutti i campi prima di confermare ! ");
            }
            else
            {
                //controlli sulla corretteza dei tipi di dati
                if (IsInteger(textBox4.Text) == true && IsInteger(textBox5.Text) == true && IsInteger(textBox6.Text) == true)
                {
                    //aggiorna l'utente
                    conn.Aggiorna(nomeFrigo, comboBox1, comboBox2, textBox4, textBox5, textBox6);

                    //pulisco il "form"
                    Reset();

                    //torno indietro
                    AggiungiFamiliare agg = new AggiungiFamiliare(nomeFrigo);
                    Controls.Add(agg);
                    agg.BringToFront();
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("ERRORI NELLA COMPILAZIONE! suggerimenti: controlla di aver inserito nel modo corretto i dati richiesti. Attenzione non sono accettati i numeri con a virgola, qualora ci fossero approssimare il valore per difetto");
                }
            }
        }

        private void Indietro_Click(object sender, EventArgs e)
        {
            //torno indietro
            EliminaFamiliare El = new EliminaFamiliare(nomeFrigo);
            Controls.Add(El);
            El.BringToFront();
            this.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AggiornaFamiliare_Load(object sender, EventArgs e)
        {
            conn.riempi(comboBox1,nomeFrigo);
        }
    }
}
