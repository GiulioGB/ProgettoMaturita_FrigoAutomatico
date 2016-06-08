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
    public partial class Preferiti : UserControl
    {
        string nomeFrigo;
        ConnessioneDB conn = new ConnessioneDB();
        string var2  = "";

        bool var = false;
        public Preferiti(string nome)
        {
            InitializeComponent();
            nomeFrigo = nome;
            dataGridView1.Visible = false;
        }

        public void Preferiti_Load(object sender, EventArgs e)
        {
            //clicco in modo automatico il bottone
            //start.PerformClick();

            if (var == true)
            {
                //avvio il timer
                //timer1.Interval = 5000;
                //timer1.Start();
            }
        }

        //Torno al Menu
        private void button1_Click(object sender, EventArgs e)
        {
            MenuIniziale men = new MenuIniziale(nomeFrigo);
            Controls.Add(men);
            men.BringToFront();
            this.Refresh();

        }

        //aggiungi
        private void button3_Click(object sender, EventArgs e)
        {
            //mostro tutti i pulsanti relativi alla funzione
            button6.Visible = true;
            Agg_Conf.Visible = true;
            comboBox1.Visible = true;
            textBox1.Visible = true;
            button5.Visible = true;
            //nascondo cio che non mi serve
            button4.Visible = false;
            button3.Visible = false;
        }

        private void Agg_Conf_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1 && textBox1.Text != "")
            {
                if (var2 == "elimina")
                {


                    //elimina
                    var2 = "";
                    //elimina
                    conn.EliminaPreferito(textBox1.Text, comboBox1.SelectedItem.ToString(), conn.selectID(nomeFrigo));
                    comboBox1.SelectedIndex = -1;
                    textBox1.Text = "";

                }
                else
                {
                    //Da aggiungere i controlli...
                    //aggiungi preferito
                    conn.AggiungiPreferito(textBox1.Text, comboBox1.SelectedItem.ToString(), conn.selectID(nomeFrigo));
                    comboBox1.SelectedIndex = -1;
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Impossibile proseguire, compilare tutti i campi presenti", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //carico i familiari nella combobox
            conn.ComboBoxUtenti(comboBox1, conn.selectID(nomeFrigo));

            label1.Visible = true;
            label3.Visible = true;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //nascondo
            button6.Visible = false;
            Agg_Conf.Visible = false;
            comboBox1.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
            //mostro
            button4.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            label1.Visible = false;
            label3.Visible = false;
            dataGridView1.Visible = false;
            //resetto
            textBox1.Text = "";
            comboBox1.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var2 = "elimina";

            //mostro tutti i pulsanti relativi alla funzione
            button6.Visible = true;
            Agg_Conf.Visible = true;
            comboBox1.Visible = true;
            textBox1.Visible = true;
            button5.Visible = true;
            //nascondo cio che non mi serve
            button4.Visible = false;
            button3.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //visualizza
            Agg_Conf.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            button5.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button6.Visible = true;
            comboBox1.Visible = false;
            label1.Visible = false;
            dataGridView1.Visible = true;
            //carico la data grid view
            conn.VisualizzaPreferiti(conn.selectID(nomeFrigo), dataGridView1);
        }

                
    }
}
