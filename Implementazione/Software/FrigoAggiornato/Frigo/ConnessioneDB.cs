using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace Frigo
{
    class ConnessioneDB
    {
        MySqlConnection mcon = new MySqlConnection("server = localhost; user id = root; database = prova2; password= '';");
        MySqlCommand mcd;
        MySqlDataReader mdr;

        //apro la connessione
        public void ApriConnessione()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }

        //Chiudo la connessione
        public void ChiudiConnessione()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }

        //Eseguo l'inserimento
        public void ExecuteQuery(string q)
        {
            ApriConnessione();
            try
            {
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Query Eseguita");
                }
                else
                {
                    //MessageBox.Show("Query Non Eseguita");
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

        //Leggi Utenti
        public void leggiUtenti(Button primo, Button secondo, Button terzo, Button quarto, Button quinto, Button sesto)
        {
            ApriConnessione();

            string s = "SELECT nome FROM utenti_frigo WHERE 1";

            mcd = new MySqlCommand(s, mcon);
            mdr = mcd.ExecuteReader();
            int i = 1;
            while (mdr.Read())
            {
                if (i == 1)
                {
                    primo.Text = mdr["nome"].ToString();
                    primo.BackColor = Color.Yellow;
                    primo.FlatAppearance.BorderColor = Color.OrangeRed;
                    primo.BackgroundImage = null;
                }
                else if (i == 2)
                {
                    secondo.Text = mdr["nome"].ToString();
                    secondo.BackColor = Color.Yellow;
                    secondo.FlatAppearance.BorderColor = Color.OrangeRed;
                    secondo.BackgroundImage = null;
                }
                else if (i == 3)
                {
                    terzo.Text = mdr["nome"].ToString();
                    terzo.BackColor = Color.Yellow;
                    terzo.FlatAppearance.BorderColor = Color.OrangeRed;
                    terzo.BackgroundImage = null;
                }
                else if (i == 4)
                {
                    quarto.Text = mdr["nome"].ToString();
                    quarto.BackColor = Color.Yellow;
                    quarto.FlatAppearance.BorderColor = Color.OrangeRed;
                    quarto.BackgroundImage = null;
                }
                else if (i == 5)
                {
                    quinto.Text = mdr["nome"].ToString();
                    quinto.BackColor = Color.Yellow;
                    quinto.FlatAppearance.BorderColor = Color.OrangeRed;
                    quinto.BackgroundImage = null;
                }
                else if (i == 6)
                {
                    sesto.Text = mdr["nome"].ToString();
                    sesto.BackColor = Color.Yellow;
                    sesto.FlatAppearance.BorderColor = Color.OrangeRed;
                    sesto.BackgroundImage = null;
                }
                i++;
            }

            ChiudiConnessione();
        }
    
        //leggi Frigo
        public string leggiFrigo(string nome)
        {
            ApriConnessione();

            string q = "SELECT Username FROM utenti";

            mcd = new MySqlCommand(q, mcon);
            mdr = mcd.ExecuteReader();

            string controllo = "";

            while (mdr.Read())
            {
                if (nome == mdr["Username"].ToString())
                {
                    controllo = "si";
                    break;
                }
                else
                {
                    controllo = "no";
                }
            }

            //if (controllo == "si")
            //{
            //    MessageBox.Show("Login Efettuata");
            //}
            //else
            //{
            //    MessageBox.Show("Questo frigo non è presente nei nostri DataBase, correggi il nome immesso oppure effettua la registrazione");
            //}

            ChiudiConnessione();

            return controllo;
        }

        //Verifica Password
        public string Controlla(string nome,string password)
        {
            string controlla ="";

            ApriConnessione();

            string q = "SELECT Password from utenti WHERE Username = '"+nome+"'";

            mcd = new MySqlCommand(q, mcon);
            mdr = mcd.ExecuteReader();

            MD5 md5 = MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);

            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("x2"));

            }

            
            while (mdr.Read())
            {
                if (sb.ToString() == mdr["Password"].ToString())
                {
                    controlla = "si";
                    break;
                }
                else
                {
                    controlla = "no";
                }
            }


            ChiudiConnessione();

            return controlla;
        }
        
        //aggiungi prodotto 2
        public void AggiuntaManuale(string nome)
        {
            string q = "INSERT INTO prodotti (Nome,dataScadenza) values('"+nome+"','0000-00-00')";
            ExecuteQuery(q);
        }

        //elimina prodotto 2
        public void EliminaManuale(string nome)
        {
            string q = "DELETE FROM prodotti WHERE nome='" + nome + "'";
            ExecuteQuery(q);
        }
        //SalvaUtenti
        public void Salva(TextBox prima, TextBox seconda, ComboBox terza , TextBox quarta, TextBox quinta, TextBox sesta)
        {
            string q = "INSERT INTO utenti_frigo (nome,cognome,sesso,peso,altezza,eta) values('" + prima.Text + "','" + seconda.Text + "','" + terza.SelectedItem.ToString() + "'," + Int32.Parse(quarta.Text) + "," + Int32.Parse(quinta.Text) + "," + Int32.Parse(sesta.Text) + ");";
                
            ExecuteQuery(q);

            ChiudiConnessione();
        }

        //Salva frigo
        public bool SalvaF(TextBox prima, TextBox seconda, TextBox terza)
        {
            if (leggiFrigo(prima.Text) == "no")
            {
                if (seconda.Text == terza.Text && seconda.Text!="")
                {
                    MD5 md5 = MD5.Create();

                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(seconda.Text);

                    byte[] hash = md5.ComputeHash(inputBytes);

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {

                        sb.Append(hash[i].ToString("x2"));

                    }

                    string q = "INSERT INTO utenti (Username,Password) values('" + prima.Text + "','" + sb + "');";

                    ExecuteQuery(q);

                    ChiudiConnessione();
                    return true;
                }
                else
                {
                    MessageBox.Show("Le password non corrispondono o sono presenti campi vuoti ");

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Il frigo esiste già");
                return false;
            }
        }
    }
}