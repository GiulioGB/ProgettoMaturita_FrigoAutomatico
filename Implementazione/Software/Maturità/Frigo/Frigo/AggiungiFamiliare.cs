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
    public partial class AggiungiFamiliare : UserControl
    {
        ConnessioneDB conn = new ConnessioneDB();

        public AggiungiFamiliare()
        {
            InitializeComponent();

        }

        private void AggiungiFamiliare_Load(object sender, EventArgs e)
        {
            //carico i familiari aggiunti in precedenza nel DB
            conn.leggiUtenti(AggiungiUtente1, AggiungiUtente2, AggiungiUtente3, AggiungiUtente4, AggiungiUtente5, AggiungiUtente6);
            //---
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MenuIniziale quintaSchermata = new MenuIniziale();
            Controls.Add(quintaSchermata);
            quintaSchermata.BringToFront();
            this.Refresh();
        }

        private void AggiungiUtente1_Click(object sender, EventArgs e)
        {
            FormUtente quartaSchermata = new FormUtente();
            Controls.Add(quartaSchermata);
            quartaSchermata.BringToFront();
            this.Refresh();
        }

        private void AggiungiUtente2_Click(object sender, EventArgs e)
        {
            FormUtente quartaSchermata = new FormUtente();
            Controls.Add(quartaSchermata);
            quartaSchermata.BringToFront();
            this.Refresh();
        }

        private void AggiungiUtente3_Click(object sender, EventArgs e)
        {
            FormUtente quartaSchermata = new FormUtente();
            Controls.Add(quartaSchermata);
            quartaSchermata.BringToFront();
            this.Refresh();
        }

        private void AggiungiUtente4_Click(object sender, EventArgs e)
        {
            FormUtente quartaSchermata = new FormUtente();
            Controls.Add(quartaSchermata);
            quartaSchermata.BringToFront();
            this.Refresh();
        }

        private void AggiungiUtente5_Click(object sender, EventArgs e)
        {
            FormUtente quartaSchermata = new FormUtente();
            Controls.Add(quartaSchermata);
            quartaSchermata.BringToFront();
            this.Refresh();
        }

        private void AggiungiUtente6_Click(object sender, EventArgs e)
        {
            FormUtente quartaSchermata = new FormUtente();
            Controls.Add(quartaSchermata);
            quartaSchermata.BringToFront();
            this.Refresh();
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            EliminaFamiliare el = new EliminaFamiliare();
            Controls.Add(el);
            el.BringToFront();
            this.Refresh();
        }
    }
}
