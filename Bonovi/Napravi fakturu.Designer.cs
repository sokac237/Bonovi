namespace Bonovi
{
    partial class frmNapraviFakturu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNapraviFakturu));
            this.dgBonovi = new DevExpress.XtraGrid.GridControl();
            this.ifabonstavkatmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkeBona = new Bonovi.StavkeBona();
            this.dgBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbonSt_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colifab_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_kolicina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_povratna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpz_posto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_brojRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_datumRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_KasaBr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_po_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_vrijemeRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_porezIznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_cijenabruto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_postorabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_iznosrabat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_netocijena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_iznosneto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpIsporuka = new System.Windows.Forms.DateTimePicker();
            this.dtpValuta = new System.Windows.Forms.DateTimePicker();
            this.dtpDokumenta = new System.Windows.Forms.DateTimePicker();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBonoviBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ifabonstavka_tmpTableAdapter = new Bonovi.StavkeBonaTableAdapters.ifabonstavka_tmpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifabonstavkatmpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeBona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBonovi
            // 
            this.dgBonovi.DataSource = this.ifabonstavkatmpBindingSource;
            this.dgBonovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBonovi.Location = new System.Drawing.Point(0, 82);
            this.dgBonovi.MainView = this.dgBon;
            this.dgBonovi.Name = "dgBonovi";
            this.dgBonovi.Size = new System.Drawing.Size(982, 449);
            this.dgBonovi.TabIndex = 0;
            this.dgBonovi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgBon});
            // 
            // ifabonstavkatmpBindingSource
            // 
            this.ifabonstavkatmpBindingSource.DataMember = "ifabonstavka_tmp";
            this.ifabonstavkatmpBindingSource.DataSource = this.stavkeBona;
            // 
            // stavkeBona
            // 
            this.stavkeBona.DataSetName = "StavkeBona";
            this.stavkeBona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colbonSt_ID,
            this.colifab_ID,
            this.colpr_sifra,
            this.colpr_naziv,
            this.colpr_kolicina,
            this.colpr_povratna,
            this.colpz_posto,
            this.colpo_naziv,
            this.colpr_brojRa,
            this.colpr_datumRa,
            this.colpr_KasaBr,
            this.colpr_po_sifra,
            this.colpr_vrijemeRa,
            this.colpr_porezIznos,
            this.colpr_cijenabruto,
            this.colpr_postorabat,
            this.colpr_iznosrabat,
            this.colpr_netocijena,
            this.colpr_iznosneto,
            this.gridColumn1});
            this.dgBon.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgBon.GridControl = this.dgBonovi;
            this.dgBon.Name = "dgBon";
            this.dgBon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgBon.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgBon.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgBon.OptionsBehavior.Editable = false;
            this.dgBon.OptionsCustomization.AllowFilter = false;
            this.dgBon.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgBon.OptionsSelection.MultiSelect = true;
            this.dgBon.OptionsView.EnableAppearanceEvenRow = true;
            this.dgBon.OptionsView.EnableAppearanceOddRow = true;
            this.dgBon.OptionsView.ShowAutoFilterRow = true;
            this.dgBon.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgBon.OptionsView.ShowFooter = true;
            this.dgBon.OptionsView.ShowGroupPanel = false;
            this.dgBon.OptionsView.ShowIndicator = false;
            this.dgBon.PaintStyleName = "WindowsXP";
            this.dgBon.SynchronizeClones = false;
            // 
            // colbonSt_ID
            // 
            this.colbonSt_ID.FieldName = "bonSt_ID";
            this.colbonSt_ID.Name = "colbonSt_ID";
            this.colbonSt_ID.OptionsColumn.AllowEdit = false;
            // 
            // colifab_ID
            // 
            this.colifab_ID.FieldName = "ifab_ID";
            this.colifab_ID.Name = "colifab_ID";
            this.colifab_ID.OptionsColumn.AllowEdit = false;
            // 
            // colpr_sifra
            // 
            this.colpr_sifra.Caption = "Šifra artikla";
            this.colpr_sifra.FieldName = "pr_sifra";
            this.colpr_sifra.Name = "colpr_sifra";
            this.colpr_sifra.OptionsColumn.AllowEdit = false;
            this.colpr_sifra.Visible = true;
            this.colpr_sifra.VisibleIndex = 2;
            this.colpr_sifra.Width = 55;
            // 
            // colpr_naziv
            // 
            this.colpr_naziv.Caption = "Naziv artikla";
            this.colpr_naziv.FieldName = "pr_naziv";
            this.colpr_naziv.Name = "colpr_naziv";
            this.colpr_naziv.OptionsColumn.AllowEdit = false;
            this.colpr_naziv.Visible = true;
            this.colpr_naziv.VisibleIndex = 3;
            this.colpr_naziv.Width = 174;
            // 
            // colpr_kolicina
            // 
            this.colpr_kolicina.Caption = "Količina";
            this.colpr_kolicina.FieldName = "pr_kolicina";
            this.colpr_kolicina.Name = "colpr_kolicina";
            this.colpr_kolicina.OptionsColumn.AllowEdit = false;
            this.colpr_kolicina.Visible = true;
            this.colpr_kolicina.VisibleIndex = 4;
            this.colpr_kolicina.Width = 48;
            // 
            // colpr_povratna
            // 
            this.colpr_povratna.Caption = "Povratna naknada";
            this.colpr_povratna.FieldName = "pr_povratna";
            this.colpr_povratna.Name = "colpr_povratna";
            this.colpr_povratna.OptionsColumn.AllowEdit = false;
            this.colpr_povratna.Visible = true;
            this.colpr_povratna.VisibleIndex = 8;
            this.colpr_povratna.Width = 46;
            // 
            // colpz_posto
            // 
            this.colpz_posto.Caption = "Porez";
            this.colpz_posto.FieldName = "pz_posto";
            this.colpz_posto.Name = "colpz_posto";
            this.colpz_posto.OptionsColumn.AllowEdit = false;
            this.colpz_posto.Visible = true;
            this.colpz_posto.VisibleIndex = 6;
            this.colpz_posto.Width = 41;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Poslovnica";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.OptionsColumn.AllowEdit = false;
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 1;
            this.colpo_naziv.Width = 125;
            // 
            // colpr_brojRa
            // 
            this.colpr_brojRa.Caption = "Račun";
            this.colpr_brojRa.FieldName = "pr_brojRa";
            this.colpr_brojRa.Name = "colpr_brojRa";
            this.colpr_brojRa.OptionsColumn.AllowEdit = false;
            this.colpr_brojRa.Width = 44;
            // 
            // colpr_datumRa
            // 
            this.colpr_datumRa.Caption = "Dan";
            this.colpr_datumRa.FieldName = "pr_datumRa";
            this.colpr_datumRa.Name = "colpr_datumRa";
            this.colpr_datumRa.OptionsColumn.AllowEdit = false;
            this.colpr_datumRa.Width = 71;
            // 
            // colpr_KasaBr
            // 
            this.colpr_KasaBr.Caption = "Kasa";
            this.colpr_KasaBr.FieldName = "pr_KasaBr";
            this.colpr_KasaBr.Name = "colpr_KasaBr";
            this.colpr_KasaBr.OptionsColumn.AllowEdit = false;
            this.colpr_KasaBr.Width = 44;
            // 
            // colpr_po_sifra
            // 
            this.colpr_po_sifra.Caption = "Šifra poslovnice";
            this.colpr_po_sifra.FieldName = "pr_po_sifra";
            this.colpr_po_sifra.Name = "colpr_po_sifra";
            this.colpr_po_sifra.OptionsColumn.AllowEdit = false;
            this.colpr_po_sifra.Visible = true;
            this.colpr_po_sifra.VisibleIndex = 0;
            this.colpr_po_sifra.Width = 56;
            // 
            // colpr_vrijemeRa
            // 
            this.colpr_vrijemeRa.Caption = "Sat";
            this.colpr_vrijemeRa.FieldName = "pr_vrijemeRa";
            this.colpr_vrijemeRa.Name = "colpr_vrijemeRa";
            this.colpr_vrijemeRa.OptionsColumn.AllowEdit = false;
            this.colpr_vrijemeRa.Width = 80;
            // 
            // colpr_porezIznos
            // 
            this.colpr_porezIznos.Caption = "Iznos poreza";
            this.colpr_porezIznos.FieldName = "pr_porezIznos";
            this.colpr_porezIznos.Name = "colpr_porezIznos";
            this.colpr_porezIznos.Visible = true;
            this.colpr_porezIznos.VisibleIndex = 7;
            this.colpr_porezIznos.Width = 53;
            // 
            // colpr_cijenabruto
            // 
            this.colpr_cijenabruto.Caption = "Bruto cijena";
            this.colpr_cijenabruto.FieldName = "pr_cijenabruto";
            this.colpr_cijenabruto.Name = "colpr_cijenabruto";
            this.colpr_cijenabruto.Visible = true;
            this.colpr_cijenabruto.VisibleIndex = 5;
            this.colpr_cijenabruto.Width = 61;
            // 
            // colpr_postorabat
            // 
            this.colpr_postorabat.Caption = "Rabat %";
            this.colpr_postorabat.FieldName = "pr_postorabat";
            this.colpr_postorabat.Name = "colpr_postorabat";
            this.colpr_postorabat.Visible = true;
            this.colpr_postorabat.VisibleIndex = 9;
            this.colpr_postorabat.Width = 61;
            // 
            // colpr_iznosrabat
            // 
            this.colpr_iznosrabat.Caption = "Iznos rabata";
            this.colpr_iznosrabat.FieldName = "pr_iznosrabat";
            this.colpr_iznosrabat.Name = "colpr_iznosrabat";
            this.colpr_iznosrabat.Visible = true;
            this.colpr_iznosrabat.VisibleIndex = 10;
            this.colpr_iznosrabat.Width = 61;
            // 
            // colpr_netocijena
            // 
            this.colpr_netocijena.Caption = "Neto cijena";
            this.colpr_netocijena.FieldName = "pr_netocijena";
            this.colpr_netocijena.Name = "colpr_netocijena";
            this.colpr_netocijena.Visible = true;
            this.colpr_netocijena.VisibleIndex = 11;
            this.colpr_netocijena.Width = 61;
            // 
            // colpr_iznosneto
            // 
            this.colpr_iznosneto.Caption = "Neto iznos";
            this.colpr_iznosneto.FieldName = "pr_iznosneto";
            this.colpr_iznosneto.Name = "colpr_iznosneto";
            this.colpr_iznosneto.Visible = true;
            this.colpr_iznosneto.VisibleIndex = 12;
            this.colpr_iznosneto.Width = 61;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ukupno";
            this.gridColumn1.DisplayFormat.FormatString = "{0:0.##}";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.SummaryItem.DisplayFormat = "{0:0.##}";
            this.gridColumn1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn1.UnboundExpression = "[pr_povratna]+[pr_porezIznos]+[pr_iznosneto]";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 13;
            this.gridColumn1.Width = 77;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnIzmjena);
            this.panel2.Controls.Add(this.btnDodaj);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnOdustani);
            this.panel2.Controls.Add(this.btnSpremi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 119);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpIsporuka);
            this.panel1.Controls.Add(this.dtpValuta);
            this.panel1.Controls.Add(this.dtpDokumenta);
            this.panel1.Controls.Add(this.txtOpis);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnNastavi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(327, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 98);
            this.panel1.TabIndex = 20;
            this.panel1.Visible = false;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Opis:";
            // 
            // btnNastavi
            // 
            this.btnNastavi.Location = new System.Drawing.Point(462, 68);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(75, 23);
            this.btnNastavi.TabIndex = 7;
            this.btnNastavi.Text = "Nastavi";
            this.btnNastavi.UseVisualStyleBackColor = true;
            this.btnNastavi.Click += new System.EventHandler(this.btnNastavi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Datum isporuke";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Datum valute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum dokumenta";
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.Location = new System.Drawing.Point(206, 19);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(83, 23);
            this.btnIzmjena.TabIndex = 19;
            this.btnIzmjena.Text = "Izmjeni stavku";
            this.btnIzmjena.UseVisualStyleBackColor = true;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(10, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(92, 23);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Obriši stavku";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(1136, 78);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(900, 78);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Faturiraj";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOsvjezi);
            this.panel3.Controls.Add(this.txtIznos);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtBonoviBroj);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 82);
            this.panel3.TabIndex = 37;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(1057, 15);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(1, 1);
            this.btnOsvjezi.TabIndex = 18;
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(148, 49);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(162, 20);
            this.txtIznos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Iznos fakture:";
            // 
            // txtBonoviBroj
            // 
            this.txtBonoviBroj.Location = new System.Drawing.Point(148, 19);
            this.txtBonoviBroj.Name = "txtBonoviBroj";
            this.txtBonoviBroj.ReadOnly = true;
            this.txtBonoviBroj.Size = new System.Drawing.Size(329, 20);
            this.txtBonoviBroj.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fakturiranje bonova broj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-315, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Za partnera:";
            // 
            // ifabonstavka_tmpTableAdapter
            // 
            this.ifabonstavka_tmpTableAdapter.ClearBeforeFill = true;
            // 
            // frmNapraviFakturu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 650);
            this.Controls.Add(this.dgBonovi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmNapraviFakturu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmNapraviFakturu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNapraviFakturu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ifabonstavkatmpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeBona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgBonovi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgBon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzmjena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBonoviBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label2;
        private StavkeBona stavkeBona;
        private System.Windows.Forms.BindingSource ifabonstavkatmpBindingSource;
        private StavkeBonaTableAdapters.ifabonstavka_tmpTableAdapter ifabonstavka_tmpTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colbonSt_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colifab_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_kolicina;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_povratna;
        private DevExpress.XtraGrid.Columns.GridColumn colpz_posto;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_brojRa;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_datumRa;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_KasaBr;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_po_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_vrijemeRa;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_porezIznos;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNastavi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_cijenabruto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_postorabat;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_iznosrabat;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_netocijena;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_iznosneto;
        private System.Windows.Forms.DateTimePicker dtpIsporuka;
        private System.Windows.Forms.DateTimePicker dtpValuta;
        private System.Windows.Forms.DateTimePicker dtpDokumenta;


    }
}