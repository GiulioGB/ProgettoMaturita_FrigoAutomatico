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
    public partial class Inventario : UserControl
    {

        string nomeFrigo;

        public Inventario(string nome)
        {
            nomeFrigo = nome;
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ConnessioneDB conn = new ConnessioneDB();
            int id = conn.selectID(nomeFrigo);
            conn.ApriConnessione();
            conn.VisualizzaTutto(id,dataGridView1);
            conn.ChiudiConnessione();
        }

        private void TextBoxInventario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
