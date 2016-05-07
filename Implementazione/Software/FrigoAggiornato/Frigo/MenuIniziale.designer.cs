namespace Frigo
{
    partial class MenuIniziale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuIniziale));
            this.Avanti = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Preferiti = new System.Windows.Forms.Button();
            this.Cerca = new System.Windows.Forms.Button();
            this.Elimina = new System.Windows.Forms.Button();
            this.Ricette = new System.Windows.Forms.Button();
            this.Aggiungi = new System.Windows.Forms.Button();
            this.Inventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Avanti
            // 
            this.Avanti.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avanti.Location = new System.Drawing.Point(1292, 350);
            this.Avanti.Name = "Avanti";
            this.Avanti.Size = new System.Drawing.Size(38, 30);
            this.Avanti.TabIndex = 11;
            this.Avanti.Text = ">>";
            this.Avanti.UseVisualStyleBackColor = true;
            this.Avanti.Click += new System.EventHandler(this.Avanti_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Frigo.Properties.Resources.Sito;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1030, 386);
            this.button1.MinimumSize = new System.Drawing.Size(300, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 300);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::Frigo.Properties.Resources.Utenti;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1030, 44);
            this.button2.MinimumSize = new System.Drawing.Size(300, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 300);
            this.button2.TabIndex = 9;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Preferiti
            // 
            this.Preferiti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Preferiti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Preferiti.BackgroundImage")));
            this.Preferiti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Preferiti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Preferiti.Location = new System.Drawing.Point(702, 386);
            this.Preferiti.MinimumSize = new System.Drawing.Size(300, 300);
            this.Preferiti.Name = "Preferiti";
            this.Preferiti.Size = new System.Drawing.Size(300, 300);
            this.Preferiti.TabIndex = 8;
            this.Preferiti.UseVisualStyleBackColor = true;
            // 
            // Cerca
            // 
            this.Cerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerca.BackgroundImage = global::Frigo.Properties.Resources.pulsante_cerca;
            this.Cerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cerca.Location = new System.Drawing.Point(702, 44);
            this.Cerca.MinimumSize = new System.Drawing.Size(300, 300);
            this.Cerca.Name = "Cerca";
            this.Cerca.Size = new System.Drawing.Size(300, 300);
            this.Cerca.TabIndex = 7;
            this.Cerca.UseVisualStyleBackColor = true;
            // 
            // Elimina
            // 
            this.Elimina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Elimina.BackgroundImage = global::Frigo.Properties.Resources.pulsante_elimina;
            this.Elimina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Elimina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Elimina.Location = new System.Drawing.Point(370, 386);
            this.Elimina.MinimumSize = new System.Drawing.Size(300, 300);
            this.Elimina.Name = "Elimina";
            this.Elimina.Size = new System.Drawing.Size(300, 300);
            this.Elimina.TabIndex = 6;
            this.Elimina.UseVisualStyleBackColor = true;
            this.Elimina.Click += new System.EventHandler(this.Elimina_Click);
            // 
            // Ricette
            // 
            this.Ricette.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ricette.BackgroundImage = global::Frigo.Properties.Resources.pulsante_ricette;
            this.Ricette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ricette.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ricette.Location = new System.Drawing.Point(370, 44);
            this.Ricette.MinimumSize = new System.Drawing.Size(300, 300);
            this.Ricette.Name = "Ricette";
            this.Ricette.Size = new System.Drawing.Size(300, 300);
            this.Ricette.TabIndex = 5;
            this.Ricette.UseVisualStyleBackColor = true;
            // 
            // Aggiungi
            // 
            this.Aggiungi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Aggiungi.BackgroundImage = global::Frigo.Properties.Resources.pulsante_aggiungi;
            this.Aggiungi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aggiungi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Aggiungi.FlatAppearance.BorderSize = 3;
            this.Aggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aggiungi.Location = new System.Drawing.Point(37, 386);
            this.Aggiungi.MinimumSize = new System.Drawing.Size(300, 300);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(300, 300);
            this.Aggiungi.TabIndex = 4;
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // Inventario
            // 
            this.Inventario.BackgroundImage = global::Frigo.Properties.Resources.pulsante_visualizza;
            this.Inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Inventario.Location = new System.Drawing.Point(37, 44);
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(300, 300);
            this.Inventario.TabIndex = 1;
            this.Inventario.UseVisualStyleBackColor = true;
            // 
            // MenuIniziale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Avanti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Preferiti);
            this.Controls.Add(this.Cerca);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.Ricette);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.Inventario);
            this.MaximumSize = new System.Drawing.Size(1366, 749);
            this.Name = "MenuIniziale";
            this.Size = new System.Drawing.Size(1366, 726);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inventario;
        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.Button Ricette;
        private System.Windows.Forms.Button Elimina;
        private System.Windows.Forms.Button Cerca;
        private System.Windows.Forms.Button Preferiti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Avanti;
    }
}
