using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using WebCam_Capture;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        MySqlConnection mcon = new MySqlConnection("server = localhost; user id = root; database = prova2; password= '';");
        MySqlCommand mcd;

        public Form1()
        {
            InitializeComponent();

            ApriConnessione();
        }

        private void Inserisci_Click(object sender, EventArgs e)
        {
            string nome = NomeProdotto.Text;
            string scad = scadenza.Text;
            //Scrivo la query
            string q = "INSERT INTO prodotti (Nome,dataScadenza) values('"+NomeProdotto.Text+"','"+scadenza.Text+"');";
            ExecuteQuery(q);

            ChiudiConnessione();
        }

        public void ApriConnessione()
        {
            if(mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }
       
        public void ChiudiConnessione()
        {
            if(mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }

        public void ExecuteQuery(string q)
        {
            try
            {
                mcd = new MySqlCommand(q,mcon);
                if (mcd.ExecuteNonQuery() ==1)
                {
                    MessageBox.Show("Query Eseguita");
                }
                else
                {
                    MessageBox.Show("Query Non Eseguita");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mcon.Close();
            }
        }
    }
}
