namespace Bonovi
{
    partial class frmFakturirani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFakturirani));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.glPartner = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partner = new Bonovi.Partner();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDoKada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOdKada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAzuriraj = new System.Windows.Forms.Panel();
            this.dtpIsporuka = new System.Windows.Forms.DateTimePicker();
            this.dtpValuta = new System.Windows.Forms.DateTimePicker();
            this.dtpDokumenta = new System.Windows.Forms.DateTimePicker();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUkupnoIzdano = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dgBonovi = new DevExpress.XtraGrid.GridControl();
            this.bonoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakturirani_bonovi = new Bonovi.Fakturirani_bonovi();
            this.dgBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colifab_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_ukupno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_datum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpa_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_datumknjizenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partnerTableAdapter = new Bonovi.PartnerTableAdapters.partnerTableAdapter();
            this.bonoviTableAdapter = new Bonovi.Fakturirani_bonoviTableAdapters.bonoviTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAzuriraj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUkupnoIzdano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturirani_bonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPrikazi);
            this.panel1.Controls.Add(this.glPartner);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpDoKada);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpOdKada);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 75);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(712, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "F7 - izmjena datuma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(912, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "F9 - storno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "F8 - račun ispis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "F5 - lista";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "F3 - specifikacija";
            this.label5.Visible = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(443, 42);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 13;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // glPartner
            // 
            this.glPartner.EditValue = "";
            this.glPartner.Location = new System.Drawing.Point(92, 43);
            this.glPartner.Name = "glPartner";
            this.glPartner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPartner.Properties.DataSource = this.partnerBindingSource;
            this.glPartner.Properties.DisplayMember = "PA_NAZIV";
            this.glPartner.Properties.ValueMember = "PA_ID";
            this.glPartner.Properties.View = this.gridLookUpEdit1View;
            this.glPartner.Size = new System.Drawing.Size(331, 20);
            this.glPartner.TabIndex = 12;
            this.glPartner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glPartner_KeyDown);
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "partner";
            this.partnerBindingSource.DataSource = this.partner;
            // 
            // partner
            // 
            this.partner.DataSetName = "Partner";
            this.partner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPA_ID,
            this.colPA_NAZIV,
            this.colPA_SIFRA});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPA_NAZIV, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colPA_ID
            // 
            this.colPA_ID.FieldName = "PA_ID";
            this.colPA_ID.Name = "colPA_ID";
            // 
            // colPA_NAZIV
            // 
            this.colPA_NAZIV.FieldName = "PA_NAZIV";
            this.colPA_NAZIV.Name = "colPA_NAZIV";
            this.colPA_NAZIV.Visible = true;
            this.colPA_NAZIV.VisibleIndex = 1;
            this.colPA_NAZIV.Width = 1515;
            // 
            // colPA_SIFRA
            // 
            this.colPA_SIFRA.FieldName = "PA_SIFRA";
            this.colPA_SIFRA.Name = "colPA_SIFRA";
            this.colPA_SIFRA.Visible = true;
            this.colPA_SIFRA.VisibleIndex = 0;
            this.colPA_SIFRA.Width = 215;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Za partnera:";
            // 
            // dtpDoKada
            // 
            this.dtpDoKada.CustomFormat = " ";
            this.dtpDoKada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoKada.Location = new System.Drawing.Point(296, 14);
            this.dtpDoKada.Name = "dtpDoKada";
            this.dtpDoKada.Size = new System.Drawing.Size(127, 20);
            this.dtpDoKada.TabIndex = 10;
            this.dtpDoKada.ValueChanged += new System.EventHandler(this.dtpDoKada_ValueChanged);
            this.dtpDoKada.Enter += new System.EventHandler(this.dtpDoKada_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "do datuma:";
            // 
            // dtpOdKada
            // 
            this.dtpOdKada.CustomFormat = " ";
            this.dtpOdKada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOdKada.Location = new System.Drawing.Point(92, 14);
            this.dtpOdKada.Name = "dtpOdKada";
            this.dtpOdKada.Size = new System.Drawing.Size(127, 20);
            this.dtpOdKada.TabIndex = 8;
            this.dtpOdKada.ValueChanged += new System.EventHandler(this.dtpOdKada_ValueChanged);
            this.dtpOdKada.Enter += new System.EventHandler(this.dtpOdKada_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Od datuma:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlAzuriraj);
            this.panel2.Controls.Add(this.txtUkupnoIzdano);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 119);
            this.panel2.TabIndex = 9;
            // 
            // pnlAzuriraj
            // 
            this.pnlAzuriraj.Controls.Add(this.dtpIsporuka);
            this.pnlAzuriraj.Controls.Add(this.dtpValuta);
            this.pnlAzuriraj.Controls.Add(this.dtpDokumenta);
            this.pnlAzuriraj.Controls.Add(this.txtOpis);
            this.pnlAzuriraj.Controls.Add(this.label10);
            this.pnlAzuriraj.Controls.Add(this.btnSpremi);
            this.pnlAzuriraj.Controls.Add(this.label11);
            this.pnlAzuriraj.Controls.Add(this.label12);
            this.pnlAzuriraj.Controls.Add(this.label13);
            this.pnlAzuriraj.Location = new System.Drawing.Point(403, 9);
            this.pnlAzuriraj.Name = "pnlAzuriraj";
            this.pnlAzuriraj.Size = new System.Drawing.Size(555, 98);
            this.pnlAzuriraj.TabIndex = 21;
            this.pnlAzuriraj.Visible = false;
            // 
            // dtpIsporuka
            // 
            this.dtpIsporuka.CustomFormat = " ";
            this.dtpIsporuka.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIsporuka.Location = new System.Drawing.Point(299, 40);
            this.dtpIsporuka.Name = "dtpIsporuka";
            this.dtpIsporuka.Size = new System.Drawing.Size(127, 20);
            this.dtpIsporuka.TabIndex = 5;
            this.dtpIsporuka.ValueChanged += new System.EventHandler(this.dtpIsporuka_ValueChanged);
            this.dtpIsporuka.Enter += new System.EventHandler(this.dtpIsporuka_Enter);
            // 
            // dtpValuta
            // 
            this.dtpValuta.CustomFormat = " ";
            this.dtpValuta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValuta.Location = new System.Drawing.Point(156, 40);
            this.dtpValuta.Name = "dtpValuta";
            this.dtpValuta.Size = new System.Drawing.Size(127, 20);
            this.dtpValuta.TabIndex = 4;
            this.dtpValuta.ValueChanged += new System.EventHandler(this.dtpValuta_ValueChanged);
            this.dtpValuta.Enter += new System.EventHandler(this.dtpValuta_Enter);
            // 
            // dtpDokumenta
            // 
            this.dtpDokumenta.CustomFormat = " ";
            this.dtpDokumenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDokumenta.Location = new System.Drawing.Point(12, 40);
            this.dtpDokumenta.Name = "dtpDokumenta";
            this.dtpDokumenta.Size = new System.Drawing.Size(127, 20);
            this.dtpDokumenta.TabIndex = 3;
            this.dtpDokumenta.ValueChanged += new System.EventHandler(this.dtpDokumenta_ValueChanged);
            this.dtpDokumenta.Enter += new System.EventHandler(this.dtpDokumenta_Enter);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(53, 70);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(373, 20);
            this.txtOpis.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Opis:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(462, 68);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Datum isporuke";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Datum valute";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Datum dokumenta";
            // 
            // txtUkupnoIzdano
            // 
            this.txtUkupnoIzdano.Enabled = false;
            this.txtUkupnoIzdano.Location = new System.Drawing.Point(195, 21);
            this.txtUkupnoIzdano.Name = "txtUkupnoIzdano";
            this.txtUkupnoIzdano.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtUkupnoIzdano.Properties.Appearance.Options.UseForeColor = true;
            this.txtUkupnoIzdano.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtUkupnoIzdano.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtUkupnoIzdano.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtUkupnoIzdano.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtUkupnoIzdano.Properties.DisplayFormat.FormatString = "c2";
            this.txtUkupnoIzdano.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUkupnoIzdano.Properties.Mask.EditMask = "c2";
            this.txtUkupnoIzdano.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUkupnoIzdano.Size = new System.Drawing.Size(143, 20);
            this.txtUkupnoIzdano.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ukupno izdano računa:";
            // 
            // dgBonovi
            // 
            this.dgBonovi.DataSource = this.bonoviBindingSource;
            this.dgBonovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBonovi.Location = new System.Drawing.Point(0, 75);
            this.dgBonovi.MainView = this.dgBon;
            this.dgBonovi.Name = "dgBonovi";
            this.dgBonovi.Size = new System.Drawing.Size(981, 410);
            this.dgBonovi.TabIndex = 10;
            this.dgBonovi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgBon});
            this.dgBonovi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgBonovi_KeyDown);
            // 
            // bonoviBindingSource
            // 
            this.bonoviBindingSource.DataMember = "bonovi";
            this.bonoviBindingSource.DataSource = this.fakturirani_bonovi;
            // 
            // fakturirani_bonovi
            // 
            this.fakturirani_bonovi.DataSetName = "Fakturirani_bonovi";
            this.fakturirani_bonovi.EnforceConstraints = false;
            this.fakturirani_bonovi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colPA_SIFRA1,
            this.colPA_NAZIV1,
            this.colifab_ukupno,
            this.colifab_status,
            this.colifab_datum,
            this.gridColumn1,
            this.colpa_ID1,
            this.colifab_datumknjizenja});
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
            // 
            // colifab_ID
            // 
            this.colifab_ID.Caption = "Broj računa";
            this.colifab_ID.FieldName = "ifab_ID";
            this.colifab_ID.Name = "colifab_ID";
            this.colifab_ID.Visible = true;
            this.colifab_ID.VisibleIndex = 2;
            this.colifab_ID.Width = 125;
            // 
            // colPA_SIFRA1
            // 
            this.colPA_SIFRA1.Caption = "Šifra";
            this.colPA_SIFRA1.FieldName = "PA_SIFRA";
            this.colPA_SIFRA1.Name = "colPA_SIFRA1";
            this.colPA_SIFRA1.Visible = true;
            this.colPA_SIFRA1.VisibleIndex = 0;
            this.colPA_SIFRA1.Width = 151;
            // 
            // colPA_NAZIV1
            // 
            this.colPA_NAZIV1.Caption = "Naziv kupca";
            this.colPA_NAZIV1.FieldName = "PA_NAZIV";
            this.colPA_NAZIV1.Name = "colPA_NAZIV1";
            this.colPA_NAZIV1.Visible = true;
            this.colPA_NAZIV1.VisibleIndex = 1;
            this.colPA_NAZIV1.Width = 391;
            // 
            // colifab_ukupno
            // 
            this.colifab_ukupno.Caption = "Iznos";
            this.colifab_ukupno.FieldName = "ifab_ukupno";
            this.colifab_ukupno.Name = "colifab_ukupno";
            this.colifab_ukupno.Visible = true;
            this.colifab_ukupno.VisibleIndex = 3;
            this.colifab_ukupno.Width = 135;
            // 
            // colifab_status
            // 
            this.colifab_status.Caption = "Status";
            this.colifab_status.FieldName = "ifab_status";
            this.colifab_status.Name = "colifab_status";
            this.colifab_status.Visible = true;
            this.colifab_status.VisibleIndex = 4;
            this.colifab_status.Width = 111;
            // 
            // colifab_datum
            // 
            this.colifab_datum.Caption = "Datum računa";
            this.colifab_datum.FieldName = "ifab_datum";
            this.colifab_datum.Name = "colifab_datum";
            this.colifab_datum.Visible = true;
            this.colifab_datum.VisibleIndex = 5;
            this.colifab_datum.Width = 182;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Operater";
            this.gridColumn1.FieldName = "concat(operater_op_ime,\' \',operater_op_prezime)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            this.gridColumn1.Width = 506;
            // 
            // colpa_ID1
            // 
            this.colpa_ID1.FieldName = "pa_ID";
            this.colpa_ID1.Name = "colpa_ID1";
            // 
            // colifab_datumknjizenja
            // 
            this.colifab_datumknjizenja.Caption = "Knjižen";
            this.colifab_datumknjizenja.FieldName = "ifab_datumknjizenja";
            this.colifab_datumknjizenja.Name = "colifab_datumknjizenja";
            this.colifab_datumknjizenja.Visible = true;
            this.colifab_datumknjizenja.VisibleIndex = 7;
            this.colifab_datumknjizenja.Width = 130;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // bonoviTableAdapter
            // 
            this.bonoviTableAdapter.ClearBeforeFill = true;
            // 
            // frmFakturirani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 604);
            this.Controls.Add(this.dgBonovi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmFakturirani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled faktura";
            this.Load += new System.EventHandler(this.frmFakturirani_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFakturirani_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAzuriraj.ResumeLayout(false);
            this.pnlAzuriraj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUkupnoIzdano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturirani_bonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgBonovi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgBon;
        private System.Windows.Forms.Button btnPrikazi;
        private DevExpress.XtraEditors.GridLookUpEdit glPartner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDoKada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOdKada;
        private System.Windows.Forms.Label label1;
        private Partner partner;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private PartnerTableAdapters.partnerTableAdapter partnerTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtUkupnoIzdano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bonoviBindingSource;
        private Fakturirani_bonovi fakturirani_bonovi;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA1;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV1;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_ukupno;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_status;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_datum;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private Fakturirani_bonoviTableAdapters.bonoviTableAdapter bonoviTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn colpa_ID1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlAzuriraj;
        private System.Windows.Forms.DateTimePicker dtpIsporuka;
        private System.Windows.Forms.DateTimePicker dtpValuta;
        private System.Windows.Forms.DateTimePicker dtpDokumenta;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_datumknjizenja;
    }
}