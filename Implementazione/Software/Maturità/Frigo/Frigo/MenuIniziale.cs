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

        public MenuIniziale()
        {
            InitializeComponent();
        }


        private void Aggiungi_Click(object sender, EventArgs e)
        {
            WebCam sestaSchermata = new WebCam();
            Controls.Add(sestaSchermata);
            sestaSchermata.BringToFront();
            this.Refresh();
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            WebCamEl el = new WebCamEl();
            Controls.Add(el);
            el.BringToFront();
            this.Refresh();
        }
    }
}
