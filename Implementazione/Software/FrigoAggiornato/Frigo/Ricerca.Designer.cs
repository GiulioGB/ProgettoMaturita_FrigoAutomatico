namespace Frigo
{
    partial class Ricerca
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
            this.nomeCercato = new System.Windows.Forms.TextBox();
            this.bMenu = new System.Windows.Forms.Button();
            this.bRicerca = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci il prodotto da cercare:";
            // 
            // nomeCercato
            // 
            this.nomeCercato.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCercato.Location = new System.Drawing.Point(348, 293);
            this.nomeCercato.Name = "nomeCercato";
            this.nomeCercato.Size = new System.Drawing.Size(696, 41);
            this.nomeCercato.TabIndex = 2;
            // 
            // bMenu
            // 
            this.bMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bMenu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.bMenu.FlatAppearance.BorderSize = 3;
            this.bMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.bMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMenu.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold);
            this.bMenu.Location = new System.Drawing.Point(348, 584);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(696, 92);
            this.bMenu.TabIndex = 5;
            this.bMenu.Text = "MENU\'";
            this.bMenu.UseVisualStyleBackColor = false;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // bRicerca
            // 
            this.bRicerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bRicerca.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.bRicerca.FlatAppearance.BorderSize = 3;
            this.bRicerca.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.bRicerca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bRicerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.bRicerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRicerca.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRicerca.Location = new System.Drawing.Point(348, 445);
            this.bRicerca.Name = "bRicerca";
            this.bRicerca.Size = new System.Drawing.Size(696, 92);
            this.bRicerca.TabIndex = 4;
            this.bRicerca.Text = "RICERCA";
            this.bRicerca.UseVisualStyleBackColor = false;
            this.bRicerca.Click += new System.EventHandler(this.bRicerca_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(59, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1242, 422);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Data scadenza";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantità ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Luogo produzione";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(547, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 75);
            this.label2.TabIndex = 12;
            this.label2.Text = "RICERCA";
            // 
            // Ricerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bMenu);
            this.Controls.Add(this.bRicerca);
            this.Controls.Add(this.nomeCercato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(1366, 749);
            this.Name = "Ricerca";
            this.Size = new System.Drawing.Size(1366, 749);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeCercato;
        private System.Windows.Forms.Button bMenu;
        private System.Windows.Forms.Button bRicerca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
    }
}
