namespace Es2Vacanze
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
            this.btnCrea = new System.Windows.Forms.Button();
            this.pnlNuovoOgg = new System.Windows.Forms.Panel();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.nudW = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisBtnPnl = new System.Windows.Forms.Button();
            this.pnlVisBtn = new System.Windows.Forms.Panel();
            this.lblIndice = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.pnlNuovoOgg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(25, 33);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(75, 23);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "CREA";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // pnlNuovoOgg
            // 
            this.pnlNuovoOgg.Controls.Add(this.btnAggiungi);
            this.pnlNuovoOgg.Controls.Add(this.nudY);
            this.pnlNuovoOgg.Controls.Add(this.nudH);
            this.pnlNuovoOgg.Controls.Add(this.nudW);
            this.pnlNuovoOgg.Controls.Add(this.nudX);
            this.pnlNuovoOgg.Controls.Add(this.txtColore);
            this.pnlNuovoOgg.Controls.Add(this.txtNome);
            this.pnlNuovoOgg.Controls.Add(this.label6);
            this.pnlNuovoOgg.Controls.Add(this.label5);
            this.pnlNuovoOgg.Controls.Add(this.label4);
            this.pnlNuovoOgg.Controls.Add(this.label3);
            this.pnlNuovoOgg.Controls.Add(this.label2);
            this.pnlNuovoOgg.Controls.Add(this.label1);
            this.pnlNuovoOgg.Location = new System.Drawing.Point(25, 83);
            this.pnlNuovoOgg.Name = "pnlNuovoOgg";
            this.pnlNuovoOgg.Size = new System.Drawing.Size(354, 268);
            this.pnlNuovoOgg.TabIndex = 1;
            this.pnlNuovoOgg.Visible = false;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(21, 223);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(115, 23);
            this.btnAggiungi.TabIndex = 12;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(99, 84);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(120, 22);
            this.nudY.TabIndex = 11;
            // 
            // nudH
            // 
            this.nudH.Location = new System.Drawing.Point(86, 152);
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(120, 22);
            this.nudH.TabIndex = 10;
            // 
            // nudW
            // 
            this.nudW.Location = new System.Drawing.Point(94, 113);
            this.nudW.Name = "nudW";
            this.nudW.Size = new System.Drawing.Size(120, 22);
            this.nudW.TabIndex = 9;
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(99, 49);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 22);
            this.nudX.TabIndex = 8;
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(86, 184);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(100, 22);
            this.txtColore.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Colore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Altezza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Larghezza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posizione y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posizione x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnVisBtnPnl
            // 
            this.btnVisBtnPnl.Location = new System.Drawing.Point(1014, 33);
            this.btnVisBtnPnl.Name = "btnVisBtnPnl";
            this.btnVisBtnPnl.Size = new System.Drawing.Size(246, 23);
            this.btnVisBtnPnl.TabIndex = 2;
            this.btnVisBtnPnl.Text = "VISUALIZZA BTN NEL PANEL";
            this.btnVisBtnPnl.UseVisualStyleBackColor = true;
            this.btnVisBtnPnl.Visible = false;
            this.btnVisBtnPnl.Click += new System.EventHandler(this.btnVisBtnPnl_Click);
            // 
            // pnlVisBtn
            // 
            this.pnlVisBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlVisBtn.Location = new System.Drawing.Point(812, 83);
            this.pnlVisBtn.Name = "pnlVisBtn";
            this.pnlVisBtn.Size = new System.Drawing.Size(628, 516);
            this.pnlVisBtn.TabIndex = 3;
            this.pnlVisBtn.Visible = false;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(25, 460);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(95, 16);
            this.lblIndice.TabIndex = 4;
            this.lblIndice.Text = "Inserisci indice";
            this.lblIndice.Click += new System.EventHandler(this.lblIndice_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(139, 457);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(100, 22);
            this.txtIndice.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 622);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.pnlVisBtn);
            this.Controls.Add(this.btnVisBtnPnl);
            this.Controls.Add(this.pnlNuovoOgg);
            this.Controls.Add(this.btnCrea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlNuovoOgg.ResumeLayout(false);
            this.pnlNuovoOgg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Panel pnlNuovoOgg;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.NumericUpDown nudW;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnVisBtnPnl;
        private System.Windows.Forms.Panel pnlVisBtn;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.TextBox txtIndice;
    }
}

