namespace Frigo
{
    partial class Preferiti
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_utente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_listaPreferiti = new System.Windows.Forms.TextBox();
            this.textBox_preferito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_aggiungiP = new System.Windows.Forms.Button();
            this.btn_eliminaP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBox_utente
            // 
            this.comboBox_utente.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_utente.FormattingEnabled = true;
            this.comboBox_utente.Location = new System.Drawing.Point(674, 70);
            this.comboBox_utente.Name = "comboBox_utente";
            this.comboBox_utente.Size = new System.Drawing.Size(403, 55);
            this.comboBox_utente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 30F);
            this.label1.Location = new System.Drawing.Point(279, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleziona utente: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_listaPreferiti
            // 
            this.textBox_listaPreferiti.Font = new System.Drawing.Font("Cambria", 30F);
            this.textBox_listaPreferiti.Location = new System.Drawing.Point(71, 396);
            this.textBox_listaPreferiti.Name = "textBox_listaPreferiti";
            this.textBox_listaPreferiti.Size = new System.Drawing.Size(428, 54);
            this.textBox_listaPreferiti.TabIndex = 2;
            // 
            // textBox_preferito
            // 
            this.textBox_preferito.Font = new System.Drawing.Font("Cambria", 30F);
            this.textBox_preferito.Location = new System.Drawing.Point(857, 236);
            this.textBox_preferito.Name = "textBox_preferito";
            this.textBox_preferito.Size = new System.Drawing.Size(372, 54);
            this.textBox_preferito.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 30F);
            this.label2.Location = new System.Drawing.Point(666, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preferito:";
            // 
            // bnt_aggiungiP
            // 
            this.bnt_aggiungiP.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bnt_aggiungiP.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_aggiungiP.Location = new System.Drawing.Point(639, 483);
            this.bnt_aggiungiP.Name = "bnt_aggiungiP";
            this.bnt_aggiungiP.Size = new System.Drawing.Size(250, 250);
            this.bnt_aggiungiP.TabIndex = 5;
            this.bnt_aggiungiP.Text = "AGGIUNGI";
            this.bnt_aggiungiP.UseVisualStyleBackColor = false;
            this.bnt_aggiungiP.Click += new System.EventHandler(this.bnt_aggiungiP_Click);
            // 
            // btn_eliminaP
            // 
            this.btn_eliminaP.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_eliminaP.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminaP.Location = new System.Drawing.Point(1040, 483);
            this.btn_eliminaP.Name = "btn_eliminaP";
            this.btn_eliminaP.Size = new System.Drawing.Size(250, 250);
            this.btn_eliminaP.TabIndex = 6;
            this.btn_eliminaP.Text = "ELIMINA";
            this.btn_eliminaP.UseVisualStyleBackColor = false;
            this.btn_eliminaP.Click += new System.EventHandler(this.btn_eliminaP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F);
            this.label3.Location = new System.Drawing.Point(63, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 47);
            this.label3.TabIndex = 7;
            this.label3.Text = "Visualizzazione preferiti";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 8;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Preferiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_eliminaP);
            this.Controls.Add(this.bnt_aggiungiP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_preferito);
            this.Controls.Add(this.textBox_listaPreferiti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_utente);
            this.MinimumSize = new System.Drawing.Size(1366, 749);
            this.Name = "Preferiti";
            this.Size = new System.Drawing.Size(1366, 749);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_utente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_listaPreferiti;
        private System.Windows.Forms.TextBox textBox_preferito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_aggiungiP;
        private System.Windows.Forms.Button btn_eliminaP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
    }
}
