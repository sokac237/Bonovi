        namespace Bonovi
{
    partial class frmFakturiranje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFakturiranje));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgStavkePDV = new DevExpress.XtraGrid.GridControl();
            this.dgStavkePDVstavka = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgBonovi = new DevExpress.XtraGrid.GridControl();
            this.fakturiranjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faturiranje = new Bonovi.faturiranje();
            this.dgBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_SIFRA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_rednibroj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_iznos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumkoristenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_iznosracuna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_bosocard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfakturiranje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposlovnica_po_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_kasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_racunnakasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_naziv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_sifra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpo_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_vrijemekoristenja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbon_datumizrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgStavke = new DevExpress.XtraGrid.GridControl();
            this.dgStavkeBona = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.txtUkupnoIzdano = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.glPartner = new DevExpress.XtraEditors.GridLookUpEdit();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partner = new Bonovi.Partner();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_NAZIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPA_SIFRA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.partnerTableAdapter = new Bonovi.PartnerTableAdapters.partnerTableAdapter();
            this.fakturiranjeTableAdapter = new Bonovi.faturiranjeTableAdapters.fakturiranjeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkePDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkePDVstavka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiranjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturiranje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeBona)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUkupnoIzdano.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgStavkePDV);
            this.panel1.Controls.Add(this.dgBonovi);
            this.panel1.Controls.Add(this.dgStavke);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 809);
            this.panel1.TabIndex = 27;
            // 
            // dgStavkePDV
            // 
            this.dgStavkePDV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgStavkePDV.Location = new System.Drawing.Point(0, 358);
            this.dgStavkePDV.MainView = this.dgStavkePDVstavka;
            this.dgStavkePDV.Name = "dgStavkePDV";
            this.dgStavkePDV.Size = new System.Drawing.Size(1031, 201);
            this.dgStavkePDV.TabIndex = 39;
            this.dgStavkePDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgStavkePDVstavka});
            this.dgStavkePDV.Visible = false;
            // 
            // dgStavkePDVstavka
            // 
            this.dgStavkePDVstavka.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkePDVstavka.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgStavkePDVstavka.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgStavkePDVstavka.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgStavkePDVstavka.Appearance.Empty.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkePDVstavka.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkePDVstavka.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgStavkePDVstavka.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkePDVstavka.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgStavkePDVstavka.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgStavkePDVstavka.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgStavkePDVstavka.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkePDVstavka.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkePDVstavka.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgStavkePDVstavka.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkePDVstavka.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkePDVstavka.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgStavkePDVstavka.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkePDVstavka.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkePDVstavka.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgStavkePDVstavka.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkePDVstavka.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkePDVstavka.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkePDVstavka.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgStavkePDVstavka.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgStavkePDVstavka.Appearance.GroupRow.Options.UseFont = true;
            this.dgStavkePDVstavka.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkePDVstavka.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkePDVstavka.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkePDVstavka.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgStavkePDVstavka.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgStavkePDVstavka.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgStavkePDVstavka.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgStavkePDVstavka.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkePDVstavka.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStavkePDVstavka.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgStavkePDVstavka.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.OddRow.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.OddRow.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgStavkePDVstavka.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgStavkePDVstavka.Appearance.Preview.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.Preview.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgStavkePDVstavka.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.Row.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.Row.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgStavkePDVstavka.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgStavkePDVstavka.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkePDVstavka.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgStavkePDVstavka.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgStavkePDVstavka.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStavkePDVstavka.Appearance.VertLine.Options.UseBackColor = true;
            this.dgStavkePDVstavka.ColumnPanelRowHeight = 50;
            this.dgStavkePDVstavka.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgStavkePDVstavka.GridControl = this.dgStavkePDV;
            this.dgStavkePDVstavka.Name = "dgStavkePDVstavka";
            this.dgStavkePDVstavka.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStavkePDVstavka.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStavkePDVstavka.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgStavkePDVstavka.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgStavkePDVstavka.OptionsBehavior.Editable = false;
            this.dgStavkePDVstavka.OptionsCustomization.AllowColumnMoving = false;
            this.dgStavkePDVstavka.OptionsCustomization.AllowFilter = false;
            this.dgStavkePDVstavka.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgStavkePDVstavka.OptionsSelection.MultiSelect = true;
            this.dgStavkePDVstavka.OptionsView.ColumnAutoWidth = false;
            this.dgStavkePDVstavka.OptionsView.EnableAppearanceEvenRow = true;
            this.dgStavkePDVstavka.OptionsView.EnableAppearanceOddRow = true;
            this.dgStavkePDVstavka.OptionsView.ShowAutoFilterRow = true;
            this.dgStavkePDVstavka.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgStavkePDVstavka.OptionsView.ShowGroupPanel = false;
            this.dgStavkePDVstavka.OptionsView.ShowIndicator = false;
            this.dgStavkePDVstavka.PaintStyleName = "WindowsXP";
            this.dgStavkePDVstavka.SynchronizeClones = false;
            // 
            // dgBonovi
            // 
            this.dgBonovi.DataSource = this.fakturiranjeBindingSource;
            this.dgBonovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBonovi.Location = new System.Drawing.Point(0, 100);
            this.dgBonovi.MainView = this.dgBon;
            this.dgBonovi.Name = "dgBonovi";
            this.dgBonovi.Size = new System.Drawing.Size(1031, 459);
            this.dgBonovi.TabIndex = 38;
            this.dgBonovi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgBon});
            this.dgBonovi.DoubleClick += new System.EventHandler(this.dgBon_DoubleClick);
            this.dgBonovi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgBonovi_KeyDown);
            // 
            // fakturiranjeBindingSource
            // 
            this.fakturiranjeBindingSource.DataMember = "fakturiranje";
            this.fakturiranjeBindingSource.DataSource = this.faturiranje;
            // 
            // faturiranje
            // 
            this.faturiranje.DataSetName = "faturiranje";
            this.faturiranje.EnforceConstraints = false;
            this.faturiranje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colPA_SIFRA1,
            this.colPA_NAZIV1,
            this.colbon_rednibroj,
            this.colbon_iznos,
            this.colbon_datumkoristenja,
            this.colbon_iznosracuna,
            this.colbon_bosocard,
            this.colfakturiranje,
            this.colbon_ID,
            this.colposlovnica_po_ID,
            this.colbon_kasa,
            this.colbon_racunnakasi,
            this.colpo_naziv,
            this.colpo_sifra,
            this.colbon_kod,
            this.colpo_ID,
            this.colbon_vrijemekoristenja,
            this.colbon_datumizrade});
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
            this.dgBon.OptionsView.ColumnAutoWidth = false;
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
            // colPA_SIFRA1
            // 
            this.colPA_SIFRA1.Caption = "Šifra partnera";
            this.colPA_SIFRA1.FieldName = "PA_SIFRA";
            this.colPA_SIFRA1.Name = "colPA_SIFRA1";
            this.colPA_SIFRA1.Visible = true;
            this.colPA_SIFRA1.VisibleIndex = 3;
            this.colPA_SIFRA1.Width = 73;
            // 
            // colPA_NAZIV1
            // 
            this.colPA_NAZIV1.Caption = "Partner";
            this.colPA_NAZIV1.FieldName = "PA_NAZIV";
            this.colPA_NAZIV1.Name = "colPA_NAZIV1";
            this.colPA_NAZIV1.Visible = true;
            this.colPA_NAZIV1.VisibleIndex = 4;
            this.colPA_NAZIV1.Width = 230;
            // 
            // colbon_rednibroj
            // 
            this.colbon_rednibroj.Caption = "Broj potvrde";
            this.colbon_rednibroj.FieldName = "bon_rednibroj";
            this.colbon_rednibroj.Name = "colbon_rednibroj";
            this.colbon_rednibroj.Visible = true;
            this.colbon_rednibroj.VisibleIndex = 2;
            this.colbon_rednibroj.Width = 65;
            // 
            // colbon_iznos
            // 
            this.colbon_iznos.Caption = "Iznos bona";
            this.colbon_iznos.DisplayFormat.FormatString = "c2";
            this.colbon_iznos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbon_iznos.FieldName = "bon_iznos";
            this.colbon_iznos.Name = "colbon_iznos";
            this.colbon_iznos.Visible = true;
            this.colbon_iznos.VisibleIndex = 5;
            this.colbon_iznos.Width = 82;
            // 
            // colbon_datumkoristenja
            // 
            this.colbon_datumkoristenja.Caption = "Datum korištenja";
            this.colbon_datumkoristenja.FieldName = "bon_datumkoristenja";
            this.colbon_datumkoristenja.Name = "colbon_datumkoristenja";
            this.colbon_datumkoristenja.Visible = true;
            this.colbon_datumkoristenja.VisibleIndex = 6;
            this.colbon_datumkoristenja.Width = 83;
            // 
            // colbon_iznosracuna
            // 
            this.colbon_iznosracuna.Caption = "Iznos za fakturirati";
            this.colbon_iznosracuna.DisplayFormat.FormatString = "c2";
            this.colbon_iznosracuna.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbon_iznosracuna.FieldName = "bon_iznosracuna";
            this.colbon_iznosracuna.Name = "colbon_iznosracuna";
            this.colbon_iznosracuna.Visible = true;
            this.colbon_iznosracuna.VisibleIndex = 9;
            this.colbon_iznosracuna.Width = 90;
            // 
            // colbon_bosocard
            // 
            this.colbon_bosocard.Caption = "Boso shopping card broj";
            this.colbon_bosocard.FieldName = "bon_bosocard";
            this.colbon_bosocard.Name = "colbon_bosocard";
            this.colbon_bosocard.Visible = true;
            this.colbon_bosocard.VisibleIndex = 10;
            this.colbon_bosocard.Width = 113;
            // 
            // colfakturiranje
            // 
            this.colfakturiranje.Caption = "Fakturirati";
            this.colfakturiranje.FieldName = "fakturiranje";
            this.colfakturiranje.Name = "colfakturiranje";
            this.colfakturiranje.Visible = true;
            this.colfakturiranje.VisibleIndex = 0;
            this.colfakturiranje.Width = 59;
            // 
            // colbon_ID
            // 
            this.colbon_ID.FieldName = "bon_ID";
            this.colbon_ID.Name = "colbon_ID";
            // 
            // colposlovnica_po_ID
            // 
            this.colposlovnica_po_ID.FieldName = "poslovnica_po_ID";
            this.colposlovnica_po_ID.Name = "colposlovnica_po_ID";
            // 
            // colbon_kasa
            // 
            this.colbon_kasa.Caption = "Kasa";
            this.colbon_kasa.FieldName = "bon_kasa";
            this.colbon_kasa.Name = "colbon_kasa";
            this.colbon_kasa.Visible = true;
            this.colbon_kasa.VisibleIndex = 7;
            this.colbon_kasa.Width = 40;
            // 
            // colbon_racunnakasi
            // 
            this.colbon_racunnakasi.Caption = "Račun";
            this.colbon_racunnakasi.FieldName = "bon_racunnakasi";
            this.colbon_racunnakasi.Name = "colbon_racunnakasi";
            this.colbon_racunnakasi.Visible = true;
            this.colbon_racunnakasi.VisibleIndex = 8;
            this.colbon_racunnakasi.Width = 49;
            // 
            // colpo_naziv
            // 
            this.colpo_naziv.Caption = "Naziv posl.";
            this.colpo_naziv.FieldName = "po_naziv";
            this.colpo_naziv.Name = "colpo_naziv";
            this.colpo_naziv.Visible = true;
            this.colpo_naziv.VisibleIndex = 12;
            this.colpo_naziv.Width = 241;
            // 
            // colpo_sifra
            // 
            this.colpo_sifra.Caption = "Šifra posl.";
            this.colpo_sifra.FieldName = "po_sifra";
            this.colpo_sifra.Name = "colpo_sifra";
            this.colpo_sifra.Visible = true;
            this.colpo_sifra.VisibleIndex = 11;
            this.colpo_sifra.Width = 62;
            // 
            // colbon_kod
            // 
            this.colbon_kod.Caption = "Šifra bona";
            this.colbon_kod.FieldName = "bon_kod";
            this.colbon_kod.Name = "colbon_kod";
            this.colbon_kod.Visible = true;
            this.colbon_kod.VisibleIndex = 1;
            this.colbon_kod.Width = 74;
            // 
            // colpo_ID
            // 
            this.colpo_ID.FieldName = "po_ID";
            this.colpo_ID.Name = "colpo_ID";
            // 
            // colbon_vrijemekoristenja
            // 
            this.colbon_vrijemekoristenja.FieldName = "bon_vrijemekoristenja";
            this.colbon_vrijemekoristenja.Name = "colbon_vrijemekoristenja";
            // 
            // colbon_datumizrade
            // 
            this.colbon_datumizrade.Caption = "Datum izrade";
            this.colbon_datumizrade.FieldName = "bon_datumizrade";
            this.colbon_datumizrade.Name = "colbon_datumizrade";
            this.colbon_datumizrade.Visible = true;
            this.colbon_datumizrade.VisibleIndex = 13;
            // 
            // dgStavke
            // 
            this.dgStavke.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgStavke.Location = new System.Drawing.Point(0, 559);
            this.dgStavke.MainView = this.dgStavkeBona;
            this.dgStavke.Name = "dgStavke";
            this.dgStavke.Size = new System.Drawing.Size(1031, 175);
            this.dgStavke.TabIndex = 37;
            this.dgStavke.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgStavkeBona});
            this.dgStavke.Visible = false;
            // 
            // dgStavkeBona
            // 
            this.dgStavkeBona.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeBona.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeBona.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgStavkeBona.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgStavkeBona.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgStavkeBona.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgStavkeBona.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeBona.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgStavkeBona.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgStavkeBona.Appearance.Empty.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeBona.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeBona.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgStavkeBona.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeBona.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgStavkeBona.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgStavkeBona.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgStavkeBona.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeBona.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeBona.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgStavkeBona.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeBona.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeBona.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgStavkeBona.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeBona.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeBona.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgStavkeBona.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeBona.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeBona.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStavkeBona.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgStavkeBona.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgStavkeBona.Appearance.GroupRow.Options.UseFont = true;
            this.dgStavkeBona.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStavkeBona.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStavkeBona.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStavkeBona.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgStavkeBona.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgStavkeBona.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgStavkeBona.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgStavkeBona.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStavkeBona.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStavkeBona.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgStavkeBona.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.OddRow.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.OddRow.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgStavkeBona.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgStavkeBona.Appearance.Preview.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.Preview.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgStavkeBona.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.Row.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.Row.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgStavkeBona.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgStavkeBona.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStavkeBona.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgStavkeBona.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgStavkeBona.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStavkeBona.Appearance.VertLine.Options.UseBackColor = true;
            this.dgStavkeBona.ColumnPanelRowHeight = 50;
            this.dgStavkeBona.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgStavkeBona.GridControl = this.dgStavke;
            this.dgStavkeBona.Name = "dgStavkeBona";
            this.dgStavkeBona.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStavkeBona.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStavkeBona.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgStavkeBona.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgStavkeBona.OptionsBehavior.Editable = false;
            this.dgStavkeBona.OptionsCustomization.AllowColumnMoving = false;
            this.dgStavkeBona.OptionsCustomization.AllowFilter = false;
            this.dgStavkeBona.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgStavkeBona.OptionsSelection.MultiSelect = true;
            this.dgStavkeBona.OptionsView.ColumnAutoWidth = false;
            this.dgStavkeBona.OptionsView.EnableAppearanceEvenRow = true;
            this.dgStavkeBona.OptionsView.EnableAppearanceOddRow = true;
            this.dgStavkeBona.OptionsView.ShowAutoFilterRow = true;
            this.dgStavkeBona.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgStavkeBona.OptionsView.ShowGroupPanel = false;
            this.dgStavkeBona.OptionsView.ShowIndicator = false;
            this.dgStavkeBona.PaintStyleName = "WindowsXP";
            this.dgStavkeBona.SynchronizeClones = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPoruka);
            this.panel2.Controls.Add(this.txtUkupnoIzdano);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 734);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 75);
            this.panel2.TabIndex = 35;
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoruka.ForeColor = System.Drawing.Color.Red;
            this.lblPoruka.Location = new System.Drawing.Point(378, 32);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(155, 20);
            this.lblPoruka.TabIndex = 23;
            this.lblPoruka.Text = "Prikupljam podatke...";
            this.lblPoruka.Visible = false;
            // 
            // txtUkupnoIzdano
            // 
            this.txtUkupnoIzdano.Enabled = false;
            this.txtUkupnoIzdano.Location = new System.Drawing.Point(111, 27);
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
            this.txtUkupnoIzdano.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Za naplatiti:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnPrikazi);
            this.panel3.Controls.Add(this.glPartner);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 100);
            this.panel3.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Kupac:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(741, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "F9 - storno";
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "F5 - faktura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "F7 - označi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "2 x klik za odabir";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(442, 22);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 15;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // glPartner
            // 
            this.glPartner.EditValue = "";
            this.glPartner.Location = new System.Drawing.Point(87, 24);
            this.glPartner.Name = "glPartner";
            this.glPartner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glPartner.Properties.DataSource = this.partnerBindingSource;
            this.glPartner.Properties.DisplayMember = "PA_NAZIV";
            this.glPartner.Properties.NullText = "";
            this.glPartner.Properties.ValueMember = "PA_ID";
            this.glPartner.Properties.View = this.gridLookUpEdit1View;
            this.glPartner.Size = new System.Drawing.Size(331, 20);
            this.glPartner.TabIndex = 14;
            this.glPartner.EditValueChanged += new System.EventHandler(this.glPartner_EditValueChanged);
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
            this.label3.Location = new System.Drawing.Point(-315, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Za partnera:";
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // fakturiranjeTableAdapter
            // 
            this.fakturiranjeTableAdapter.ClearBeforeFill = true;
            // 
            // frmFakturiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 809);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmFakturiranje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fakturiranje bonova";
            this.Load += new System.EventHandler(this.frmFakturiranje_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFakturiranje_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkePDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkePDVstavka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakturiranjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturiranje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStavkeBona)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUkupnoIzdano.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glPartner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Partner partner;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private PartnerTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtUkupnoIzdano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrikazi;
        private DevExpress.XtraEditors.GridLookUpEdit glPartner;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fakturiranjeBindingSource;
        private faturiranje faturiranje;
        private faturiranjeTableAdapters.fakturiranjeTableAdapter fakturiranjeTableAdapter;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.GridControl dgStavke;
        private DevExpress.XtraGrid.Views.Grid.GridView dgStavkeBona;
        private DevExpress.XtraGrid.GridControl dgBonovi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgBon;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_SIFRA1;
        private DevExpress.XtraGrid.Columns.GridColumn colPA_NAZIV1;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_rednibroj;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_iznos;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_datumkoristenja;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_iznosracuna;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_bosocard;
        private DevExpress.XtraGrid.Columns.GridColumn colfakturiranje;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colposlovnica_po_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_kasa;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_racunnakasi;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_naziv;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_sifra;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colpo_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_vrijemekoristenja;
        private System.Windows.Forms.Label lblPoruka;
        private DevExpress.XtraGrid.Columns.GridColumn colbon_datumizrade;
        private DevExpress.XtraGrid.GridControl dgStavkePDV;
        private DevExpress.XtraGrid.Views.Grid.GridView dgStavkePDVstavka;
    }
}