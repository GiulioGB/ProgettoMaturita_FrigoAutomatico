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
//using System.Data.SqlServerCe;
namespace Frigo
{
    class ConnessioneDB
    {
        //---
        //-INIZIO GESTIONE CONNESSIONE
        //--- 
        
        MySqlConnection mcon = new MySqlConnection("server = localhost; user id = root; database = data_frigo; password= '';");
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

        //---
        //-FINE GESTIONE CONNESSIONE
        //---

        //---
        //-INIZIO ESEGUTORE QUERY
        //---

        //Eseguo la query
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

        //---
        //-FINE ESEGUTORE QUERY
        //---

        //---
        //-INIZIO GESTIONE UTENTI
        //---

        //Leggi Utenti
        public void leggiUtenti(string FrigoScelto,Button primo, Button secondo, Button terzo, Button quarto, Button quinto, Button sesto)
        {
            ApriConnessione();

            string s = "SELECT Nome FROM familiare JOIN frigo ON familiare.IDFrigo = frigo.ID WHERE frigo.Username = '"+FrigoScelto+"';";

            mcd = new MySqlCommand(s, mcon);
            mdr = mcd.ExecuteReader();
            int i = 1;
            while (mdr.Read())
            {
                if (i == 1)
                {
                    primo.Text = mdr["Nome"].ToString();
                    primo.BackColor = Color.Yellow;
                    primo.FlatAppearance.BorderColor = Color.OrangeRed;
                    primo.BackgroundImage = null;
                }
                else if (i == 2)
                {
                    secondo.Text = mdr["Nome"].ToString();
                    secondo.BackColor = Color.Yellow;
                    secondo.FlatAppearance.BorderColor = Color.OrangeRed;
                    secondo.BackgroundImage = null;
                }
                else if (i == 3)
                {
                    terzo.Text = mdr["Nome"].ToString();
                    terzo.BackColor = Color.Yellow;
                    terzo.FlatAppearance.BorderColor = Color.OrangeRed;
                    terzo.BackgroundImage = null;
                }
                else if (i == 4)
                {
                    quarto.Text = mdr["Nome"].ToString();
                    quarto.BackColor = Color.Yellow;
                    quarto.FlatAppearance.BorderColor = Color.OrangeRed;
                    quarto.BackgroundImage = null;
                }
                else if (i == 5)
                {
                    quinto.Text = mdr["Nome"].ToString();
                    quinto.BackColor = Color.Yellow;
                    quinto.FlatAppearance.BorderColor = Color.OrangeRed;
                    quinto.BackgroundImage = null;
                }
                else if (i == 6)
                {
                    sesto.Text = mdr["Nome"].ToString();
                    sesto.BackColor = Color.Yellow;
                    sesto.FlatAppearance.BorderColor = Color.OrangeRed;
                    sesto.BackgroundImage = null;
                }
                i++;
            }

            ChiudiConnessione();
        }
    
		//Riempi Combo
        public void riempi(ComboBox prima,string nomeFrigo)
        {
            

            string query = "SELECT Nome FROM familiare WHERE IDFrigo = "+selectID(nomeFrigo)+"";
            ApriConnessione();
            mcd = new MySqlCommand(query, mcon);
            mdr = mcd.ExecuteReader();

            while(mdr.Read())
            {
                prima.Items.Add(mdr["Nome"].ToString());
            }

            ChiudiConnessione();
        }
		
        //Verifica presenza utente da eliminare nell' elenco degli utenti di quel frigo
        public bool verifica(int id, string daEliminare)
        {
            ApriConnessione();

            bool sentinella = false;

            string s = "SELECT Nome FROM familiare WHERE IDFrigo = "+id+"";
            /*IDFrigo = '"+selectID(nomeFrigo).ToString()+"'*/
            
            mcd = new MySqlCommand(s, mcon);
            mdr = mcd.ExecuteReader();
            
            while (mdr.Read())
            {
                if (daEliminare == mdr["Nome"].ToString())
                {
                    sentinella = true;
                    break;
                }
            }

            ChiudiConnessione();

            if(sentinella == false)
            {
                MessageBox.Show("Non è stato trovato nessun familiare con il nome indicato, controlla di aver scritto correttamente!");
            }

            return sentinella;
        }

