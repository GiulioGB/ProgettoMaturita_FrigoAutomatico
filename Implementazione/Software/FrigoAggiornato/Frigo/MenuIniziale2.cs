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
        public MenuIniziale2()
        {
            InitializeComponent();
        }

        private void Indietro_Click(object sender, EventArgs e)
        {
            MenuIniziale Menu1 = new MenuIniziale();
            Controls.Add(Menu1);
            Menu1.BringToFront();
            this.Refresh();
        }
    }
}
