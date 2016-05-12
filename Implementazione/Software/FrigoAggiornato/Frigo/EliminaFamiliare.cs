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
        public EliminaFamiliare()
        {
            InitializeComponent();
        }

        private void Annulla_Click(object sender, EventArgs e)
        {
            AggiungiFamiliare agg = new AggiungiFamiliare();
            Controls.Add(agg);
            agg.BringToFront();
            this.Refresh();
        }

        ConnessioneDB conn = new ConnessioneDB();
        private void Elimina_Click(object sender, EventArgs e)
        {
            conn.ApriConnessione();
            string q = "DELETE FROM utenti_frigo WHERE Nome = '" + eliminato.Text + "'";
            conn.ExecuteQuery(q);

            conn.ChiudiConnessione();
            AggiungiFamiliare agg = new AggiungiFamiliare();
            Controls.Add(agg);
            agg.BringToFront();
            this.Refresh();
        }
    }
}