        //SalvaUtenti
        public void Salva(string nomeFrigo, TextBox prima, TextBox seconda, ComboBox terza, TextBox quarta, TextBox quinta, TextBox sesta)
        {
            string q = "INSERT INTO familiare (Nome,Cognome,Sesso,Peso,Altezza,Eta,IDFrigo) values('" + prima.Text + "','" + seconda.Text + "','" + terza.SelectedItem.ToString() + "'," + Int32.Parse(quarta.Text) + "," + Int32.Parse(quinta.Text) + "," + Int32.Parse(sesta.Text) + "," + selectID(nomeFrigo) + ");";

            ExecuteQuery(q);

            ChiudiConnessione();
        }
		
		//Aggiorna Utente
        public void Aggiorna(string nomeFrigo,ComboBox prima, ComboBox seconda, TextBox quarta, TextBox quinta, TextBox sesta)
        {
            string q = "UPDATE familiare SET Sesso ='" + seconda.SelectedItem.ToString() + "',Peso = " + Int32.Parse(quarta.Text) + ",Altezza = " + Int32.Parse(quinta.Text) + ", Eta = " + Int32.Parse(sesta.Text) + ", IDFrigo = " + selectID(nomeFrigo) + " WHERE Nome = '" + prima.SelectedItem.ToString() + "' AND IDFrigo = " + selectID(nomeFrigo) + ";";

            ExecuteQuery(q);

            ChiudiConnessione();
        }

        //---
        //-FINE GESTIONE UTENTI
        //---

        //---
        //-INIZIO GESTIONE FRIGO
        //---

        //select ID frigo
        public int selectID(string nomeFrigo)
        {
            ApriConnessione();

            int id = 0;
            string s = "SELECT ID FROM frigo WHERE Username = '"+nomeFrigo+"'";
            mcd = new MySqlCommand(s, mcon);
            mdr = mcd.ExecuteReader();
            while(mdr.Read())
            {
                id = Int32.Parse(mdr["ID"].ToString());
            }
            
            ChiudiConnessione();
            return id;
        }
        
