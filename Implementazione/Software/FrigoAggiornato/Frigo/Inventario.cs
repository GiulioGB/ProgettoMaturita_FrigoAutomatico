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

        ConnessioneDB conn = new ConnessioneDB();
        string nomeFrigo;

        public Inventario(string nome)
        {
            nomeFrigo = nome;
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Start();
        }
       
        private void Inventario_Load(object sender, EventArgs e)
        {
            //ConnessioneDB conn = new ConnessioneDB();
            int id = conn.selectID(nomeFrigo);
            conn.ApriConnessione();
            conn.VisualizzaTutto(id,dataGridView1);
            conn.ChiudiConnessione();
            //clicco in modo automatico il bottone
            //button2.PerformClick();
            //avvio il timer
            timer1.Interval = 1000;
            timer1.Start();
        }
        /*private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
           // .PerformClick();
            button2.PerformClick();

        }*/
        private void TextBoxInventario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = conn.selectID(nomeFrigo);
            conn.ApriConnessione();
            conn.VisualizzaTutto(id, dataGridView1);
            conn.ChiudiConnessione();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            // .PerformClick();
            button2.PerformClick();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
