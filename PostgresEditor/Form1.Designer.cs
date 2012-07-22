namespace PostgresEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxPolaczenie = new System.Windows.Forms.GroupBox();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonCzytaj = new System.Windows.Forms.Button();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxBD = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.groupBoxTabele = new System.Windows.Forms.GroupBox();
            this.richTextBoxTabele = new System.Windows.Forms.RichTextBox();
            this.groupBoxZapytanie = new System.Windows.Forms.GroupBox();
            this.richTextBoxZapytanie = new System.Windows.Forms.RichTextBox();
            this.groupBoxWynik = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxPolaczenie.SuspendLayout();
            this.groupBoxTabele.SuspendLayout();
            this.groupBoxZapytanie.SuspendLayout();
            this.groupBoxWynik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxPolaczenie);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxTabele);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxZapytanie);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxWynik);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 580);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxPolaczenie
            // 
            this.groupBoxPolaczenie.Controls.Add(this.buttonZapisz);
            this.groupBoxPolaczenie.Controls.Add(this.buttonCzytaj);
            this.groupBoxPolaczenie.Controls.Add(this.textBoxHaslo);
            this.groupBoxPolaczenie.Controls.Add(this.textBoxLogin);
            this.groupBoxPolaczenie.Controls.Add(this.textBoxBD);
            this.groupBoxPolaczenie.Controls.Add(this.textBoxPort);
            this.groupBoxPolaczenie.Controls.Add(this.label5);
            this.groupBoxPolaczenie.Controls.Add(this.label4);
            this.groupBoxPolaczenie.Controls.Add(this.label3);
            this.groupBoxPolaczenie.Controls.Add(this.label2);
            this.groupBoxPolaczenie.Controls.Add(this.label1);
            this.groupBoxPolaczenie.Controls.Add(this.textBoxServer);
            this.groupBoxPolaczenie.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPolaczenie.Name = "groupBoxPolaczenie";
            this.groupBoxPolaczenie.Size = new System.Drawing.Size(386, 104);
            this.groupBoxPolaczenie.TabIndex = 1;
            this.groupBoxPolaczenie.TabStop = false;
            this.groupBoxPolaczenie.Text = "Połączenie";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(304, 75);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 11;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonCzytaj
            // 
            this.buttonCzytaj.Location = new System.Drawing.Point(223, 75);
            this.buttonCzytaj.Name = "buttonCzytaj";
            this.buttonCzytaj.Size = new System.Drawing.Size(75, 23);
            this.buttonCzytaj.TabIndex = 10;
            this.buttonCzytaj.Text = "Czytaj";
            this.buttonCzytaj.UseVisualStyleBackColor = true;
            this.buttonCzytaj.Click += new System.EventHandler(this.buttonCzytaj_Click);
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Location = new System.Drawing.Point(279, 46);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(100, 20);
            this.textBoxHaslo.TabIndex = 9;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(279, 19);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 8;
            // 
            // textBoxBD
            // 
            this.textBoxBD.Location = new System.Drawing.Point(85, 71);
            this.textBoxBD.Name = "textBoxBD";
            this.textBoxBD.Size = new System.Drawing.Size(100, 20);
            this.textBoxBD.TabIndex = 7;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(85, 45);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baza Danych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serwer";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(85, 19);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(100, 20);
            this.textBoxServer.TabIndex = 0;
            // 
            // groupBoxTabele
            // 
            this.groupBoxTabele.Controls.Add(this.richTextBoxTabele);
            this.groupBoxTabele.Location = new System.Drawing.Point(395, 3);
            this.groupBoxTabele.Name = "groupBoxTabele";
            this.groupBoxTabele.Size = new System.Drawing.Size(168, 104);
            this.groupBoxTabele.TabIndex = 2;
            this.groupBoxTabele.TabStop = false;
            this.groupBoxTabele.Text = "Dostępne tabele";
            // 
            // richTextBoxTabele
            // 
            this.richTextBoxTabele.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxTabele.Name = "richTextBoxTabele";
            this.richTextBoxTabele.Size = new System.Drawing.Size(156, 79);
            this.richTextBoxTabele.TabIndex = 0;
            this.richTextBoxTabele.Text = "";
            // 
            // groupBoxZapytanie
            // 
            this.groupBoxZapytanie.Controls.Add(this.richTextBoxZapytanie);
            this.groupBoxZapytanie.Location = new System.Drawing.Point(3, 113);
            this.groupBoxZapytanie.Name = "groupBoxZapytanie";
            this.groupBoxZapytanie.Size = new System.Drawing.Size(560, 105);
            this.groupBoxZapytanie.TabIndex = 3;
            this.groupBoxZapytanie.TabStop = false;
            this.groupBoxZapytanie.Text = "Zapytanie SQL";
            // 
            // richTextBoxZapytanie
            // 
            this.richTextBoxZapytanie.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxZapytanie.Name = "richTextBoxZapytanie";
            this.richTextBoxZapytanie.Size = new System.Drawing.Size(548, 80);
            this.richTextBoxZapytanie.TabIndex = 0;
            this.richTextBoxZapytanie.Text = "";
            // 
            // groupBoxWynik
            // 
            this.groupBoxWynik.Controls.Add(this.dataGridView1);
            this.groupBoxWynik.Location = new System.Drawing.Point(3, 224);
            this.groupBoxWynik.Name = "groupBoxWynik";
            this.groupBoxWynik.Size = new System.Drawing.Size(560, 354);
            this.groupBoxWynik.TabIndex = 4;
            this.groupBoxWynik.TabStop = false;
            this.groupBoxWynik.Text = "Wynik";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 604);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxPolaczenie.ResumeLayout(false);
            this.groupBoxPolaczenie.PerformLayout();
            this.groupBoxTabele.ResumeLayout(false);
            this.groupBoxZapytanie.ResumeLayout(false);
            this.groupBoxWynik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxPolaczenie;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonCzytaj;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxBD;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.GroupBox groupBoxTabele;
        private System.Windows.Forms.RichTextBox richTextBoxTabele;
        private System.Windows.Forms.GroupBox groupBoxZapytanie;
        private System.Windows.Forms.RichTextBox richTextBoxZapytanie;
        private System.Windows.Forms.GroupBox groupBoxWynik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

