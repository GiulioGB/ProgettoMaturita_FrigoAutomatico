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
    public partial class FormUtente : UserControl
    {
        string nomeFrigo;

        public FormUtente()
        {
            InitializeComponent();
        } 

        public FormUtente(string nome)
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

      
        private void CONFERMA_Click(object sender, EventArgs e)
        {
            ConnessioneDB conn = new ConnessioneDB();
            
            //controllo che siano stati compilati i campi
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox2.SelectedIndex < 0 || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Compila tutti i campi prima di confermare ! ");
            }
            else
            {
                //controlli sulla corretteza dei tipi di dati
                if (IsInteger(textBox1.Text) == false && IsInteger(textBox2.Text) == false && IsInteger(textBox4.Text) == true && IsInteger(textBox5.Text) == true && IsInteger(textBox6.Text) == true)
                {
                    //salva l'utente
                    conn.Salva(nomeFrigo,textBox1, textBox2, comboBox2, textBox4, textBox5, textBox6);

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

        public void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox2.SelectedIndex = 0;
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            AggiungiFamiliare agg = new AggiungiFamiliare(nomeFrigo);
            Controls.Add(agg);
            agg.BringToFront();
            this.Refresh();
        }

        private void FormUtente_Load(object sender, EventArgs e)
        {

        }

        

        
        
    }
}
