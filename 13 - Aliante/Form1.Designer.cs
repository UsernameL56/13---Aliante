namespace _13___Aliante
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.alaLunghezza = new System.Windows.Forms.TextBox();
            this.alaApertura = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fusolieraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ruotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fusolieraLunghezza = new System.Windows.Forms.TextBox();
            this.fusolieraMateriale = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.codaLunghezza = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gommaRaggio = new System.Windows.Forms.TextBox();
            this.gommaLarghezza = new System.Windows.Forms.TextBox();
            this.gommaAltezza = new System.Windows.Forms.TextBox();
            this.cerchioneMateriale = new System.Windows.Forms.TextBox();
            this.cerchionePollici = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aggiunta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancellazione";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "getChild";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "Stampa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // alaLunghezza
            // 
            this.alaLunghezza.Location = new System.Drawing.Point(6, 21);
            this.alaLunghezza.Multiline = true;
            this.alaLunghezza.Name = "alaLunghezza";
            this.alaLunghezza.Size = new System.Drawing.Size(181, 33);
            this.alaLunghezza.TabIndex = 4;
            // 
            // alaApertura
            // 
            this.alaApertura.Location = new System.Drawing.Point(6, 60);
            this.alaApertura.Multiline = true;
            this.alaApertura.Name = "alaApertura";
            this.alaApertura.Size = new System.Drawing.Size(181, 33);
            this.alaApertura.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alaLunghezza);
            this.groupBox1.Controls.Add(this.alaApertura);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apertura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lunghezza";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alaToolStripMenuItem,
            this.fusolieraToolStripMenuItem,
            this.codaToolStripMenuItem1,
            this.ruotaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1532, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alaToolStripMenuItem
            // 
            this.alaToolStripMenuItem.Name = "alaToolStripMenuItem";
            this.alaToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.alaToolStripMenuItem.Text = "Ala";
            this.alaToolStripMenuItem.Click += new System.EventHandler(this.alaToolStripMenuItem_Click);
            // 
            // fusolieraToolStripMenuItem
            // 
            this.fusolieraToolStripMenuItem.Name = "fusolieraToolStripMenuItem";
            this.fusolieraToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.fusolieraToolStripMenuItem.Text = "Fusoliera";
            this.fusolieraToolStripMenuItem.Click += new System.EventHandler(this.fusolieraToolStripMenuItem_Click);
            // 
            // codaToolStripMenuItem1
            // 
            this.codaToolStripMenuItem1.Name = "codaToolStripMenuItem1";
            this.codaToolStripMenuItem1.Size = new System.Drawing.Size(58, 24);
            this.codaToolStripMenuItem1.Text = "Coda";
            this.codaToolStripMenuItem1.Click += new System.EventHandler(this.codaToolStripMenuItem1_Click);
            // 
            // ruotaToolStripMenuItem
            // 
            this.ruotaToolStripMenuItem.Name = "ruotaToolStripMenuItem";
            this.ruotaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ruotaToolStripMenuItem.Text = "Ruota";
            this.ruotaToolStripMenuItem.Click += new System.EventHandler(this.ruotaToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.fusolieraLunghezza);
            this.groupBox2.Controls.Add(this.fusolieraMateriale);
            this.groupBox2.Location = new System.Drawing.Point(363, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fusoliera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lunghezza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materiale";
            // 
            // fusolieraLunghezza
            // 
            this.fusolieraLunghezza.Location = new System.Drawing.Point(6, 60);
            this.fusolieraLunghezza.Multiline = true;
            this.fusolieraLunghezza.Name = "fusolieraLunghezza";
            this.fusolieraLunghezza.Size = new System.Drawing.Size(181, 33);
            this.fusolieraLunghezza.TabIndex = 7;
            // 
            // fusolieraMateriale
            // 
            this.fusolieraMateriale.Location = new System.Drawing.Point(6, 21);
            this.fusolieraMateriale.Multiline = true;
            this.fusolieraMateriale.Name = "fusolieraMateriale";
            this.fusolieraMateriale.Size = new System.Drawing.Size(181, 33);
            this.fusolieraMateriale.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.codaLunghezza);
            this.groupBox3.Location = new System.Drawing.Point(714, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 164);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Coda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lunghezza";
            // 
            // codaLunghezza
            // 
            this.codaLunghezza.Location = new System.Drawing.Point(6, 21);
            this.codaLunghezza.Multiline = true;
            this.codaLunghezza.Name = "codaLunghezza";
            this.codaLunghezza.Size = new System.Drawing.Size(181, 33);
            this.codaLunghezza.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.gommaRaggio);
            this.groupBox4.Controls.Add(this.gommaLarghezza);
            this.groupBox4.Controls.Add(this.gommaAltezza);
            this.groupBox4.Controls.Add(this.cerchioneMateriale);
            this.groupBox4.Controls.Add(this.cerchionePollici);
            this.groupBox4.Location = new System.Drawing.Point(1065, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 300);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ruota";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Gomma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "raggio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Larghezza";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Altezza";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Materiale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Pollici";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cerchione";
            // 
            // gommaRaggio
            // 
            this.gommaRaggio.Location = new System.Drawing.Point(15, 251);
            this.gommaRaggio.Multiline = true;
            this.gommaRaggio.Name = "gommaRaggio";
            this.gommaRaggio.Size = new System.Drawing.Size(181, 33);
            this.gommaRaggio.TabIndex = 10;
            // 
            // gommaLarghezza
            // 
            this.gommaLarghezza.Location = new System.Drawing.Point(15, 212);
            this.gommaLarghezza.Multiline = true;
            this.gommaLarghezza.Name = "gommaLarghezza";
            this.gommaLarghezza.Size = new System.Drawing.Size(181, 33);
            this.gommaLarghezza.TabIndex = 9;
            // 
            // gommaAltezza
            // 
            this.gommaAltezza.Location = new System.Drawing.Point(15, 173);
            this.gommaAltezza.Multiline = true;
            this.gommaAltezza.Name = "gommaAltezza";
            this.gommaAltezza.Size = new System.Drawing.Size(181, 33);
            this.gommaAltezza.TabIndex = 8;
            // 
            // cerchioneMateriale
            // 
            this.cerchioneMateriale.Location = new System.Drawing.Point(15, 102);
            this.cerchioneMateriale.Multiline = true;
            this.cerchioneMateriale.Name = "cerchioneMateriale";
            this.cerchioneMateriale.Size = new System.Drawing.Size(181, 33);
            this.cerchioneMateriale.TabIndex = 7;
            // 
            // cerchionePollici
            // 
            this.cerchionePollici.Location = new System.Drawing.Point(15, 63);
            this.cerchionePollici.Multiline = true;
            this.cerchionePollici.Name = "cerchionePollici";
            this.cerchionePollici.Size = new System.Drawing.Size(181, 33);
            this.cerchionePollici.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(306, 236);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 205);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 453);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox alaLunghezza;
        private System.Windows.Forms.TextBox alaApertura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fusolieraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codaToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ruotaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fusolieraLunghezza;
        private System.Windows.Forms.TextBox fusolieraMateriale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codaLunghezza;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gommaRaggio;
        private System.Windows.Forms.TextBox gommaLarghezza;
        private System.Windows.Forms.TextBox gommaAltezza;
        private System.Windows.Forms.TextBox cerchioneMateriale;
        private System.Windows.Forms.TextBox cerchionePollici;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listView1;
    }
}

