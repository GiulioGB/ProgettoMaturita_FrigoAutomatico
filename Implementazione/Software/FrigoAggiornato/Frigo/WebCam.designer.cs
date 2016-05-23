namespace Frigo
{
    partial class WebCam
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.agg = new System.Windows.Forms.Button();
            this.daAggiungere = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.info = new System.Windows.Forms.Button();
            this.TipoWebcam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.aggiungi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cam = new System.Windows.Forms.PictureBox();
            this.codiceLetto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cam)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(415, 377);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(47, 10);
            this.start.TabIndex = 0;
            this.start.Text = " ";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(818, 197);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(94, 87);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 208);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(378, 36);
            this.comboBox1.TabIndex = 2;
            // 
            // agg
            // 
            this.agg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.agg.AutoSize = true;
            this.agg.BackColor = System.Drawing.Color.Lime;
            this.agg.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agg.Location = new System.Drawing.Point(415, 208);
            this.agg.Name = "agg";
            this.agg.Size = new System.Drawing.Size(229, 88);
            this.agg.TabIndex = 5;
            this.agg.Text = "Aggiungi";
            this.agg.UseVisualStyleBackColor = false;
            this.agg.Click += new System.EventHandler(this.agg_Click);
            // 
            // daAggiungere
            // 
            this.daAggiungere.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daAggiungere.Location = new System.Drawing.Point(412, 587);
            this.daAggiungere.Name = "daAggiungere";
            this.daAggiungere.Size = new System.Drawing.Size(541, 42);
            this.daAggiungere.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Blue;
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Cambria", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(19, 364);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(378, 167);
            this.info.TabIndex = 8;
            this.info.Text = "?";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // TipoWebcam
            // 
            this.TipoWebcam.AutoSize = true;
            this.TipoWebcam.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoWebcam.Location = new System.Drawing.Point(21, 159);
            this.TipoWebcam.Name = "TipoWebcam";
            this.TipoWebcam.Size = new System.Drawing.Size(370, 25);
            this.TipoWebcam.TabIndex = 9;
            this.TipoWebcam.Text = "Dispositivo di input attualmente in uso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(340, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(679, 75);
            this.label2.TabIndex = 11;
            this.label2.Text = "AGGIUNGI PRODOTTO";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Menu.FlatAppearance.BorderSize = 3;
            this.Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.Black;
            this.Menu.Location = new System.Drawing.Point(971, 159);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(378, 372);
            this.Menu.TabIndex = 12;
            this.Menu.Text = "Menu\' Principale";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // aggiungi
            // 
            this.aggiungi.BackColor = System.Drawing.Color.Red;
            this.aggiungi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aggiungi.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.aggiungi.FlatAppearance.BorderSize = 3;
            this.aggiungi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aggiungi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiungi.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungi.Location = new System.Drawing.Point(493, 634);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(378, 41);
            this.aggiungi.TabIndex = 13;
            this.aggiungi.Text = "AGGIUNGI MANUALMENTE";
            this.aggiungi.UseVisualStyleBackColor = false;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Indicare il nome del prodotto in caso di NON PRESENZA del QrCode";
            // 
            // cam
            // 
            this.cam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cam.Cursor = System.Windows.Forms.Cursors.No;
            this.cam.InitialImage = null;
            this.cam.Location = new System.Drawing.Point(415, 159);
            this.cam.Name = "cam";
            this.cam.Size = new System.Drawing.Size(541, 372);
            this.cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cam.TabIndex = 3;
            this.cam.TabStop = false;
            // 
            // codiceLetto
            // 
            this.codiceLetto.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceLetto.Location = new System.Drawing.Point(19, 317);
            this.codiceLetto.Name = "codiceLetto";
            this.codiceLetto.ReadOnly = true;
            this.codiceLetto.Size = new System.Drawing.Size(378, 42);
            this.codiceLetto.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codice letto:";
            // 
            // WebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codiceLetto);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoWebcam);
            this.Controls.Add(this.info);
            this.Controls.Add(this.daAggiungere);
            this.Controls.Add(this.cam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.agg);
            this.MinimumSize = new System.Drawing.Size(1366, 749);
            this.Name = "WebCam";
            this.Size = new System.Drawing.Size(1366, 749);
            this.Load += new System.EventHandler(this.WebCam_Load);
            this.Leave += new System.EventHandler(this.WebCam_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.cam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox cam;
        private System.Windows.Forms.Button agg;
        private System.Windows.Forms.TextBox daAggiungere;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Label TipoWebcam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codiceLetto;
        private System.Windows.Forms.Label label3;
    }
}
