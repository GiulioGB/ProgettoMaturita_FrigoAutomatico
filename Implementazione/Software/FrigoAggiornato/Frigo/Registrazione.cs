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
    public partial class Registrazione : UserControl
    {
        ConnessioneDB conn = new ConnessioneDB();
        public Registrazione()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            Controls.Add(log);
            log.BringToFront();
            this.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.SalvaF(textBox1, textBox2, textBox3) == true)
            {
                Login log = new Login();
                Controls.Add(log);
                log.BringToFront();
                this.Refresh();
            }
        }

        private void Registrazione_Load(object sender, EventArgs e)
        {

        }
    }
}
