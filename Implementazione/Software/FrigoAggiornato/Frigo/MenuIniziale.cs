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
    public partial class MenuIniziale : UserControl
    {
        string nomeFrigo;
        public MenuIniziale(string nome)
        {
            InitializeComponent();
            nomeFrigo = nome;
        }


        private void Aggiungi_Click(object sender, EventArgs e)
        {
            WebCam sestaSchermata = new WebCam(nomeFrigo);
            Controls.Add(sestaSchermata);
            sestaSchermata.BringToFront();
            this.Refresh();
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            WebCamEl el = new WebCamEl(nomeFrigo);
            Controls.Add(el);
            el.BringToFront();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AggiungiFamiliare fam = new AggiungiFamiliare(nomeFrigo);
            Controls.Add(fam);
            fam.BringToFront();
            this.Refresh();
        }

        private void Avanti_Click(object sender, EventArgs e)
        {
            MenuIniziale2 Menu2 = new MenuIniziale2(nomeFrigo);
            Controls.Add(Menu2);
            Menu2.BringToFront();
            this.Refresh();
        }

        private void MenuIniziale_Load(object sender, EventArgs e)
        {

        }

        private void Inventario_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario(nomeFrigo);
            Controls.Add(inv);
            inv.BringToFront();
            this.Refresh();
        }

        private void Ricette_Click(object sender, EventArgs e)
        {
            Ricette ric = new Ricette();
            Controls.Add(ric);
            ric.BringToFront();
            this.Refresh();
        }

        private void Cerca_Click(object sender, EventArgs e)
        {
            Ricerca ric = new Ricerca(nomeFrigo);
            Controls.Add(ric);
            ric.BringToFront();
            this.Refresh();
        }

        private void Preferiti_Click(object sender, EventArgs e)
        {
            Preferiti pref = new Preferiti();
            Controls.Add(pref);
            pref.BringToFront();
            this.Refresh();
        }
    }
}