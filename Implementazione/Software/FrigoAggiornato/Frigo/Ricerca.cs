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
    public partial class Ricerca : UserControl
    {
        string nomeFrigo;
        ConnessioneDB conn = new ConnessioneDB();
        public Ricerca()
        {
            InitializeComponent();
        }

        public Ricerca(string nome)
        {
            InitializeComponent();
            nomeFrigo = nome;
        }
       
        private void bRicerca_Click(object sender, EventArgs e)
        {
            
            if (conn.ricerca(nomeCercato.Text, conn.selectID(nomeFrigo), dataGridView1) == true)
            {
                dataGridView1.Visible = true;
                nomeCercato.Visible = false;
                bRicerca.Visible = false;
                label1.Visible = false;
            }else
            {

                //messagebox

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bMenu_Click(object sender, EventArgs e)
        {
            MenuIniziale Menu = new MenuIniziale(nomeFrigo);
            Controls.Add(Menu);
            Menu.BringToFront();
            this.Refresh();
        }
    }
}
