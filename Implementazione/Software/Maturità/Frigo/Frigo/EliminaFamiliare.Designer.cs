namespace Frigo
{
    partial class EliminaFamiliare
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
            this.label1 = new System.Windows.Forms.Label();
            this.eliminato = new System.Windows.Forms.TextBox();
            this.Elimina = new System.Windows.Forms.Button();
            this.Annulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il nome del familiare che desideri eliminare";
            // 
            // eliminato
            // 
            this.eliminato.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminato.Location = new System.Drawing.Point(357, 241);
            this.eliminato.Name = "eliminato";
            this.eliminato.Size = new System.Drawing.Size(696, 41);
            this.eliminato.TabIndex = 1;
            // 
            // Elimina
            // 
            this.Elimina.BackColor = System.Drawing.Color.Blue;
            this.Elimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Elimina.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elimina.Location = new System.Drawing.Point(724, 350);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(329, 107);
            this.Elimina.TabIndex = 2;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = false;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Annulla
            // 
            this.Annulla.BackColor = System.Drawing.Color.Blue;
            this.Annulla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Annulla.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annulla.Location = new System.Drawing.Point(357, 350);
            this.Annulla.Name = "Annulla";
            this.Annulla.Size = new System.Drawing.Size(326, 107);
            this.Annulla.TabIndex = 3;
            this.Annulla.Text = "Annulla";
            this.Annulla.UseVisualStyleBackColor = false;
            this.Annulla.Click += new System.EventHandler(this.Annulla_Click);
            // 
            // EliminaFamiliare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.Annulla);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.eliminato);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1366, 749);
            this.Name = "EliminaFamiliare";
            this.Size = new System.Drawing.Size(1366, 749);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eliminato;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button Annulla;
    }
}