        //leggi Frigo
        public string leggiFrigo(string nome)
        {
            ApriConnessione();
            string q = "SELECT Username FROM frigo";

            mcd = new MySqlCommand(q, mcon);
            mdr = mcd.ExecuteReader();

            string controllo = "no";

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

            string q = "SELECT Password from frigo WHERE Username = '"+nome+"'";

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

        //Salva frigo
        public bool SalvaF(TextBox prima, TextBox seconda, TextBox terza)
        {
            if (leggiFrigo(prima.Text) == "no")
            {
                if (seconda.Text == terza.Text && seconda.Text != "")
                {
                    MD5 md5 = MD5.Create();

                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(seconda.Text);

                    byte[] hash = md5.ComputeHash(inputBytes);

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < hash.Length; i++)
                    {

                        sb.Append(hash[i].ToString("x2"));

                    }

                    string q = "INSERT INTO frigo (Username,Password) values('" + prima.Text + "','" + sb + "');";

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

        //---
        //-FINE GESTIONE FRIGO
        //---

        //---
        //-INIZIO GESTIONE PRODOTTI
        //---

        //aggiungi prodotto 2
        public void AggiuntaManuale(string nome,int IDFrigo)
        {
            VerificaAlimento(nome);

            ApriConnessione();

            string query = "SELECT NomeAlimento,Quantita FROM prodotto WHERE NomeAlimento ='"+nome+"' AND IDFrigo = '"+IDFrigo+"'";
            mcd = new MySqlCommand(query, mcon);
            mdr = mcd.ExecuteReader();

            
            if(mdr.Read())
            {
                string q = mdr["Quantita"].ToString();
                int nuovaQ = Int32.Parse(q);
                nuovaQ++;
                q = nuovaQ.ToString();
            
                ChiudiConnessione();

                string update = "UPDATE prodotto SET Quantita = '"+q+"' WHERE NomeAlimento = '"+nome+"'";
                ExecuteQuery(update);
            }
            else
            {
                ChiudiConnessione();

                string qu = "INSERT INTO prodotto (NomeAlimento,Quantita,IDFrigo) values('" + nome + "'," + 1 + ",'" + IDFrigo + "')";
                ExecuteQuery(qu);
            }
            
        }

        //elimina prodotto 2
        public void EliminaManuale(string nome,int IDFrigo)
        {
            ApriConnessione();
            string qu = "SELECT Quantita FROM prodotto WHERE NomeAlimento = '" + nome + "' AND IDFrigo = '" + IDFrigo + "'";
            mcd = new MySqlCommand(qu, mcon);
            mdr = mcd.ExecuteReader();
            if(mdr.Read())
            {
                int quantita = Int32.Parse(mdr["Quantita"].ToString());

                if(quantita > 1)
                {
                    string q = mdr["Quantita"].ToString();
                    int nuovaQ = Int32.Parse(q);
                    nuovaQ--;
                    q = nuovaQ.ToString();

                    ChiudiConnessione();

                    string update = "UPDATE prodotto SET Quantita = '" + q + "' WHERE NomeAlimento = '" + nome + "'";
                    ExecuteQuery(update);
                    
                }
                else if(quantita == 1)
                {
                    ChiudiConnessione();

                    string query = "DELETE FROM prodotto WHERE NomeAlimento = '"+nome+"' AND IDFrigo = '"+IDFrigo+"'";
                    ExecuteQuery(query);
                }
                else
                {
                    ChiudiConnessione();
                    MessageBox.Show("Questo prodotto non è contenuto nel frigo, impossibile eliminarlo");
                }

            }
        }

        //controlla presenza in alimento
        public void VerificaAlimento(string nome)
        {
            ApriConnessione();

            //string controllo = "no";

            string query = "SELECT Nome FROM alimento WHERE Nome='" + nome + "'";

            mcd = new MySqlCommand(query, mcon);
            mdr = mcd.ExecuteReader();
            if(mdr.Read())
            {
                //controllo = "si";
            }
            else
            {
                ChiudiConnessione();

                string query2 = "INSERT INTO alimento(Nome) values('"+nome+"')";
                ExecuteQuery(query2);
            }
            
            ChiudiConnessione();
        }

        //Aggiorna se gia presente aumentando la quantita
        public void aggiornaPos(string EAN, string Nome, string scadenza,string produzione,string IDFrigo)
        {
            ApriConnessione();

            string query = "SELECT dataScadenza,Quantita FROM prodotto WHERE NomeAlimento='" + Nome + "' AND IDFrigo='" + IDFrigo + "'";
            mcd = new MySqlCommand(query, mcon);
            mdr = mcd.ExecuteReader();
            if(mdr.Read())
            {
                string daPassare = mdr["dataScadenza"].ToString();
                //string x = mdr["dataScadenza"].ToString();
                //x = x.Substring(0, 10);

                //string[] token = x.Split('/');

                //string giorno, mese, anno;
                //giorno = token[0];
                //mese = token[1];
                //anno = token[2];
                //x = anno + "-" + mese + "-" + giorno;

                if(daPassare == scadenza)
                {
                    string q = mdr["Quantita"].ToString(); 
                    int nuovaQ = Int32.Parse(q);
                    nuovaQ++;
                    q = nuovaQ.ToString();

                    ChiudiConnessione();

                    string query3 = "UPDATE prodotto SET Quantita = '"+q+"' WHERE dataScadenza ='"+scadenza+"' AND NomeAlimento = '"+Nome+"'";
                    ExecuteQuery(query3);
                }
                else
                {
                    ChiudiConnessione();
                    string query4 = "INSERT INTO prodotto (EAN,NomeAlimento,dataScadenza,luogoProduzione,Quantita,IDFrigo) values('" + EAN + "','" + Nome + "','" + scadenza+ "','" + produzione + "','"+1+"','"+IDFrigo+"');";
                    ExecuteQuery(query4);
                }
                
            }
            else
            {
                ChiudiConnessione();
                string query4 = "INSERT INTO prodotto (EAN,NomeAlimento,dataScadenza,luogoProduzione,Quantita,IDFrigo) values('" + EAN + "','" + Nome + "','" + scadenza + "','" + produzione + "','" + 1 + "','" + IDFrigo + "');";
                ExecuteQuery(query4);
            }
        }

        //Aggiorna se presente diminuendo la quantita
        public bool aggiornaNeg(string EAN, string Nome, string scadenza, string produzione, string IDFrigo)
        {
            ApriConnessione();

            bool controlla = true;

            string query = "SELECT dataScadenza,Quantita FROM prodotto WHERE NomeAlimento='" + Nome + "' AND IDFrigo='" + IDFrigo + "'";
            mcd = new MySqlCommand(query, mcon);
            mdr = mcd.ExecuteReader();
            if (mdr.Read())
            {
                int quantita = Int32.Parse(mdr["Quantita"].ToString());
                
                if (quantita != 1)
                {
                    quantita--;

                    ChiudiConnessione();

                    string query3 = "UPDATE prodotto SET Quantita = " + quantita + " WHERE dataScadenza ='" + scadenza + "' AND NomeAlimento = '" + Nome + "' AND IDFrigo = '"+IDFrigo+"'";
                    ExecuteQuery(query3);
                    return controlla;
                }
                else
                {
                    ChiudiConnessione();
                    string query4 = "DELETE FROM prodotto WHERE  dataScadenza ='" + scadenza + "' AND NomeAlimento = '" + Nome + "' AND IDFrigo = '" + IDFrigo + "'";
                    ExecuteQuery(query4);
                    return controlla;
                }

            }
            else
            {
                ChiudiConnessione();
                MessageBox.Show("Il prodotto non è presente nel frigo, impossibile eliminarlo");
                controlla = false;
                return controlla;
            }
        }
		
		
		
		public bool ricerca(string nome, int IDFrigo, DataGridView x)
        {
            ApriConnessione();

            string query = "SELECT  NomeAlimento ,  dataScadenza , Quantita , luogoProduzione FROM prodotto WHERE NomeAlimento='" + nome + "' AND IDFrigo='" + IDFrigo + "'";
            mcd = new MySqlCommand(query, mcon);
            mdr = mcd.ExecuteReader();
            bool s = false;

            x.Rows.Clear();
            
                while (mdr.Read())
                {
                    x.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
                    x.Rows.Add(mdr["NomeAlimento"].ToString(), mdr["dataScadenza"].ToString(), mdr["Quantita"].ToString(), mdr["luogoProduzione"].ToString());
                    s = true;
                }


            ChiudiConnessione();

            return s;
            
        }

        //---
        //-FINE GESTIONE PRODOTTI
        //---
        
        public void VisualizzaTutto(int id,DataGridView x)
        {
            ApriConnessione();
            string s = "SELECT NomeAlimento, luogoProduzione, dataScadenza,Quantita FROM prodotto WHERE IDFrigo = "+id+"";
            

            mcd = new MySqlCommand(s, mcon);
            mdr = mcd.ExecuteReader();
            string y;
            int i=0;
            x.Rows.Clear();
            while (mdr.Read())
            {
                x.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
                x.Rows.Add(mdr["NomeAlimento"].ToString(), mdr["luogoProduzione"].ToString(), mdr["dataScadenza"].ToString(),mdr["Quantita"].ToString());
            }
           ChiudiConnessione();
        }



    }
}