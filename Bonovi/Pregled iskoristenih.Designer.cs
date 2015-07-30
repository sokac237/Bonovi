namespace Bonovi
{
    partial class frmIskoristeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIskoristeni));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNaplata = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlaceno = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIskoristeno = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.dgBonovi = new DevExpress.XtraGrid.GridControl();
            this.bonoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdani_bonovi = new Bonovi.Izdani_bonovi();
            this.dgBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbon_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_rednibroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumizrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_iznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumkoristenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_iznosracuna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_ponisten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliskoristeno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partnerTableAdapter = new Bonovi.PartnerTableAdapters.partnerTableAdapter();
            this.bonoviTableAdapter = new Bonovi.Izdani_bonoviTableAdapters.bonoviTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaplata.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaceno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskoristeno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdani_bonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
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
            this.panel1.Size = new System.Drawing.Size(984, 80);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "F5 - lista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "F2 - detalji bona";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(443, 49);
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
            this.glPartner.Location = new System.Drawing.Point(92, 50);
            this.glPartner.Name = "glPartner";
            this.glPartner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPartner.Properties.DataSource = this.partnerBindingSource;
            this.glPartner.Properties.DisplayMember = "PA_NAZIV";
            this.glPartner.Properties.NullText = "";
            this.glPartner.Properties.ValueMember = "PA_ID";
            this.glPartner.Properties.View = this.gridLookUpEdit1View;
            this.glPartner.Size = new System.Drawing.Size(331, 20);
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
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Za partnera:";
            // 
            // dtpDoKada
            // 
            this.dtpDoKada.CustomFormat = " ";
            this.dtpDoKada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoKada.Location = new System.Drawing.Point(296, 21);
            this.dtpDoKada.Name = "dtpDoKada";
            this.dtpDoKada.Size = new System.Drawing.Size(127, 20);
            this.dtpDoKada.TabIndex = 3;
            this.dtpDoKada.ValueChanged += new System.EventHandler(this.dtpDoKada_ValueChanged);
            this.dtpDoKada.Enter += new System.EventHandler(this.dtpDoKada_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "do datuma:";
            // 
            // dtpOdKada
            // 
            this.dtpOdKada.CustomFormat = " ";
            this.dtpOdKada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOdKada.Location = new System.Drawing.Point(92, 21);
            this.dtpOdKada.Name = "dtpOdKada";
            this.dtpOdKada.Size = new System.Drawing.Size(127, 20);
            this.dtpOdKada.TabIndex = 1;
            this.dtpOdKada.ValueChanged += new System.EventHandler(this.dtpOdKada_ValueChanged);
            this.dtpOdKada.Enter += new System.EventHandler(this.dtpOdKada_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Od datuma:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNaplata);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtPlaceno);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtIskoristeno);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 97);
            this.panel3.TabIndex = 25;
            // 
            // txtNaplata
            // 
            this.txtNaplata.Enabled = false;
            this.txtNaplata.Location = new System.Drawing.Point(139, 39);
            this.txtNaplata.Name = "txtNaplata";
            this.txtNaplata.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtNaplata.Properties.Appearance.Options.UseForeColor = true;
            this.txtNaplata.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtNaplata.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtNaplata.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtNaplata.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtNaplata.Properties.Mask.EditMask = "c2";
            this.txtNaplata.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNaplata.Size = new System.Drawing.Size(143, 20);
            this.txtNaplata.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(32, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Od toga iskorišteno:";
            // 
            // txtPlaceno
            // 
            this.txtPlaceno.Enabled = false;
            this.txtPlaceno.Location = new System.Drawing.Point(139, 65);
            this.txtPlaceno.Name = "txtPlaceno";
            this.txtPlaceno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtPlaceno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtPlaceno.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtPlaceno.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtPlaceno.Properties.Mask.EditMask = "c2";
            this.txtPlaceno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPlaceno.Size = new System.Drawing.Size(143, 20);
            this.txtPlaceno.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fakturirano:";
            // 
            // txtIskoristeno
            // 
            this.txtIskoristeno.Enabled = false;
            this.txtIskoristeno.Location = new System.Drawing.Point(139, 13);
            this.txtIskoristeno.Name = "txtIskoristeno";
            this.txtIskoristeno.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtIskoristeno.Properties.Appearance.Options.UseForeColor = true;
            this.txtIskoristeno.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.txtIskoristeno.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtIskoristeno.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.txtIskoristeno.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtIskoristeno.Properties.Mask.EditMask = "c2";
            this.txtIskoristeno.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIskoristeno.Size = new System.Drawing.Size(143, 20);
            this.txtIskoristeno.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(67, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Za naplatiti:";
            // 
            // dgBonovi
            // 
            this.dgBonovi.DataSource = this.bonoviBindingSource;
            this.dgBonovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBonovi.Location = new System.Drawing.Point(0, 80);
            this.dgBonovi.MainView = this.dgBon;
            this.dgBonovi.Name = "dgBonovi";
            this.dgBonovi.Size = new System.Drawing.Size(984, 298);
            this.dgBonovi.TabIndex = 26;
            this.dgBonovi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgBon});
            this.dgBonovi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgBonovi_KeyDown);
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
            this.gridColumn2,
            this.colifab_ID,
            this.colbon_ponisten,
            this.coliskoristeno,
            this.colpo_naziv});
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
            // colbon_kod
            // 
            this.colbon_kod.Caption = "Šifra bona";
            this.colbon_kod.FieldName = "bon_kod";
            this.colbon_kod.Name = "colbon_kod";
            this.colbon_kod.Visible = true;
            this.colbon_kod.VisibleIndex = 0;
            this.colbon_kod.Width = 145;
            // 
            // colbon_rednibroj
            // 
            this.colbon_rednibroj.Caption = "Potvrda broj";
            this.colbon_rednibroj.FieldName = "bon_rednibroj";
            this.colbon_rednibroj.Name = "colbon_rednibroj";
            this.colbon_rednibroj.Visible = true;
            this.colbon_rednibroj.VisibleIndex = 2;
            this.colbon_rednibroj.Width = 154;
            // 
            // colbon_datumizrade
            // 
            this.colbon_datumizrade.Caption = "Izdano";
            this.colbon_datumizrade.FieldName = "bon_datumizrade";
            this.colbon_datumizrade.Name = "colbon_datumizrade";
            this.colbon_datumizrade.Visible = true;
            this.colbon_datumizrade.VisibleIndex = 3;
            this.colbon_datumizrade.Width = 120;
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
            this.colbon_iznos.Visible = true;
            this.colbon_iznos.VisibleIndex = 4;
            this.colbon_iznos.Width = 187;
            // 
            // colbon_datumkoristenja
            // 
            this.colbon_datumkoristenja.Caption = "Iskorišten";
            this.colbon_datumkoristenja.FieldName = "bon_datumkoristenja";
            this.colbon_datumkoristenja.Name = "colbon_datumkoristenja";
            this.colbon_datumkoristenja.Visible = true;
            this.colbon_datumkoristenja.VisibleIndex = 5;
            this.colbon_datumkoristenja.Width = 123;
            // 
            // colPA_NAZIV1
            // 
            this.colPA_NAZIV1.Caption = "Kupac";
            this.colPA_NAZIV1.FieldName = "PA_NAZIV";
            this.colPA_NAZIV1.Name = "colPA_NAZIV1";
            this.colPA_NAZIV1.Visible = true;
            this.colPA_NAZIV1.VisibleIndex = 1;
            this.colPA_NAZIV1.Width = 301;
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
            this.colbon_iznosracuna.Visible = true;
            this.colbon_iznosracuna.VisibleIndex = 7;
            this.colbon_iznosracuna.Width = 123;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Operater";
            this.gridColumn2.FieldName = "concat(operater_op_ime,\' \',operater_op_prezime)";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 212;
            // 
            // colifab_ID
            // 
            this.colifab_ID.Caption = "Broj fakture";
            this.colifab_ID.FieldName = "ifab_ID";
            this.colifab_ID.Name = "colifab_ID";
            this.colifab_ID.Visible = true;
            this.colifab_ID.VisibleIndex = 8;
            this.colifab_ID.Width = 97;
            // 
            // colbon_ponisten
            // 
            this.colbon_ponisten.Caption = "Poništen";
            this.colbon_ponisten.FieldName = "bon_ponisten";
            this.colbon_ponisten.Name = "colbon_ponisten";
            this.colbon_ponisten.Visible = true;
            this.colbon_ponisten.VisibleIndex = 9;
            this.colbon_ponisten.Width = 90;
            // 
            // coliskoristeno
            // 
            this.coliskoristeno.FieldName = "iskoristeno";
            this.coliskoristeno.Name = "coliskoristeno";
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Poslovnica";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 10;
            this.colpo_naziv.Width = 179;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // bonoviTableAdapter
            // 
            this.bonoviTableAdapter.ClearBeforeFill = true;
            // 
            // frmIskoristeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 475);
            this.Controls.Add(this.dgBonovi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmIskoristeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iskorišteni bonovi";
            this.Load += new System.EventHandler(this.frmIskoristeni_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIskoristeni_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNaplata.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaceno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIskoristeno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdani_bonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtNaplata;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtPlaceno;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtIskoristeno;
        private System.Windows.Forms.Label label13;
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
        private Partner partner;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private PartnerTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.BindingSource bonoviBindingSource;
        private Izdani_bonovi izdani_bonovi;
        private Izdani_bonoviTableAdapters.bonoviTableAdapter bonoviTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn coliskoristeno;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
    }
}