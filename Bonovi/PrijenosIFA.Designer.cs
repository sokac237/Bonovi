namespace Bonovi
{
    partial class frmPrijenosIFA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijenosIFA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVrati = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbOdabirDiskontaIdatBr = new System.Windows.Forms.GroupBox();
            this.rbTrgovine = new System.Windows.Forms.RadioButton();
            this.dtpBrojanje = new System.Windows.Forms.DateTimePicker();
            this.lblDatumBrojanja = new System.Windows.Forms.Label();
            this.rbDiskonti = new System.Windows.Forms.RadioButton();
            this.dtpDatumDO = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumOD = new System.Windows.Forms.DateTimePicker();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrenesi = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBB = new System.Windows.Forms.RadioButton();
            this.rbOK = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgBonovi = new DevExpress.XtraGrid.GridControl();
            this.ifaPrijenosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaPrijenosIFA = new Bonovi.zaPrijenosIFA();
            this.dgBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colifab_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_datum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_valuta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_isporuka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpartner_pa_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_ukupno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloznaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ifaPrijenosTableAdapter = new Bonovi.zaPrijenosIFATableAdapters.IfaPrijenosTableAdapter();
            this.dgBonovi2 = new DevExpress.XtraGrid.GridControl();
            this.bonPrijenosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaPrijenosBonova = new Bonovi.zaPrijenosBonova();
            this.dgBon2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbon_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumkoristenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumbrojanja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumizrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_iznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bonoviPrijenosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonoviPrijenosTableAdapter = new Bonovi.zaPrijenosBonovaTableAdapters.bonoviPrijenosTableAdapter();
            this.bonPrijenosTableAdapter = new Bonovi.zaPrijenosBonovaTableAdapters.bonPrijenosTableAdapter();
            this.panel1.SuspendLayout();
            this.gbOdabirDiskontaIdatBr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifaPrijenosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaPrijenosIFA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonPrijenosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaPrijenosBonova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonoviPrijenosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVrati);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.gbOdabirDiskontaIdatBr);
            this.panel1.Controls.Add(this.dtpDatumDO);
            this.panel1.Controls.Add(this.dtpDatumOD);
            this.panel1.Controls.Add(this.cmbGodina);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPrenesi);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 151);
            this.panel1.TabIndex = 1;
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(875, 114);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(91, 23);
            this.btnVrati.TabIndex = 37;
            this.btnVrati.Text = "Vrati za prijenos";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(913, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "F5 - izvještaj";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(494, 116);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 35;
            // 
            // gbOdabirDiskontaIdatBr
            // 
            this.gbOdabirDiskontaIdatBr.Controls.Add(this.rbTrgovine);
            this.gbOdabirDiskontaIdatBr.Controls.Add(this.dtpBrojanje);
            this.gbOdabirDiskontaIdatBr.Controls.Add(this.lblDatumBrojanja);
            this.gbOdabirDiskontaIdatBr.Controls.Add(this.rbDiskonti);
            this.gbOdabirDiskontaIdatBr.Location = new System.Drawing.Point(424, 13);
            this.gbOdabirDiskontaIdatBr.Name = "gbOdabirDiskontaIdatBr";
            this.gbOdabirDiskontaIdatBr.Size = new System.Drawing.Size(261, 63);
            this.gbOdabirDiskontaIdatBr.TabIndex = 4;
            this.gbOdabirDiskontaIdatBr.TabStop = false;
            this.gbOdabirDiskontaIdatBr.Text = "BB";
            this.gbOdabirDiskontaIdatBr.Visible = false;
            // 
            // rbTrgovine
            // 
            this.rbTrgovine.AutoSize = true;
            this.rbTrgovine.Location = new System.Drawing.Point(114, 19);
            this.rbTrgovine.Name = "rbTrgovine";
            this.rbTrgovine.Size = new System.Drawing.Size(67, 17);
            this.rbTrgovine.TabIndex = 1;
            this.rbTrgovine.TabStop = true;
            this.rbTrgovine.Text = "Trgovine";
            this.rbTrgovine.UseVisualStyleBackColor = true;
            this.rbTrgovine.Visible = false;
            // 
            // dtpBrojanje
            // 
            this.dtpBrojanje.CustomFormat = " ";
            this.dtpBrojanje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBrojanje.Location = new System.Drawing.Point(114, 29);
            this.dtpBrojanje.Name = "dtpBrojanje";
            this.dtpBrojanje.Size = new System.Drawing.Size(120, 20);
            this.dtpBrojanje.TabIndex = 4;
            this.dtpBrojanje.ValueChanged += new System.EventHandler(this.dtpBrojanje_ValueChanged);
            this.dtpBrojanje.Enter += new System.EventHandler(this.dtpBrojanje_Enter);
            // 
            // lblDatumBrojanja
            // 
            this.lblDatumBrojanja.AutoSize = true;
            this.lblDatumBrojanja.Location = new System.Drawing.Point(22, 32);
            this.lblDatumBrojanja.Name = "lblDatumBrojanja";
            this.lblDatumBrojanja.Size = new System.Drawing.Size(81, 13);
            this.lblDatumBrojanja.TabIndex = 36;
            this.lblDatumBrojanja.Text = "Datum brojanja:";
            // 
            // rbDiskonti
            // 
            this.rbDiskonti.AutoSize = true;
            this.rbDiskonti.Checked = true;
            this.rbDiskonti.Location = new System.Drawing.Point(25, 19);
            this.rbDiskonti.Name = "rbDiskonti";
            this.rbDiskonti.Size = new System.Drawing.Size(63, 17);
            this.rbDiskonti.TabIndex = 0;
            this.rbDiskonti.TabStop = true;
            this.rbDiskonti.Text = "Diskonti";
            this.rbDiskonti.UseVisualStyleBackColor = true;
            this.rbDiskonti.Visible = false;
            // 
            // dtpDatumDO
            // 
            this.dtpDatumDO.CustomFormat = " ";
            this.dtpDatumDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumDO.Location = new System.Drawing.Point(283, 77);
            this.dtpDatumDO.Name = "dtpDatumDO";
            this.dtpDatumDO.Size = new System.Drawing.Size(119, 20);
            this.dtpDatumDO.TabIndex = 2;
            this.dtpDatumDO.ValueChanged += new System.EventHandler(this.dtpDatumDO_ValueChanged);
            this.dtpDatumDO.Enter += new System.EventHandler(this.dtpDatumDO_Enter);
            // 
            // dtpDatumOD
            // 
            this.dtpDatumOD.CustomFormat = " ";
            this.dtpDatumOD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOD.Location = new System.Drawing.Point(110, 77);
            this.dtpDatumOD.Name = "dtpDatumOD";
            this.dtpDatumOD.Size = new System.Drawing.Size(117, 20);
            this.dtpDatumOD.TabIndex = 1;
            this.dtpDatumOD.ValueChanged += new System.EventHandler(this.dtpDatumOD_ValueChanged);
            this.dtpDatumOD.Enter += new System.EventHandler(this.dtpDatumOD_Enter);
            // 
            // cmbGodina
            // 
            this.cmbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(121, 111);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(106, 21);
            this.cmbGodina.TabIndex = 3;
            this.cmbGodina.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Prijenos u godinu:\r\n";
            // 
            // btnPrenesi
            // 
            this.btnPrenesi.Location = new System.Drawing.Point(364, 109);
            this.btnPrenesi.Name = "btnPrenesi";
            this.btnPrenesi.Size = new System.Drawing.Size(75, 23);
            this.btnPrenesi.TabIndex = 6;
            this.btnPrenesi.Text = "Prenesi";
            this.btnPrenesi.UseVisualStyleBackColor = true;
            this.btnPrenesi.Click += new System.EventHandler(this.btnPrenesi_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(283, 109);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 5;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBB);
            this.groupBox1.Controls.Add(this.rbOK);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta dokumenta";
            // 
            // rbBB
            // 
            this.rbBB.AutoSize = true;
            this.rbBB.Location = new System.Drawing.Point(175, 19);
            this.rbBB.Name = "rbBB";
            this.rbBB.Size = new System.Drawing.Size(134, 17);
            this.rbBB.TabIndex = 1;
            this.rbBB.TabStop = true;
            this.rbBB.Text = "Blagajna bonova ( BB )";
            this.rbBB.UseVisualStyleBackColor = true;
            this.rbBB.CheckedChanged += new System.EventHandler(this.rbBB_CheckedChanged);
            // 
            // rbOK
            // 
            this.rbOK.AutoSize = true;
            this.rbOK.Checked = true;
            this.rbOK.Location = new System.Drawing.Point(25, 19);
            this.rbOK.Name = "rbOK";
            this.rbOK.Size = new System.Drawing.Size(119, 17);
            this.rbOK.TabIndex = 0;
            this.rbOK.TabStop = true;
            this.rbOK.Text = "Izlazna faktura ( BI )";
            this.rbOK.UseVisualStyleBackColor = true;
            this.rbOK.CheckedChanged += new System.EventHandler(this.rbOK_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Za razdoblje od: ";
            // 
            // dgBonovi
            // 
            this.dgBonovi.DataSource = this.ifaPrijenosBindingSource;
            this.dgBonovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBonovi.Location = new System.Drawing.Point(0, 151);
            this.dgBonovi.MainView = this.dgBon;
            this.dgBonovi.Name = "dgBonovi";
            this.dgBonovi.Size = new System.Drawing.Size(990, 449);
            this.dgBonovi.TabIndex = 27;
            this.dgBonovi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgBon});
            this.dgBonovi.DoubleClick += new System.EventHandler(this.dgBonovi_DoubleClick);
            this.dgBonovi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgBonovi_KeyDown);
            // 
            // ifaPrijenosBindingSource
            // 
            this.ifaPrijenosBindingSource.DataMember = "IfaPrijenos";
            this.ifaPrijenosBindingSource.DataSource = this.zaPrijenosIFA;
            // 
            // zaPrijenosIFA
            // 
            this.zaPrijenosIFA.DataSetName = "zaPrijenosIFA";
            this.zaPrijenosIFA.EnforceConstraints = false;
            this.zaPrijenosIFA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgBon
            // 
            this.dgBon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgBon.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgBon.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgBon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgBon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgBon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgBon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgBon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgBon.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.Empty.Options.UseBackColor = true;
            this.dgBon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgBon.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgBon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgBon.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgBon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgBon.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgBon.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgBon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgBon.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgBon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgBon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgBon.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgBon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgBon.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgBon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgBon.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgBon.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgBon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgBon.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgBon.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgBon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgBon.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgBon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgBon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgBon.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgBon.Appearance.GroupRow.Options.UseFont = true;
            this.dgBon.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgBon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgBon.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgBon.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgBon.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgBon.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgBon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgBon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgBon.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgBon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgBon.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgBon.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.OddRow.Options.UseBackColor = true;
            this.dgBon.Appearance.OddRow.Options.UseForeColor = true;
            this.dgBon.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgBon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgBon.Appearance.Preview.Options.UseBackColor = true;
            this.dgBon.Appearance.Preview.Options.UseForeColor = true;
            this.dgBon.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.Row.Options.UseBackColor = true;
            this.dgBon.Appearance.Row.Options.UseForeColor = true;
            this.dgBon.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgBon.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgBon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgBon.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgBon.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgBon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgBon.Appearance.VertLine.Options.UseBackColor = true;
            this.dgBon.ColumnPanelRowHeight = 50;
            this.dgBon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colifab_ID,
            this.colifab_datum,
            this.colifab_valuta,
            this.colifab_isporuka,
            this.colpartner_pa_ID,
            this.colPA_NAZIV,
            this.colpa_sifra,
            this.colifab_ukupno,
            this.colifab_status,
            this.gridColumn1,
            this.coloznaka});
            this.dgBon.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgBon.GridControl = this.dgBonovi;
            this.dgBon.Name = "dgBon";
            this.dgBon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgBon.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgBon.OptionsBehavior.Editable = false;
            this.dgBon.OptionsCustomization.AllowColumnMoving = false;
            this.dgBon.OptionsCustomization.AllowFilter = false;
            this.dgBon.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgBon.OptionsSelection.MultiSelect = true;
            this.dgBon.OptionsView.EnableAppearanceEvenRow = true;
            this.dgBon.OptionsView.EnableAppearanceOddRow = true;
            this.dgBon.OptionsView.ShowAutoFilterRow = true;
            this.dgBon.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgBon.OptionsView.ShowGroupPanel = false;
            this.dgBon.OptionsView.ShowIndicator = false;
            this.dgBon.PaintStyleName = "WindowsXP";
            this.dgBon.SynchronizeClones = false;
            this.dgBon.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.dgBon_RowCellStyle);
            // 
            // colifab_ID
            // 
            this.colifab_ID.Caption = "Broj fakture";
            this.colifab_ID.FieldName = "ifab_ID";
            this.colifab_ID.Name = "colifab_ID";
            this.colifab_ID.Visible = true;
            this.colifab_ID.VisibleIndex = 0;
            this.colifab_ID.Width = 117;
            // 
            // colifab_datum
            // 
            this.colifab_datum.Caption = "Datum dokumenta";
            this.colifab_datum.FieldName = "ifab_datum";
            this.colifab_datum.Name = "colifab_datum";
            this.colifab_datum.Visible = true;
            this.colifab_datum.VisibleIndex = 1;
            this.colifab_datum.Width = 149;
            // 
            // colifab_valuta
            // 
            this.colifab_valuta.Caption = "Datum valute";
            this.colifab_valuta.FieldName = "ifab_valuta";
            this.colifab_valuta.Name = "colifab_valuta";
            this.colifab_valuta.Visible = true;
            this.colifab_valuta.VisibleIndex = 2;
            this.colifab_valuta.Width = 143;
            // 
            // colifab_isporuka
            // 
            this.colifab_isporuka.Caption = "Datum isporuke";
            this.colifab_isporuka.FieldName = "ifab_isporuka";
            this.colifab_isporuka.Name = "colifab_isporuka";
            this.colifab_isporuka.Visible = true;
            this.colifab_isporuka.VisibleIndex = 3;
            this.colifab_isporuka.Width = 165;
            // 
            // colpartner_pa_ID
            // 
            this.colpartner_pa_ID.FieldName = "partner_pa_ID";
            this.colpartner_pa_ID.Name = "colpartner_pa_ID";
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.Caption = "Naziv partnera";
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 4;
            this.colPA_NAZIV.Width = 356;
            // 
            // colpa_sifra
            // 
            this.colpa_sifra.Caption = "Šifra partnera";
            this.colpa_sifra.FieldName = "pa_sifra";
            this.colpa_sifra.Name = "colpa_sifra";
            this.colpa_sifra.Visible = true;
            this.colpa_sifra.VisibleIndex = 5;
            this.colpa_sifra.Width = 105;
            // 
            // colifab_ukupno
            // 
            this.colifab_ukupno.Caption = "Ukupno";
            this.colifab_ukupno.FieldName = "ifab_ukupno";
            this.colifab_ukupno.Name = "colifab_ukupno";
            this.colifab_ukupno.Visible = true;
            this.colifab_ukupno.VisibleIndex = 6;
            this.colifab_ukupno.Width = 119;
            // 
            // colifab_status
            // 
            this.colifab_status.Caption = "Status";
            this.colifab_status.FieldName = "ifab_status";
            this.colifab_status.Name = "colifab_status";
            this.colifab_status.Visible = true;
            this.colifab_status.VisibleIndex = 7;
            this.colifab_status.Width = 76;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Operater";
            this.gridColumn1.FieldName = "concat (operater_op_ime,\' \',operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 387;
            // 
            // coloznaka
            // 
            this.coloznaka.Caption = "Označen";
            this.coloznaka.FieldName = "oznaka";
            this.coloznaka.Name = "coloznaka";
            this.coloznaka.Visible = true;
            this.coloznaka.VisibleIndex = 9;
            this.coloznaka.Width = 132;
            // 
            // ifaPrijenosTableAdapter
            // 
            this.ifaPrijenosTableAdapter.ClearBeforeFill = true;
            // 
            // dgBonovi2
            // 
            this.dgBonovi2.DataSource = this.bonPrijenosBindingSource;
            this.dgBonovi2.Location = new System.Drawing.Point(0, 151);
            this.dgBonovi2.MainView = this.dgBon2;
            this.dgBonovi2.Name = "dgBonovi2";
            this.dgBonovi2.Size = new System.Drawing.Size(990, 449);
            this.dgBonovi2.TabIndex = 28;
            this.dgBonovi2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgBon2});
            this.dgBonovi2.Visible = false;
            this.dgBonovi2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgBonovi2_KeyDown);
            // 
            // bonPrijenosBindingSource
            // 
            this.bonPrijenosBindingSource.DataMember = "bonPrijenos";
            this.bonPrijenosBindingSource.DataSource = this.zaPrijenosBonova;
            // 
            // zaPrijenosBonova
            // 
            this.zaPrijenosBonova.DataSetName = "zaPrijenosBonova";
            this.zaPrijenosBonova.EnforceConstraints = false;
            this.zaPrijenosBonova.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgBon2
            // 
            this.dgBon2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgBon2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgBon2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgBon2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgBon2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgBon2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgBon2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgBon2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgBon2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgBon2.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgBon2.Appearance.Empty.Options.UseBackColor = true;
            this.dgBon2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgBon2.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgBon2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgBon2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgBon2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgBon2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgBon2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgBon2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgBon2.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgBon2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgBon2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgBon2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgBon2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgBon2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgBon2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgBon2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgBon2.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgBon2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgBon2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgBon2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgBon2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgBon2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgBon2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgBon2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgBon2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgBon2.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgBon2.Appearance.GroupRow.Options.UseFont = true;
            this.dgBon2.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgBon2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgBon2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgBon2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgBon2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgBon2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgBon2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgBon2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgBon2.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgBon2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgBon2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgBon2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgBon2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgBon2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgBon2.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgBon2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgBon2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.OddRow.Options.UseBackColor = true;
            this.dgBon2.Appearance.OddRow.Options.UseForeColor = true;
            this.dgBon2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgBon2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgBon2.Appearance.Preview.Options.UseBackColor = true;
            this.dgBon2.Appearance.Preview.Options.UseForeColor = true;
            this.dgBon2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgBon2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.Row.Options.UseBackColor = true;
            this.dgBon2.Appearance.Row.Options.UseForeColor = true;
            this.dgBon2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgBon2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgBon2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgBon2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgBon2.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgBon2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgBon2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgBon2.Appearance.VertLine.Options.UseBackColor = true;
            this.dgBon2.ColumnPanelRowHeight = 50;
            this.dgBon2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbon_kod,
            this.colbon_ID,
            this.colbon_datumkoristenja,
            this.colPA_SIFRA1,
            this.colPA_NAZIV1,
            this.colpo_sifra,
            this.colpo_naziv,
            this.coliznos,
            this.colbon_datumbrojanja,
            this.colbon_datumizrade,
            this.colbon_iznos});
            this.dgBon2.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgBon2.GridControl = this.dgBonovi2;
            this.dgBon2.Name = "dgBon2";
            this.dgBon2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon2.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgBon2.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgBon2.OptionsBehavior.Editable = false;
            this.dgBon2.OptionsCustomization.AllowColumnMoving = false;
            this.dgBon2.OptionsCustomization.AllowFilter = false;
            this.dgBon2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgBon2.OptionsSelection.MultiSelect = true;
            this.dgBon2.OptionsView.EnableAppearanceEvenRow = true;
            this.dgBon2.OptionsView.EnableAppearanceOddRow = true;
            this.dgBon2.OptionsView.ShowAutoFilterRow = true;
            this.dgBon2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgBon2.OptionsView.ShowFooter = true;
            this.dgBon2.OptionsView.ShowGroupPanel = false;
            this.dgBon2.OptionsView.ShowIndicator = false;
            this.dgBon2.PaintStyleName = "WindowsXP";
            this.dgBon2.SynchronizeClones = false;
            // 
            // colbon_kod
            // 
            this.colbon_kod.Caption = "Barkod";
            this.colbon_kod.FieldName = "bon_kod";
            this.colbon_kod.Name = "colbon_kod";
            this.colbon_kod.Visible = true;
            this.colbon_kod.VisibleIndex = 0;
            this.colbon_kod.Width = 166;
            // 
            // colbon_ID
            // 
            this.colbon_ID.FieldName = "bon_ID";
            this.colbon_ID.Name = "colbon_ID";
            // 
            // colbon_datumkoristenja
            // 
            this.colbon_datumkoristenja.Caption = "Datum korištenja";
            this.colbon_datumkoristenja.FieldName = "bon_datumkoristenja";
            this.colbon_datumkoristenja.Name = "colbon_datumkoristenja";
            this.colbon_datumkoristenja.Visible = true;
            this.colbon_datumkoristenja.VisibleIndex = 1;
            this.colbon_datumkoristenja.Width = 146;
            // 
            // colPA_SIFRA1
            // 
            this.colPA_SIFRA1.Caption = "Šifra partnera";
            this.colPA_SIFRA1.FieldName = "PA_SIFRA";
            this.colPA_SIFRA1.Name = "colPA_SIFRA1";
            this.colPA_SIFRA1.Visible = true;
            this.colPA_SIFRA1.VisibleIndex = 2;
            this.colPA_SIFRA1.Width = 151;
            // 
            // colPA_NAZIV1
            // 
            this.colPA_NAZIV1.Caption = "Naziv partnera";
            this.colPA_NAZIV1.FieldName = "PA_NAZIV";
            this.colPA_NAZIV1.Name = "colPA_NAZIV1";
            this.colPA_NAZIV1.Visible = true;
            this.colPA_NAZIV1.VisibleIndex = 3;
            this.colPA_NAZIV1.Width = 426;
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.Caption = "Šifra poslovnice";
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            this.colpo_sifra.Visible = true;
            this.colpo_sifra.VisibleIndex = 4;
            this.colpo_sifra.Width = 133;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Naziv poslovnice";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 5;
            this.colpo_naziv.Width = 416;
            // 
            // coliznos
            // 
            this.coliznos.Caption = "Iznos računa";
            this.coliznos.FieldName = "iznos";
            this.coliznos.Name = "coliznos";
            this.coliznos.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.coliznos.Visible = true;
            this.coliznos.VisibleIndex = 6;
            this.coliznos.Width = 147;
            // 
            // colbon_datumbrojanja
            // 
            this.colbon_datumbrojanja.Caption = "Datum brojanja";
            this.colbon_datumbrojanja.FieldName = "bon_datumbrojanja";
            this.colbon_datumbrojanja.Name = "colbon_datumbrojanja";
            this.colbon_datumbrojanja.Visible = true;
            this.colbon_datumbrojanja.VisibleIndex = 7;
            this.colbon_datumbrojanja.Width = 146;
            // 
            // colbon_datumizrade
            // 
            this.colbon_datumizrade.FieldName = "bon_datumizrade";
            this.colbon_datumizrade.Name = "colbon_datumizrade";
            // 
            // colbon_iznos
            // 
            this.colbon_iznos.FieldName = "bon_iznos";
            this.colbon_iznos.Name = "colbon_iznos";
            // 
            // bonoviPrijenosBindingSource
            // 
            this.bonoviPrijenosBindingSource.DataMember = "bonoviPrijenos";
            this.bonoviPrijenosBindingSource.DataSource = this.zaPrijenosBonova;
            // 
            // bonoviPrijenosTableAdapter
            // 
            this.bonoviPrijenosTableAdapter.ClearBeforeFill = true;
            // 
            // bonPrijenosTableAdapter
            // 
            this.bonPrijenosTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrijenosIFA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.dgBonovi2);
            this.Controls.Add(this.dgBonovi);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPrijenosIFA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijenos IFA";
            this.Load += new System.EventHandler(this.frmPrijenosIFA_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrijenosIFA_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbOdabirDiskontaIdatBr.ResumeLayout(false);
            this.gbOdabirDiskontaIdatBr.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifaPrijenosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaPrijenosIFA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonPrijenosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaPrijenosBonova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonoviPrijenosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrenesi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgBonovi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgBon;
        private System.Windows.Forms.DateTimePicker dtpDatumDO;
        private System.Windows.Forms.DateTimePicker dtpDatumOD;
        private System.Windows.Forms.BindingSource ifaPrijenosBindingSource;
        private zaPrijenosIFA zaPrijenosIFA;
        private zaPrijenosIFATableAdapters.IfaPrijenosTableAdapter ifaPrijenosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_datum;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_valuta;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_isporuka;
        private DevExpress.XtraGrid.Columns.GridColumn colpartner_pa_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_ukupno;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_status;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn coloznaka;
        private System.Windows.Forms.RadioButton rbBB;
        private DevExpress.XtraGrid.GridControl dgBonovi2;
        private DevExpress.XtraGrid.Views.Grid.GridView dgBon2;
        private zaPrijenosBonova zaPrijenosBonova;
        private System.Windows.Forms.BindingSource bonoviPrijenosBindingSource;
        private zaPrijenosBonovaTableAdapters.bonoviPrijenosTableAdapter bonoviPrijenosTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_datumkoristenja;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA1;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV1;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private System.Windows.Forms.DateTimePicker dtpBrojanje;
        private System.Windows.Forms.Label lblDatumBrojanja;
        private System.Windows.Forms.GroupBox gbOdabirDiskontaIdatBr;
        private System.Windows.Forms.RadioButton rbTrgovine;
        private System.Windows.Forms.RadioButton rbDiskonti;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_datumbrojanja;
        private System.Windows.Forms.Label lblStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_datumizrade;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_iznos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bonPrijenosBindingSource;
        private zaPrijenosBonovaTableAdapters.bonPrijenosTableAdapter bonPrijenosTableAdapter;
        private System.Windows.Forms.Button btnVrati;
        private DevExpress.XtraGrid.Columns.GridColumn coliznos;
    }
}