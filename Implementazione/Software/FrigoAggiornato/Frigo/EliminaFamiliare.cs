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
    public partial class EliminaFamiliare : UserControl
    {
        string nomeFrigo;
        ConnessioneDB conn = new ConnessioneDB();

        public EliminaFamiliare()
        {
            InitializeComponent();
        }

        public EliminaFamiliare(string nome)
        {
            InitializeComponent();
            nomeFrigo = nome;
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            AggiungiFamiliare agg = new AggiungiFamiliare(nomeFrigo);
            Controls.Add(agg);
            agg.BringToFront();
            this.Refresh();
        }

        
        private void Elimina_Click(object sender, EventArgs e)
        {
            //verifico che l'utente inserito sia presente
            if (conn.verifica(conn.selectID(nomeFrigo), eliminato.Text) != false)
            {
                //query per eliminare l'utente verificato il nome e l'appartenenza al frigo
                string q2 = "DELETE FROM familiare WHERE Nome = '" + eliminato.Text + "' AND IDFrigo = " + conn.selectID(nomeFrigo) + "";
                conn.ExecuteQuery(q2);

                AggiungiFamiliare agg = new AggiungiFamiliare(nomeFrigo);
                Controls.Add(agg);
                agg.BringToFront();
                this.Refresh();
            }
            
        }

        //Aggiorna
        private void button1_Click(object sender, EventArgs e)
        {
            AggiornaFamiliare aggiorna = new AggiornaFamiliare(nomeFrigo);
            Controls.Add(aggiorna);
            aggiorna.BringToFront();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = false;
            Elimina.Visible = true;
            label1.Visible = true;
            eliminato.Visible = true;
            Indietro.Visible = false;
            IndietroEl.Visible = true;
        }

        private void IndietroEl_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
            Elimina.Visible = false;
            label1.Visible = false;
            eliminato.Visible = false;
            Indietro.Visible = true;
            IndietroEl.Visible = false;
        }
    }
}
