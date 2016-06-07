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
        String FrigoScelto;

        public AggiungiFamiliare()
        {
            InitializeComponent();

        }

        public AggiungiFamiliare(string nomeFrigo)
        {
            InitializeComponent();
            FrigoScelto = nomeFrigo;
        }

        private void AggiungiFamiliare_Load(object sender, EventArgs e)
        {
            //carico i familiari aggiunti in precedenza nel DB
            conn.leggiUtenti(FrigoScelto,AggiungiUtente1, AggiungiUtente2, AggiungiUtente3, AggiungiUtente4, AggiungiUtente5, AggiungiUtente6);
            //---
            
            //non faccio vedere i pulsanti vuoti
            if(AggiungiUtente2.Text=="")
            {
                AggiungiUtente2.Visible = false;
            }
            if(AggiungiUtente3.Text == "")
            {
                AggiungiUtente3.Visible = false;
            }
            if (AggiungiUtente4.Text == "")
            {
                AggiungiUtente4.Visible = false;
            }
            if (AggiungiUtente5.Text == "")
            {
                AggiungiUtente5.Visible = false;
            }
            if (AggiungiUtente6.Text == "")
            {
                AggiungiUtente6.Visible = false;
            }
            //do la possibilità man mano di aggiungerli
            if(AggiungiUtente1.Text != "")
            {
                AggiungiUtente2.Visible = true;
            }
            if (AggiungiUtente2.Text != "")
            {
                AggiungiUtente3.Visible = true;
            }
            if (AggiungiUtente3.Text != "")
            {
                AggiungiUtente4.Visible = true;
            }
            if (AggiungiUtente4.Text != "")
            {
                AggiungiUtente5.Visible = true;
            }
            if (AggiungiUtente5.Text != "")
            {
                AggiungiUtente6.Visible = true;
            }
            //---
        }

        private void Menu_Click(object sender, EventArgs e)
        {
           if(AggiungiUtente1.Text == "")
           {
               MessageBox.Show("Inserire almeno un familiare", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
           else
           {
               MenuIniziale quintaSchermata = new MenuIniziale(FrigoScelto);
               Controls.Add(quintaSchermata);
               quintaSchermata.BringToFront();
               this.Refresh();
           }
            
        }

        private void AggiungiUtente1_Click(object sender, EventArgs e)
        {
            if (AggiungiUtente1.Text == "")
            {
                FormUtente quartaSchermata = new FormUtente(FrigoScelto);
                Controls.Add(quartaSchermata);
                quartaSchermata.BringToFront();
                this.Refresh();
            }
        }

        private void AggiungiUtente2_Click(object sender, EventArgs e)
        {
            if (AggiungiUtente2.Text == "")
            {
                FormUtente quartaSchermata = new FormUtente(FrigoScelto);
                Controls.Add(quartaSchermata);
                quartaSchermata.BringToFront();
                this.Refresh();
            }
        }

        private void AggiungiUtente3_Click(object sender, EventArgs e)
        {
            if (AggiungiUtente3.Text == "")
            {
                FormUtente quartaSchermata = new FormUtente(FrigoScelto);
                Controls.Add(quartaSchermata);
                quartaSchermata.BringToFront();
                this.Refresh();
            }
        }

        private void AggiungiUtente4_Click(object sender, EventArgs e)
        {
            if (AggiungiUtente4.Text == "")
            {
                FormUtente quartaSchermata = new FormUtente(FrigoScelto);
                Controls.Add(quartaSchermata);
                quartaSchermata.BringToFront();
                this.Refresh();
            }
            
        }

        private void AggiungiUtente5_Click(object sender, EventArgs e)
        {
            if(AggiungiUtente5.Text == "")
            {
                FormUtente quartaSchermata = new FormUtente(FrigoScelto);
                Controls.Add(quartaSchermata);
                quartaSchermata.BringToFront();
                this.Refresh();
            }
            
        }

        private void AggiungiUtente6_Click(object sender, EventArgs e)
        {
            if (AggiungiUtente6.Text == "")
            {
                FormUtente quartaSchermata = new FormUtente(FrigoScelto);
                Controls.Add(quartaSchermata);
                quartaSchermata.BringToFront();
                this.Refresh();
            }

        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            EliminaFamiliare el = new EliminaFamiliare(FrigoScelto);
            Controls.Add(el);
            el.BringToFront();
            this.Refresh();
        }
    }
}
