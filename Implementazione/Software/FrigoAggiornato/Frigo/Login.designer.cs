namespace Frigo
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NomeFrigo_textBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.accedi_login = new System.Windows.Forms.Button();
            this.registrazione_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Frigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // NomeFrigo_textBox
            // 
            this.NomeFrigo_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NomeFrigo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeFrigo_textBox.Location = new System.Drawing.Point(359, 145);
            this.NomeFrigo_textBox.Name = "NomeFrigo_textBox";
            this.NomeFrigo_textBox.Size = new System.Drawing.Size(685, 38);
            this.NomeFrigo_textBox.TabIndex = 3;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Password_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TextBox.Location = new System.Drawing.Point(359, 255);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(685, 38);
            this.Password_TextBox.TabIndex = 4;
            // 
            // accedi_login
            // 
            this.accedi_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accedi_login.BackColor = System.Drawing.Color.Lime;
            this.accedi_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accedi_login.Location = new System.Drawing.Point(290, 442);
            this.accedi_login.Name = "accedi_login";
            this.accedi_login.Size = new System.Drawing.Size(250, 250);
            this.accedi_login.TabIndex = 5;
            this.accedi_login.Text = "Accedi";
            this.accedi_login.UseVisualStyleBackColor = false;
            this.accedi_login.Click += new System.EventHandler(this.accedi_login_Click);
            // 
            // registrazione_login
            // 
            this.registrazione_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registrazione_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registrazione_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrazione_login.Location = new System.Drawing.Point(705, 442);
            this.registrazione_login.Name = "registrazione_login";
            this.registrazione_login.Size = new System.Drawing.Size(250, 250);
            this.registrazione_login.TabIndex = 6;
            this.registrazione_login.Text = "Registrati";
            this.registrazione_login.UseVisualStyleBackColor = false;
            this.registrazione_login.Click += new System.EventHandler(this.registrazione_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.registrazione_login);
            this.Controls.Add(this.accedi_login);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.NomeFrigo_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1366, 749);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1366, 749);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomeFrigo_textBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button accedi_login;
        private System.Windows.Forms.Button registrazione_login;
    }
}
