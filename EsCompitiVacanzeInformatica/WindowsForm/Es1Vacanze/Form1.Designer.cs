namespace Es1Vacanze
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaNominativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaDatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaRubricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoNominativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNominativo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuovo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esciToolStripMenuItem,
            this.visualizzaNominativoToolStripMenuItem,
            this.modificaDatiToolStripMenuItem,
            this.visualizzaRubricaToolStripMenuItem,
            this.nuovoNominativoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(48, 26);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // visualizzaNominativoToolStripMenuItem
            // 
            this.visualizzaNominativoToolStripMenuItem.Name = "visualizzaNominativoToolStripMenuItem";
            this.visualizzaNominativoToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.visualizzaNominativoToolStripMenuItem.Text = "Visualizza Nominativo";
            this.visualizzaNominativoToolStripMenuItem.Click += new System.EventHandler(this.visualizzaNominativoToolStripMenuItem_Click);
            // 
            // modificaDatiToolStripMenuItem
            // 
            this.modificaDatiToolStripMenuItem.Name = "modificaDatiToolStripMenuItem";
            this.modificaDatiToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.modificaDatiToolStripMenuItem.Text = "Modifica Dati";
            this.modificaDatiToolStripMenuItem.Click += new System.EventHandler(this.modificaDatiToolStripMenuItem_Click);
            // 
            // visualizzaRubricaToolStripMenuItem
            // 
            this.visualizzaRubricaToolStripMenuItem.Name = "visualizzaRubricaToolStripMenuItem";
            this.visualizzaRubricaToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.visualizzaRubricaToolStripMenuItem.Text = "Visualizza Rubrica";
            this.visualizzaRubricaToolStripMenuItem.Click += new System.EventHandler(this.visualizzaRubricaToolStripMenuItem_Click);
            // 
            // nuovoNominativoToolStripMenuItem
            // 
            this.nuovoNominativoToolStripMenuItem.Name = "nuovoNominativoToolStripMenuItem";
            this.nuovoNominativoToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.nuovoNominativoToolStripMenuItem.Text = "Nuovo Nominativo";
            this.nuovoNominativoToolStripMenuItem.Click += new System.EventHandler(this.nuovoNominativoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserire un nominativo da voler modificare";
            // 
            // txtNominativo
            // 
            this.txtNominativo.Location = new System.Drawing.Point(325, 65);
            this.txtNominativo.Name = "txtNominativo";
            this.txtNominativo.Size = new System.Drawing.Size(135, 22);
            this.txtNominativo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dopo aver inserito il nominativo da modificare inserire il nuovo nome";
            // 
            // txtNuovo
            // 
            this.txtNuovo.Location = new System.Drawing.Point(491, 106);
            this.txtNuovo.Name = "txtNuovo";
            this.txtNuovo.Size = new System.Drawing.Size(135, 22);
            this.txtNuovo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inserire anche il numero di telefono modificato";
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(345, 142);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(135, 22);
            this.txtNumTelefono.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(689, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "NOME: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "NUMERO DI TELEFONO: ";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(859, 109);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 22);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(748, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 22);
            this.txtNome.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 496);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuovo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNominativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaNominativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaDatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaRubricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoNominativoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNominativo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNome;
    }
}

