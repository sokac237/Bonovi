namespace Bonovi
{
    partial class frmPregledBonova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledBonova));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.bonoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdani_bonovi = new Bonovi.Izdani_bonovi();
            this.partnerTableAdapter = new Bonovi.PartnerTableAdapters.partnerTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bonoviTableAdapter = new Bonovi.Izdani_bonoviTableAdapters.bonoviTableAdapter();
            this.txtUkupnoIzdano = new DevExpress.XtraEditors.TextEdit();
            this.txtUkupnoIskoristeno = new DevExpress.XtraEditors.TextEdit();
            this.txtFakturirano = new DevExpress.XtraEditors.TextEdit();
            this.txtPonisteno = new DevExpress.XtraEditors.TextEdit();
            this.txtNijeIskoristeno = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAzuriranjeBona = new System.Windows.Forms.Panel();
            this.txtIznosRacuna = new DevExpress.XtraEditors.TextEdit();
            this.label22 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.glPoslovnica = new DevExpress.XtraEditors.GridLookUpEdit();
            this.poslovnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operater = new Bonovi.Operater();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpo_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBosoKartica = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.glOperater = new DevExpress.XtraEditors.GridLookUpEdit();
            this.operaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colop_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colop_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.txtRacunKasa = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBrojKasa = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpDatKor = new System.Windows.Forms.DateTimePicker();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.dgBonovi = new DevExpress.XtraGrid.GridControl();
            this.dgBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbon_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_rednibroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumizrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_iznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumkoristenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_iznosracuna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_ponisten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliskoristeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_napomena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operaterTableAdapter = new Bonovi.OperaterTableAdapters.operaterTableAdapter();
            this.poslovnicaTableAdapter = new Bonovi.OperaterTableAdapters.poslovnicaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdani_bonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUkupnoIzdano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUkupnoIskoristeno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFakturirano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPonisteno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNijeIskoristeno.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAzuriranjeBona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIznosRacuna.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glOperater.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
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
            this.panel1.Size = new System.Drawing.Size(1095, 103);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(839, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "F7 - unos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(904, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "F8 - ispis bona";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(713, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "F6 - pregled iskorištenih";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(608, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "F5 - pregled izdanih";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "F4 - nije iskorišteno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "F3 - poništi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "F2 - detalji bona";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(392, 49);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 6;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // glPartner
            // 
            this.glPartner.EditValue = "";
            this.glPartner.Location = new System.Drawing.Point(77, 50);
            this.glPartner.Name = "glPartner";
            this.glPartner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPartner.Properties.DataSource = this.partnerBindingSource;
            this.glPartner.Properties.DisplayMember = "PA_NAZIV";
            this.glPartner.Properties.ValueMember = "PA_ID";
            this.glPartner.Properties.View = this.gridLookUpEdit1View;
            this.glPartner.Size = new System.Drawing.Size(300, 20);
            this.glPartner.TabIndex = 5;
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
            this.colPA_NAZIV.Width = 899;
            // 
            // colPA_SIFRA
            // 
            this.colPA_SIFRA.FieldName = "PA_SIFRA";
            this.colPA_SIFRA.Name = "colPA_SIFRA";
            this.colPA_SIFRA.Visible = true;
            this.colPA_SIFRA.VisibleIndex = 0;
            this.colPA_SIFRA.Width = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Za partnera:";
            // 
            // dtpDoKada
            // 
            this.dtpDoKada.CustomFormat = " ";
            this.dtpDoKada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoKada.Location = new System.Drawing.Point(265, 20);
            this.dtpDoKada.Name = "dtpDoKada";
            this.dtpDoKada.Size = new System.Drawing.Size(112, 20);
            this.dtpDoKada.TabIndex = 3;
            this.dtpDoKada.ValueChanged += new System.EventHandler(this.dtpDoKada_ValueChanged);
            this.dtpDoKada.Enter += new System.EventHandler(this.dtpDoKada_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "do datuma:";
            // 
            // dtpOdKada
            // 
            this.dtpOdKada.CustomFormat = " ";
            this.dtpOdKada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOdKada.Location = new System.Drawing.Point(77, 21);
            this.dtpOdKada.Name = "dtpOdKada";
            this.dtpOdKada.Size = new System.Drawing.Size(115, 20);
            this.dtpOdKada.TabIndex = 1;
            this.dtpOdKada.ValueChanged += new System.EventHandler(this.dtpOdKada_ValueChanged);
            this.dtpOdKada.Enter += new System.EventHandler(this.dtpOdKada_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od datuma:";
            // 
            // bonoviBindingSource
            // 
            this.bonoviBindingSource.DataMember = "bonovi";
            this.bonoviBindingSource.DataSource = this.izdani_bonovi;
            // 
            // izdani_bonovi
            // 
            this.izdani_bonovi.DataSetName = "Izdani_bonovi";
            this.izdani_bonovi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ukupno izdano bonova:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(51, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Od toga iskorišteno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fakturirano:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Poništeno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(68, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nije iskorišteno:";
            // 
            // bonoviTableAdapter
            // 
            this.bonoviTableAdapter.ClearBeforeFill = true;
            // 
            // txtUkupnoIzdano
            // 
            this.txtUkupnoIzdano.Enabled = false;
            this.txtUkupnoIzdano.Location = new System.Drawing.Point(158, 13);
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
            this.txtUkupnoIzdano.TabIndex = 18;
            // 
            // txtUkupnoIskoristeno
            // 
            this.txtUkupnoIskoristeno.Enabled = false;
            this.txtUkupnoIskoristeno.Location = new System.Drawing.Point(158, 40);
            this.txtUkupnoIskoristeno.Name = "txtUkupnoIskoristeno";
            this.txtUkupnoIskoristeno.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtUkupnoIskoristeno.Properties.Appearance.Options.UseForeColor = true;
            this.txtUkupnoIskoristeno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtUkupnoIskoristeno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtUkupnoIskoristeno.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtUkupnoIskoristeno.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtUkupnoIskoristeno.Properties.Mask.EditMask = "c2";
            this.txtUkupnoIskoristeno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUkupnoIskoristeno.Size = new System.Drawing.Size(143, 20);
            this.txtUkupnoIskoristeno.TabIndex = 19;
            // 
            // txtFakturirano
            // 
            this.txtFakturirano.Enabled = false;
            this.txtFakturirano.Location = new System.Drawing.Point(158, 67);
            this.txtFakturirano.Name = "txtFakturirano";
            this.txtFakturirano.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtFakturirano.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtFakturirano.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtFakturirano.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtFakturirano.Properties.Mask.EditMask = "c2";
            this.txtFakturirano.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFakturirano.Size = new System.Drawing.Size(143, 20);
            this.txtFakturirano.TabIndex = 20;
            // 
            // txtPonisteno
            // 
            this.txtPonisteno.Enabled = false;
            this.txtPonisteno.Location = new System.Drawing.Point(158, 94);
            this.txtPonisteno.Name = "txtPonisteno";
            this.txtPonisteno.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtPonisteno.Properties.Appearance.Options.UseForeColor = true;
            this.txtPonisteno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtPonisteno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtPonisteno.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtPonisteno.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtPonisteno.Properties.Mask.EditMask = "c2";
            this.txtPonisteno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPonisteno.Size = new System.Drawing.Size(143, 20);
            this.txtPonisteno.TabIndex = 21;
            // 
            // txtNijeIskoristeno
            // 
            this.txtNijeIskoristeno.Enabled = false;
            this.txtNijeIskoristeno.Location = new System.Drawing.Point(158, 120);
            this.txtNijeIskoristeno.Name = "txtNijeIskoristeno";
            this.txtNijeIskoristeno.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtNijeIskoristeno.Properties.Appearance.Options.UseForeColor = true;
            this.txtNijeIskoristeno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtNijeIskoristeno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtNijeIskoristeno.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtNijeIskoristeno.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtNijeIskoristeno.Properties.Mask.EditMask = "c2";
            this.txtNijeIskoristeno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNijeIskoristeno.Size = new System.Drawing.Size(143, 20);
            this.txtNijeIskoristeno.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlAzuriranjeBona);
            this.panel2.Controls.Add(this.txtUkupnoIzdano);
            this.panel2.Controls.Add(this.txtNijeIskoristeno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPonisteno);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtFakturirano);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtUkupnoIskoristeno);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 149);
            this.panel2.TabIndex = 23;
            // 
            // pnlAzuriranjeBona
            // 
            this.pnlAzuriranjeBona.Controls.Add(this.txtIznosRacuna);
            this.pnlAzuriranjeBona.Controls.Add(this.label22);
            this.pnlAzuriranjeBona.Controls.Add(this.btnSpremi);
            this.pnlAzuriranjeBona.Controls.Add(this.glPoslovnica);
            this.pnlAzuriranjeBona.Controls.Add(this.txtBosoKartica);
            this.pnlAzuriranjeBona.Controls.Add(this.label21);
            this.pnlAzuriranjeBona.Controls.Add(this.label20);
            this.pnlAzuriranjeBona.Controls.Add(this.glOperater);
            this.pnlAzuriranjeBona.Controls.Add(this.label19);
            this.pnlAzuriranjeBona.Controls.Add(this.txtRacunKasa);
            this.pnlAzuriranjeBona.Controls.Add(this.label18);
            this.pnlAzuriranjeBona.Controls.Add(this.txtBrojKasa);
            this.pnlAzuriranjeBona.Controls.Add(this.label17);
            this.pnlAzuriranjeBona.Controls.Add(this.label16);
            this.pnlAzuriranjeBona.Controls.Add(this.dtpDatKor);
            this.pnlAzuriranjeBona.Controls.Add(this.lblPoruka);
            this.pnlAzuriranjeBona.Location = new System.Drawing.Point(353, 16);
            this.pnlAzuriranjeBona.Name = "pnlAzuriranjeBona";
            this.pnlAzuriranjeBona.Size = new System.Drawing.Size(593, 123);
            this.pnlAzuriranjeBona.TabIndex = 23;
            this.pnlAzuriranjeBona.Visible = false;
            // 
            // txtIznosRacuna
            // 
            this.txtIznosRacuna.Location = new System.Drawing.Point(308, 7);
            this.txtIznosRacuna.Name = "txtIznosRacuna";
            this.txtIznosRacuna.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtIznosRacuna.Properties.Appearance.Options.UseForeColor = true;
            this.txtIznosRacuna.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtIznosRacuna.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtIznosRacuna.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtIznosRacuna.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtIznosRacuna.Properties.Mask.EditMask = "n2";
            this.txtIznosRacuna.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIznosRacuna.Size = new System.Drawing.Size(124, 20);
            this.txtIznosRacuna.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(267, 10);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Iznos:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(506, 92);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // glPoslovnica
            // 
            this.glPoslovnica.EditValue = "";
            this.glPoslovnica.Location = new System.Drawing.Point(308, 62);
            this.glPoslovnica.Name = "glPoslovnica";
            this.glPoslovnica.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPoslovnica.Properties.DataSource = this.poslovnicaBindingSource;
            this.glPoslovnica.Properties.DisplayMember = "po_naziv";
            this.glPoslovnica.Properties.ValueMember = "po_ID";
            this.glPoslovnica.Properties.View = this.gridView2;
            this.glPoslovnica.Size = new System.Drawing.Size(239, 20);
            this.glPoslovnica.TabIndex = 13;
            // 
            // poslovnicaBindingSource
            // 
            this.poslovnicaBindingSource.DataMember = "poslovnica";
            this.poslovnicaBindingSource.DataSource = this.operater;
            // 
            // operater
            // 
            this.operater.DataSetName = "Operater";
            this.operater.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpo_ID,
            this.colpo_sifra,
            this.colpo_naziv});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colpo_ID
            // 
            this.colpo_ID.FieldName = "po_ID";
            this.colpo_ID.Name = "colpo_ID";
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.Caption = "Šifra";
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            this.colpo_sifra.Visible = true;
            this.colpo_sifra.VisibleIndex = 0;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Naziv";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 1;
            // 
            // txtBosoKartica
            // 
            this.txtBosoKartica.Location = new System.Drawing.Point(308, 92);
            this.txtBosoKartica.Name = "txtBosoKartica";
            this.txtBosoKartica.Size = new System.Drawing.Size(158, 20);
            this.txtBosoKartica.TabIndex = 14;
            this.txtBosoKartica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBosoKartica_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(214, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Boso kartica broj:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(240, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Poslovnica:";
            // 
            // glOperater
            // 
            this.glOperater.EditValue = "";
            this.glOperater.Location = new System.Drawing.Point(308, 33);
            this.glOperater.Name = "glOperater";
            this.glOperater.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glOperater.Properties.DataSource = this.operaterBindingSource;
            this.glOperater.Properties.DisplayMember = "concat(operater_op_ime, \' \' , operater_op_prezime)";
            this.glOperater.Properties.ValueMember = "op_ID";
            this.glOperater.Properties.View = this.gridView1;
            this.glOperater.Size = new System.Drawing.Size(239, 20);
            this.glOperater.TabIndex = 9;
            this.glOperater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glOperater_KeyDown);
            // 
            // operaterBindingSource
            // 
            this.operaterBindingSource.DataMember = "operater";
            this.operaterBindingSource.DataSource = this.operater;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colop_ID,
            this.colop_sifra,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colop_ID
            // 
            this.colop_ID.FieldName = "op_ID";
            this.colop_ID.Name = "colop_ID";
            // 
            // colop_sifra
            // 
            this.colop_sifra.Caption = "Sifra";
            this.colop_sifra.FieldName = "op_sifra";
            this.colop_sifra.Name = "colop_sifra";
            this.colop_sifra.Visible = true;
            this.colop_sifra.VisibleIndex = 0;
            this.colop_sifra.Width = 362;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Operater";
            this.gridColumn2.FieldName = "concat(operater_op_ime, \' \' , operater_op_prezime)";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1344;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(214, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Operater na kasi:";
            // 
            // txtRacunKasa
            // 
            this.txtRacunKasa.Location = new System.Drawing.Point(122, 92);
            this.txtRacunKasa.MaxLength = 10;
            this.txtRacunKasa.Name = "txtRacunKasa";
            this.txtRacunKasa.Size = new System.Drawing.Size(79, 20);
            this.txtRacunKasa.TabIndex = 7;
            this.txtRacunKasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRacunKasa_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Račun na kasi:";
            // 
            // txtBrojKasa
            // 
            this.txtBrojKasa.Location = new System.Drawing.Point(122, 65);
            this.txtBrojKasa.MaxLength = 2;
            this.txtBrojKasa.Name = "txtBrojKasa";
            this.txtBrojKasa.Size = new System.Drawing.Size(79, 20);
            this.txtBrojKasa.TabIndex = 5;
            this.txtBrojKasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojKasa_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Broj kase:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Dat. korištenja:";
            // 
            // dtpDatKor
            // 
            this.dtpDatKor.CustomFormat = " ";
            this.dtpDatKor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatKor.Location = new System.Drawing.Point(101, 33);
            this.dtpDatKor.Name = "dtpDatKor";
            this.dtpDatKor.Size = new System.Drawing.Size(100, 20);
            this.dtpDatKor.TabIndex = 2;
            this.dtpDatKor.ValueChanged += new System.EventHandler(this.dtpDatKor_ValueChanged);
            this.dtpDatKor.Enter += new System.EventHandler(this.dtpDatKor_Enter);
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.ForeColor = System.Drawing.Color.Red;
            this.lblPoruka.Location = new System.Drawing.Point(17, 10);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(0, 13);
            this.lblPoruka.TabIndex = 0;
            // 
            // dgBonovi
            // 
            this.dgBonovi.DataSource = this.bonoviBindingSource;
            this.dgBonovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBonovi.Location = new System.Drawing.Point(0, 103);
            this.dgBonovi.MainView = this.dgBon;
            this.dgBonovi.Name = "dgBonovi";
            this.dgBonovi.Size = new System.Drawing.Size(1095, 407);
            this.dgBonovi.TabIndex = 24;
            this.dgBonovi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgBon});
            this.dgBonovi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgBonovi_KeyDown);
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
            this.colbon_kod,
            this.colbon_rednibroj,
            this.colbon_datumizrade,
            this.colbon_iznos,
            this.colbon_datumkoristenja,
            this.colPA_NAZIV1,
            this.colbon_iznosracuna,
            this.colifab_ID,
            this.gridColumn3,
            this.colbon_ponisten,
            this.coliskoristeno,
            this.colpo_naziv1,
            this.colbon_id,
            this.colbon_napomena});
            this.dgBon.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgBon.GridControl = this.dgBonovi;
            this.dgBon.Name = "dgBon";
            this.dgBon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgBon.OptionsBehavior.AutoUpdateTotalSummary = false;
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
            this.dgBon.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.dgBon_SelectionChanged);
            this.dgBon.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.dgBon_RowUpdated);
            // 
            // colbon_kod
            // 
            this.colbon_kod.Caption = "Šifra bona";
            this.colbon_kod.FieldName = "bon_kod";
            this.colbon_kod.Name = "colbon_kod";
            this.colbon_kod.OptionsColumn.AllowEdit = false;
            this.colbon_kod.Visible = true;
            this.colbon_kod.VisibleIndex = 0;
            this.colbon_kod.Width = 113;
            // 
            // colbon_rednibroj
            // 
            this.colbon_rednibroj.Caption = "Potvrda broj";
            this.colbon_rednibroj.FieldName = "bon_rednibroj";
            this.colbon_rednibroj.Name = "colbon_rednibroj";
            this.colbon_rednibroj.OptionsColumn.AllowEdit = false;
            this.colbon_rednibroj.Visible = true;
            this.colbon_rednibroj.VisibleIndex = 2;
            this.colbon_rednibroj.Width = 104;
            // 
            // colbon_datumizrade
            // 
            this.colbon_datumizrade.Caption = "Izdano";
            this.colbon_datumizrade.FieldName = "bon_datumizrade";
            this.colbon_datumizrade.Name = "colbon_datumizrade";
            this.colbon_datumizrade.OptionsColumn.AllowEdit = false;
            this.colbon_datumizrade.Visible = true;
            this.colbon_datumizrade.VisibleIndex = 3;
            this.colbon_datumizrade.Width = 114;
            // 
            // colbon_iznos
            // 
            this.colbon_iznos.Caption = "Na iznos";
            this.colbon_iznos.DisplayFormat.FormatString = "c2";
            this.colbon_iznos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbon_iznos.FieldName = "bon_iznos";
            this.colbon_iznos.GroupFormat.FormatString = "c2";
            this.colbon_iznos.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbon_iznos.Name = "colbon_iznos";
            this.colbon_iznos.OptionsColumn.AllowEdit = false;
            this.colbon_iznos.Visible = true;
            this.colbon_iznos.VisibleIndex = 4;
            this.colbon_iznos.Width = 122;
            // 
            // colbon_datumkoristenja
            // 
            this.colbon_datumkoristenja.Caption = "Iskorišten";
            this.colbon_datumkoristenja.FieldName = "bon_datumkoristenja";
            this.colbon_datumkoristenja.Name = "colbon_datumkoristenja";
            this.colbon_datumkoristenja.OptionsColumn.AllowEdit = false;
            this.colbon_datumkoristenja.Visible = true;
            this.colbon_datumkoristenja.VisibleIndex = 5;
            this.colbon_datumkoristenja.Width = 106;
            // 
            // colPA_NAZIV1
            // 
            this.colPA_NAZIV1.Caption = "Kupac";
            this.colPA_NAZIV1.FieldName = "PA_NAZIV";
            this.colPA_NAZIV1.Name = "colPA_NAZIV1";
            this.colPA_NAZIV1.OptionsColumn.AllowEdit = false;
            this.colPA_NAZIV1.Visible = true;
            this.colPA_NAZIV1.VisibleIndex = 1;
            this.colPA_NAZIV1.Width = 273;
            // 
            // colbon_iznosracuna
            // 
            this.colbon_iznosracuna.Caption = "Iznos računa";
            this.colbon_iznosracuna.DisplayFormat.FormatString = "c2";
            this.colbon_iznosracuna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbon_iznosracuna.FieldName = "bon_iznosracuna";
            this.colbon_iznosracuna.GroupFormat.FormatString = "c2";
            this.colbon_iznosracuna.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbon_iznosracuna.Name = "colbon_iznosracuna";
            this.colbon_iznosracuna.OptionsColumn.AllowEdit = false;
            this.colbon_iznosracuna.Visible = true;
            this.colbon_iznosracuna.VisibleIndex = 6;
            this.colbon_iznosracuna.Width = 122;
            // 
            // colifab_ID
            // 
            this.colifab_ID.Caption = "Broj fakture";
            this.colifab_ID.FieldName = "ifab_ID";
            this.colifab_ID.Name = "colifab_ID";
            this.colifab_ID.OptionsColumn.AllowEdit = false;
            this.colifab_ID.Visible = true;
            this.colifab_ID.VisibleIndex = 7;
            this.colifab_ID.Width = 102;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Operater";
            this.gridColumn3.FieldName = "concat(operater_op_ime,\' \',operater_op_prezime)";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 219;
            // 
            // colbon_ponisten
            // 
            this.colbon_ponisten.Caption = "Poništen";
            this.colbon_ponisten.FieldName = "bon_ponisten";
            this.colbon_ponisten.Name = "colbon_ponisten";
            this.colbon_ponisten.OptionsColumn.AllowEdit = false;
            this.colbon_ponisten.Visible = true;
            this.colbon_ponisten.VisibleIndex = 9;
            this.colbon_ponisten.Width = 77;
            // 
            // coliskoristeno
            // 
            this.coliskoristeno.FieldName = "iskoristeno";
            this.coliskoristeno.Name = "coliskoristeno";
            // 
            // colpo_naziv1
            // 
            this.colpo_naziv1.Caption = "Poslovnica";
            this.colpo_naziv1.FieldName = "po_naziv";
            this.colpo_naziv1.Name = "colpo_naziv1";
            this.colpo_naziv1.OptionsColumn.AllowEdit = false;
            this.colpo_naziv1.Visible = true;
            this.colpo_naziv1.VisibleIndex = 10;
            this.colpo_naziv1.Width = 151;
            // 
            // colbon_id
            // 
            this.colbon_id.FieldName = "bon_id";
            this.colbon_id.Name = "colbon_id";
            this.colbon_id.OptionsColumn.AllowEdit = false;
            // 
            // colbon_napomena
            // 
            this.colbon_napomena.Caption = "Napomena";
            this.colbon_napomena.FieldName = "bon_napomena";
            this.colbon_napomena.Name = "colbon_napomena";
            this.colbon_napomena.Visible = true;
            this.colbon_napomena.VisibleIndex = 11;
            this.colbon_napomena.Width = 217;
            // 
            // operaterTableAdapter
            // 
            this.operaterTableAdapter.ClearBeforeFill = true;
            // 
            // poslovnicaTableAdapter
            // 
            this.poslovnicaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPregledBonova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 659);
            this.Controls.Add(this.dgBonovi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPregledBonova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled izdanih bonova";
            this.Load += new System.EventHandler(this.frmPregledBonova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPregledBonova_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdani_bonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUkupnoIzdano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUkupnoIskoristeno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFakturirano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPonisteno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNijeIskoristeno.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAzuriranjeBona.ResumeLayout(false);
            this.pnlAzuriranjeBona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIznosRacuna.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glPoslovnica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glOperater.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operaterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDoKada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOdKada;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit glPartner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private Partner partner;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private PartnerTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bonoviBindingSource;
        private Izdani_bonovi izdani_bonovi;
        private Izdani_bonoviTableAdapters.bonoviTableAdapter bonoviTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtUkupnoIzdano;
        private DevExpress.XtraEditors.TextEdit txtUkupnoIskoristeno;
        private DevExpress.XtraEditors.TextEdit txtFakturirano;
        private DevExpress.XtraEditors.TextEdit txtPonisteno;
        private DevExpress.XtraEditors.TextEdit txtNijeIskoristeno;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgBonovi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgBon;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_rednibroj;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_datumizrade;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_iznos;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_datumkoristenja;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV1;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_iznosracuna;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_ponisten;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlAzuriranjeBona;
        private System.Windows.Forms.Button btnSpremi;
        private DevExpress.XtraEditors.GridLookUpEdit glPoslovnica;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TextBox txtBosoKartica;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraEditors.GridLookUpEdit glOperater;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtRacunKasa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBrojKasa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpDatKor;
        private System.Windows.Forms.Label lblPoruka;
        private Operater operater;
        private System.Windows.Forms.BindingSource operaterBindingSource;
        private OperaterTableAdapters.operaterTableAdapter operaterTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colop_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colop_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.BindingSource poslovnicaBindingSource;
        private OperaterTableAdapters.poslovnicaTableAdapter poslovnicaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraEditors.TextEdit txtIznosRacuna;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn coliskoristeno;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv1;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_id;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_napomena;
    }
}