using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Frigo
{
    public partial class Form1 : Form
    {

        MySqlConnection mcon = new MySqlConnection("server = localhost; user id = root; database = prova2; password= '';");
        MySqlCommand mcd;
        MySqlDataReader mdr;
        string s;

        public Form1()
        {
            InitializeComponent();

            ApriConnessione();
        }

        public void ApriConnessione()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }

        public void ChiudiConnessione()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }

        public void ExecuteQuery(string q)
        {
            try
            {
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Eseguita");
                }
                else
                {
                    MessageBox.Show("Query Non Eseguita");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mcon.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApriConnessione();

            s = "SELECT count(*) FROM utenti_frigo WHERE 1";

            MySqlCommand query = new MySqlCommand(s, mcon);
            MySqlDataReader reader = query.ExecuteReader();
            int i=1;
            while(reader.Read())
            {
                if(i==1)
                {
                    AggiungiUtente1.Text = reader["nome"].ToString(); ;
                }
                else if(i==2)
                {
                    AggiungiUtente2.Text = reader["nome"].ToString(); ;
                }
                else if(i==3)
                {
                    AggiungiUtente3.Text = reader["nome"].ToString(); ;
                }
                else if (i == 4)
                {
                    AggiungiUtente4.Text = reader["nome"].ToString(); ;
                }
                else if (i == 5)
                {
                    AggiungiUtente5.Text = reader["nome"].ToString(); ;
                }
                else if (i == 6)
                {
                    AggiungiUtente6.Text = reader["nome"].ToString(); ;
                }
                i++;
            }


            ChiudiConnessione();

        }

        private void Aggiungi_Click(object sender, EventArgs e)//AGGIUNGI
        {

        }

        private void Elimina_Click(object sender, EventArgs e)//ELIMINA
        {

        }

        private void Dieta_Click(object sender, EventArgs e)//DIETA
        {
            Aggiungi.Visible = false;
            Dieta.Visible = false;
            Elimina.Visible = false;
            Ricette.Visible = false;
            Cerca.Visible = false;
            Visualizza.Visible = false;
            AggiungiUtente1.Visible = true;
            AggiungiUtente2.Visible = true;
            AggiungiUtente3.Visible = true;
            AggiungiUtente4.Visible = true;
            AggiungiUtente5.Visible = true;
            AggiungiUtente6.Visible = true;
        }

        private void Ricette_Click(object sender, EventArgs e)//RICETTE
        {

        }

        private void Cerca_Click(object sender, EventArgs e)//CERCA
        {

        }

        private void Visualizza_Click(object sender, EventArgs e)//VISUALIZZA
        {

        }

        private void AggiungiUtente1_Click(object sender, EventArgs e)//AGGIUNGI ADX
        {
            Aggiungi.Visible = false;
            Dieta.Visible = false;
            Elimina.Visible = false;
            Ricette.Visible = false;
            Cerca.Visible = false;
            Visualizza.Visible = false;
            AggiungiUtente1.Visible = false;
            AggiungiUtente2.Visible = false;
            AggiungiUtente3.Visible = false;
            AggiungiUtente4.Visible = false;
            AggiungiUtente5.Visible = false;
            AggiungiUtente6.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            ConfermaR.Visible = true;


        }

        private void AggiungiUtente2_Click(object sender, EventArgs e)//AGGIUNGI BDX
        {

        }

        private void AggiungiUtente3_Click(object sender, EventArgs e)//AGGIUNGIAC
        {

        }

        private void AggiungiUtente4_Click(object sender, EventArgs e)//AGGIUNGIBC
        {

        }

        private void AggiungiUtente5_Click(object sender, EventArgs e)//AGGIUNGIASX
        {

        }

        private void AggiungiUtente6_Click(object sender, EventArgs e)//AGGIUNGIBSX
        {

        }

        private void ConfermaR_Click(object sender, EventArgs e)//CONFERMA REGISTRAZIONE
        {
            //controllo che siano stati compilati i campi
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Compila tutti i campi prima di confermare ! ");
            }
            else
            {

                Aggiungi.Visible = true;
                Dieta.Visible = true;
                Elimina.Visible = true;
                Ricette.Visible = true;
                Cerca.Visible = true;
                Visualizza.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                ConfermaR.Visible = false;


                //salva l'utente
                Salva();

            }
            
        }

        private void Salva()
        {
            //Scrivo la query
            string q = "INSERT INTO utenti_frigo (nome,cognome,sesso,peso,altezza,eta) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," + Int32.Parse(textBox4.Text) + "," + Int32.Parse(textBox5.Text) + ","+Int32.Parse(textBox6.Text)+");";
            
            ExecuteQuery(q);

            ChiudiConnessione();
        }
    }
}
