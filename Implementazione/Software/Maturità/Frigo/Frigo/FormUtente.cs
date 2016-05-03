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
        public FormUtente()
        {
            InitializeComponent();
        }

        private void CONFERMA_Click(object sender, EventArgs e)
        {
            ConnessioneDB conn = new ConnessioneDB();
            
            //controllo che siano stati compilati i campi
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Compila tutti i campi prima di confermare ! ");
            }
            else
            {
                //salva l'utente
                conn.Salva(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6);
                
                //pulisco il "form"
                Reset();
                
                //torno indietro
                AggiungiFamiliare agg = new AggiungiFamiliare();
                Controls.Add(agg);
                agg.BringToFront();
                this.Refresh();

            }
            
        }

        public void Reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            AggiungiFamiliare agg = new AggiungiFamiliare();
            Controls.Add(agg);
            agg.BringToFront();
            this.Refresh();
        }

        
        
    }
}
