namespace Bonovi
{
    partial class frmIspis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIspis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPartner = new System.Windows.Forms.Label();
            this.txtSifraPartnera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.txtBrojOD = new System.Windows.Forms.TextBox();
            this.lblIspis = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPartner);
            this.panel1.Controls.Add(this.txtSifraPartnera);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPoruka);
            this.panel1.Controls.Add(this.btnIspisi);
            this.panel1.Controls.Add(this.txtBrojOD);
            this.panel1.Controls.Add(this.lblIspis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 149);
            this.panel1.TabIndex = 0;
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Location = new System.Drawing.Point(97, 45);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(0, 13);
            this.lblPartner.TabIndex = 10;
            // 
            // txtSifraPartnera
            // 
            this.txtSifraPartnera.Location = new System.Drawing.Point(121, 17);
            this.txtSifraPartnera.Name = "txtSifraPartnera";
            this.txtSifraPartnera.Size = new System.Drawing.Size(100, 20);
            this.txtSifraPartnera.TabIndex = 0;
            this.txtSifraPartnera.TextChanged += new System.EventHandler(this.txtSifraPartnera_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Šifra partnera:";
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.ForeColor = System.Drawing.Color.Red;
            this.lblPoruka.Location = new System.Drawing.Point(36, 123);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 7;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(269, 85);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 6;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // txtBrojOD
            // 
            this.txtBrojOD.Location = new System.Drawing.Point(121, 69);
            this.txtBrojOD.Name = "txtBrojOD";
            this.txtBrojOD.Size = new System.Drawing.Size(100, 20);
            this.txtBrojOD.TabIndex = 3;
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Location = new System.Drawing.Point(19, 71);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(78, 13);
            this.lblIspis.TabIndex = 2;
            this.lblIspis.Text = "Ispis bona broj:";
            // 
            // frmIspis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 149);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmIspis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ispis";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIspis_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.TextBox txtBrojOD;
        private System.Windows.Forms.Label lblIspis;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.TextBox txtSifraPartnera;
        private System.Windows.Forms.Label label1;
    }
}