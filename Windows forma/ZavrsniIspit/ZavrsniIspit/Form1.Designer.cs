namespace ZavrsniIspit
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
            this.lbKrave = new System.Windows.Forms.ListBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblBrojTeladi = new System.Windows.Forms.Label();
            this.lblDatumDolaskaNaFarmu = new System.Windows.Forms.Label();
            this.lblJedinstveiVeterinarskiBroj = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.lblPasmina = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.txtJedinstveniVeterinarskiBroj = new System.Windows.Forms.TextBox();
            this.txtDatumDolaskaNaFarmu = new System.Windows.Forms.TextBox();
            this.txtBrojTeladi = new System.Windows.Forms.NumericUpDown();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtPasmina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrojTeladi)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKrave
            // 
            this.lbKrave.FormattingEnabled = true;
            this.lbKrave.ItemHeight = 16;
            this.lbKrave.Location = new System.Drawing.Point(12, 12);
            this.lbKrave.Name = "lbKrave";
            this.lbKrave.Size = new System.Drawing.Size(254, 84);
            this.lbKrave.TabIndex = 0;
            this.lbKrave.SelectedIndexChanged += new System.EventHandler(this.lbKrave_SelectedIndexChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(323, 12);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 17);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // lblBrojTeladi
            // 
            this.lblBrojTeladi.AutoSize = true;
            this.lblBrojTeladi.Location = new System.Drawing.Point(323, 260);
            this.lblBrojTeladi.Name = "lblBrojTeladi";
            this.lblBrojTeladi.Size = new System.Drawing.Size(71, 17);
            this.lblBrojTeladi.TabIndex = 2;
            this.lblBrojTeladi.Text = "Broj teladi";
            // 
            // lblDatumDolaskaNaFarmu
            // 
            this.lblDatumDolaskaNaFarmu.AutoSize = true;
            this.lblDatumDolaskaNaFarmu.Location = new System.Drawing.Point(320, 212);
            this.lblDatumDolaskaNaFarmu.Name = "lblDatumDolaskaNaFarmu";
            this.lblDatumDolaskaNaFarmu.Size = new System.Drawing.Size(162, 17);
            this.lblDatumDolaskaNaFarmu.TabIndex = 4;
            this.lblDatumDolaskaNaFarmu.Text = "Datum dolaska na farmu";
            // 
            // lblJedinstveiVeterinarskiBroj
            // 
            this.lblJedinstveiVeterinarskiBroj.AutoSize = true;
            this.lblJedinstveiVeterinarskiBroj.Location = new System.Drawing.Point(320, 159);
            this.lblJedinstveiVeterinarskiBroj.Name = "lblJedinstveiVeterinarskiBroj";
            this.lblJedinstveiVeterinarskiBroj.Size = new System.Drawing.Size(184, 17);
            this.lblJedinstveiVeterinarskiBroj.TabIndex = 5;
            this.lblJedinstveiVeterinarskiBroj.Text = "Jedinstveni veterinarski broj";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(320, 106);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(101, 17);
            this.lblDatumRodjenja.TabIndex = 6;
            this.lblDatumRodjenja.Text = "Datum rođenja";
            // 
            // lblPasmina
            // 
            this.lblPasmina.AutoSize = true;
            this.lblPasmina.Location = new System.Drawing.Point(323, 57);
            this.lblPasmina.Name = "lblPasmina";
            this.lblPasmina.Size = new System.Drawing.Size(62, 17);
            this.lblPasmina.TabIndex = 7;
            this.lblPasmina.Text = "Pasmina";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(587, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(218, 22);
            this.txtIme.TabIndex = 8;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.Location = new System.Drawing.Point(587, 106);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(218, 22);
            this.txtDatumRodjenja.TabIndex = 10;
            // 
            // txtJedinstveniVeterinarskiBroj
            // 
            this.txtJedinstveniVeterinarskiBroj.Location = new System.Drawing.Point(587, 159);
            this.txtJedinstveniVeterinarskiBroj.Name = "txtJedinstveniVeterinarskiBroj";
            this.txtJedinstveniVeterinarskiBroj.Size = new System.Drawing.Size(218, 22);
            this.txtJedinstveniVeterinarskiBroj.TabIndex = 11;
            // 
            // txtDatumDolaskaNaFarmu
            // 
            this.txtDatumDolaskaNaFarmu.Location = new System.Drawing.Point(587, 212);
            this.txtDatumDolaskaNaFarmu.Name = "txtDatumDolaskaNaFarmu";
            this.txtDatumDolaskaNaFarmu.Size = new System.Drawing.Size(218, 22);
            this.txtDatumDolaskaNaFarmu.TabIndex = 12;
            // 
            // txtBrojTeladi
            // 
            this.txtBrojTeladi.Location = new System.Drawing.Point(587, 260);
            this.txtBrojTeladi.Name = "txtBrojTeladi";
            this.txtBrojTeladi.Size = new System.Drawing.Size(218, 22);
            this.txtBrojTeladi.TabIndex = 13;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(410, 325);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(188, 50);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "Spremi promjene";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtPasmina
            // 
            this.txtPasmina.Location = new System.Drawing.Point(587, 57);
            this.txtPasmina.Name = "txtPasmina";
            this.txtPasmina.Size = new System.Drawing.Size(218, 22);
            this.txtPasmina.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 418);
            this.Controls.Add(this.txtPasmina);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtBrojTeladi);
            this.Controls.Add(this.txtDatumDolaskaNaFarmu);
            this.Controls.Add(this.txtJedinstveniVeterinarskiBroj);
            this.Controls.Add(this.txtDatumRodjenja);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblPasmina);
            this.Controls.Add(this.lblDatumRodjenja);
            this.Controls.Add(this.lblJedinstveiVeterinarskiBroj);
            this.Controls.Add(this.lblDatumDolaskaNaFarmu);
            this.Controls.Add(this.lblBrojTeladi);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lbKrave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBrojTeladi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKrave;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblBrojTeladi;
        private System.Windows.Forms.Label lblDatumDolaskaNaFarmu;
        private System.Windows.Forms.Label lblJedinstveiVeterinarskiBroj;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.Label lblPasmina;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.TextBox txtJedinstveniVeterinarskiBroj;
        private System.Windows.Forms.TextBox txtDatumDolaskaNaFarmu;
        private System.Windows.Forms.NumericUpDown txtBrojTeladi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtPasmina;
    }
}

