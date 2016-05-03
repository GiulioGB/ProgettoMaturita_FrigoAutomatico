namespace Frigo
{
    partial class WebCamEl
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
            this.label2 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoWebcam = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.codiceLetto = new System.Windows.Forms.TextBox();
            this.cam = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.agg = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cam)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(362, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(639, 75);
            this.label2.TabIndex = 12;
            this.label2.Text = "ELIMINA PRODOTTO";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Menu.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(970, 206);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(378, 372);
            this.Menu.TabIndex = 19;
            this.Menu.Text = "Menu\' Principale";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codice catturato dalla lettura del codice a barre";
            // 
            // TipoWebcam
            // 
            this.TipoWebcam.AutoSize = true;
            this.TipoWebcam.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoWebcam.Location = new System.Drawing.Point(20, 206);
            this.TipoWebcam.Name = "TipoWebcam";
            this.TipoWebcam.Size = new System.Drawing.Size(370, 25);
            this.TipoWebcam.TabIndex = 17;
            this.TipoWebcam.Text = "Dispositivo di input attualmente in uso:";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Blue;
            this.info.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Cambria", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(18, 340);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(378, 238);
            this.info.TabIndex = 16;
            this.info.Text = "?";
            this.info.UseVisualStyleBackColor = false;
            // 
            // codiceLetto
            // 
            this.codiceLetto.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codiceLetto.Location = new System.Drawing.Point(413, 628);
            this.codiceLetto.Name = "codiceLetto";
            this.codiceLetto.ReadOnly = true;
            this.codiceLetto.Size = new System.Drawing.Size(541, 41);
            this.codiceLetto.TabIndex = 15;
            // 
            // cam
            // 
            this.cam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cam.InitialImage = null;
            this.cam.Location = new System.Drawing.Point(413, 206);
            this.cam.Name = "cam";
            this.cam.Size = new System.Drawing.Size(541, 372);
            this.cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cam.TabIndex = 14;
            this.cam.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(378, 36);
            this.comboBox1.TabIndex = 13;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(435, 459);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(47, 10);
            this.start.TabIndex = 20;
            this.start.Text = " ";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(838, 279);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(94, 87);
            this.stop.TabIndex = 21;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // agg
            // 
            this.agg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.agg.AutoSize = true;
            this.agg.BackColor = System.Drawing.Color.Lime;
            this.agg.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agg.Location = new System.Drawing.Point(435, 353);
            this.agg.Name = "agg";
            this.agg.Size = new System.Drawing.Size(229, 88);
            this.agg.TabIndex = 22;
            this.agg.Text = "Aggiungi";
            this.agg.UseVisualStyleBackColor = false;
            this.agg.Click += new System.EventHandler(this.agg_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WebCamEl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipoWebcam);
            this.Controls.Add(this.info);
            this.Controls.Add(this.codiceLetto);
            this.Controls.Add(this.cam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.agg);
            this.Controls.Add(this.start);
            this.Controls.Add(this.stop);
            this.MinimumSize = new System.Drawing.Size(1366, 749);
            this.Name = "WebCamEl";
            this.Size = new System.Drawing.Size(1366, 749);
            this.Load += new System.EventHandler(this.WebCamEl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TipoWebcam;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.TextBox codiceLetto;
        private System.Windows.Forms.PictureBox cam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button agg;
        private System.Windows.Forms.Timer timer1;
    }
}
