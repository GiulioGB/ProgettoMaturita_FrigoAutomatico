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
            this.Indietro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IndietroEl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(918, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il nome del familiare che desideri eliminare";
            this.label1.Visible = false;
            // 
            // eliminato
            // 
            this.eliminato.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminato.Location = new System.Drawing.Point(335, 232);
            this.eliminato.Name = "eliminato";
            this.eliminato.Size = new System.Drawing.Size(696, 41);
            this.eliminato.TabIndex = 1;
            this.eliminato.Visible = false;
            // 
            // Elimina
            // 
            this.Elimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Elimina.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Elimina.FlatAppearance.BorderSize = 3;
            this.Elimina.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Elimina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Elimina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Elimina.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elimina.Location = new System.Drawing.Point(335, 327);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(696, 92);
            this.Elimina.TabIndex = 2;
            this.Elimina.Text = "Elimina";
            this.Elimina.UseVisualStyleBackColor = false;
            this.Elimina.Visible = false;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Indietro
            // 
            this.Indietro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Indietro.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Indietro.FlatAppearance.BorderSize = 3;
            this.Indietro.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Indietro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Indietro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Indietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indietro.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indietro.Location = new System.Drawing.Point(123, 149);
            this.Indietro.Name = "Indietro";
            this.Indietro.Size = new System.Drawing.Size(300, 300);
            this.Indietro.TabIndex = 3;
            this.Indietro.Text = "Indietro";
            this.Indietro.UseVisualStyleBackColor = false;
            this.Indietro.Click += new System.EventHandler(this.Annulla_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(533, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 300);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aggiorna";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(943, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 300);
            this.button2.TabIndex = 5;
            this.button2.Text = "Elimina";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IndietroEl
            // 
            this.IndietroEl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.IndietroEl.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.IndietroEl.FlatAppearance.BorderSize = 3;
            this.IndietroEl.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.IndietroEl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.IndietroEl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IndietroEl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IndietroEl.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndietroEl.Location = new System.Drawing.Point(335, 468);
            this.IndietroEl.Name = "IndietroEl";
            this.IndietroEl.Size = new System.Drawing.Size(696, 92);
            this.IndietroEl.TabIndex = 6;
            this.IndietroEl.Text = "Indietro";
            this.IndietroEl.UseVisualStyleBackColor = false;
            this.IndietroEl.Visible = false;
            this.IndietroEl.Click += new System.EventHandler(this.IndietroEl_Click);
            // 
            // EliminaFamiliare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.IndietroEl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Indietro);
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
        private System.Windows.Forms.Button Indietro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button IndietroEl;
    }
}
