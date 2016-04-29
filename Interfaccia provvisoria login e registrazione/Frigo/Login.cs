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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registrazione_login_Click(object sender, EventArgs e)
        {
            Registrazione reg=new Registrazione();
            Controls.Add(reg);
            reg.BringToFront();
            this.Refresh();
            
        }
    }
}
