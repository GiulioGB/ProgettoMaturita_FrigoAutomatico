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
            //Vado a registrazione
            Registrazione secondaSchermata=new Registrazione();
            Controls.Add(secondaSchermata);
            secondaSchermata.BringToFront();
            this.Refresh();
            //---
            
        }

        private void accedi_login_Click(object sender, EventArgs e)
        {
            //Controllo sulla compilazione dei campi
            if(NomeFrigo_textBox.Text != "" && Password_TextBox.Text != "")
            {
                //DEVO ACCEDERE
                ConnessioneDB conn = new ConnessioneDB();
                conn.ApriConnessione();

                String nomeFrigo, passwordFrigo;

                nomeFrigo = NomeFrigo_textBox.Text;

                passwordFrigo = Password_TextBox.Text;

                string c = conn.leggiFrigo(nomeFrigo);
                string c2 = conn.Controlla(nomeFrigo, passwordFrigo);
                conn.ChiudiConnessione();
                //---

                if (c == "si" && c2=="si")
                {
                    //Vado ai piu
                    AggiungiFamiliare terzaSchermata = new AggiungiFamiliare(nomeFrigo);
                    Controls.Add(terzaSchermata);
                    terzaSchermata.BringToFront();
                    this.Refresh();
                    //---
                }
                else if(c == "no" || c2 == "no")
                {
                    MessageBox.Show("nome frigo o password errati");
                }
            }
            else
            {
                MessageBox.Show("COMPILARE TUTTI I CAMPI");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
