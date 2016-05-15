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
    public partial class MenuIniziale2 : UserControl
    {
        string nomeFrigo;
        public MenuIniziale2(string nome)
        {
            InitializeComponent();
            nomeFrigo = nome;
        }

        private void Indietro_Click(object sender, EventArgs e)
        {
            MenuIniziale Menu1 = new MenuIniziale(nomeFrigo);
            Controls.Add(Menu1);
            Menu1.BringToFront();
            this.Refresh();
        }
    }
}
