namespace Bonovi
{
    partial class frmPrenesiStare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrenesiStare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBonKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDohvatiFakture = new System.Windows.Forms.Button();
            this.btnDohvati = new System.Windows.Forms.Button();
            this.dgStariBonovi = new DevExpress.XtraGrid.GridControl();
            this.dgStariBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrenesiFakture = new System.Windows.Forms.Button();
            this.lvlStatus = new System.Windows.Forms.Label();
            this.btnPrenesi = new System.Windows.Forms.Button();
            this.dgNoviBonovi = new DevExpress.XtraGrid.GridControl();
            this.dgNoviBon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStariBonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStariBon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNoviBonovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNoviBon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBonKod);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDohvatiFakture);
            this.panel1.Controls.Add(this.btnDohvati);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 60);
            this.panel1.TabIndex = 0;
            // 
            // txtBonKod
            // 
            this.txtBonKod.Location = new System.Drawing.Point(73, 24);
            this.txtBonKod.Name = "txtBonKod";
            this.txtBonKod.Size = new System.Drawing.Size(136, 20);
            this.txtBonKod.TabIndex = 0;
            this.txtBonKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBonKod_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bon kod:";
            // 
            // btnDohvatiFakture
            // 
            this.btnDohvatiFakture.Enabled = false;
            this.btnDohvatiFakture.Location = new System.Drawing.Point(593, 22);
            this.btnDohvatiFakture.Name = "btnDohvatiFakture";
            this.btnDohvatiFakture.Size = new System.Drawing.Size(153, 23);
            this.btnDohvatiFakture.TabIndex = 1;
            this.btnDohvatiFakture.Text = "Dohvati fakture";
            this.btnDohvatiFakture.UseVisualStyleBackColor = true;
            this.btnDohvatiFakture.Visible = false;
            this.btnDohvatiFakture.Click += new System.EventHandler(this.btnDohvatiFakture_Click);
            // 
            // btnDohvati
            // 
            this.btnDohvati.Location = new System.Drawing.Point(231, 22);
            this.btnDohvati.Name = "btnDohvati";
            this.btnDohvati.Size = new System.Drawing.Size(153, 23);
            this.btnDohvati.TabIndex = 0;
            this.btnDohvati.Text = "Dohvati stare bonove";
            this.btnDohvati.UseVisualStyleBackColor = true;
            this.btnDohvati.Click += new System.EventHandler(this.btnDohvati_Click);
            // 
            // dgStariBonovi
            // 
            this.dgStariBonovi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgStariBonovi.Location = new System.Drawing.Point(0, 60);
            this.dgStariBonovi.MainView = this.dgStariBon;
            this.dgStariBonovi.Name = "dgStariBonovi";
            this.dgStariBonovi.Size = new System.Drawing.Size(758, 185);
            this.dgStariBonovi.TabIndex = 40;
            this.dgStariBonovi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgStariBon});
            // 
            // dgStariBon
            // 
            this.dgStariBon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStariBon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStariBon.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgStariBon.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgStariBon.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgStariBon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgStariBon.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgStariBon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgStariBon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStariBon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgStariBon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgStariBon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgStariBon.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgStariBon.Appearance.Empty.Options.UseBackColor = true;
            this.dgStariBon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgStariBon.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgStariBon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStariBon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStariBon.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgStariBon.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgStariBon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStariBon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgStariBon.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgStariBon.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgStariBon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgStariBon.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgStariBon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgStariBon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgStariBon.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgStariBon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStariBon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStariBon.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgStariBon.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgStariBon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStariBon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStariBon.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgStariBon.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgStariBon.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgStariBon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStariBon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStariBon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgStariBon.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgStariBon.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgStariBon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStariBon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgStariBon.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgStariBon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStariBon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgStariBon.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgStariBon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgStariBon.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgStariBon.Appearance.GroupRow.Options.UseFont = true;
            this.dgStariBon.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgStariBon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgStariBon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgStariBon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgStariBon.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgStariBon.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgStariBon.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgStariBon.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgStariBon.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgStariBon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgStariBon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgStariBon.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgStariBon.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgStariBon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStariBon.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgStariBon.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgStariBon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.OddRow.Options.UseBackColor = true;
            this.dgStariBon.Appearance.OddRow.Options.UseForeColor = true;
            this.dgStariBon.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgStariBon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgStariBon.Appearance.Preview.Options.UseBackColor = true;
            this.dgStariBon.Appearance.Preview.Options.UseForeColor = true;
            this.dgStariBon.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgStariBon.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.Row.Options.UseBackColor = true;
            this.dgStariBon.Appearance.Row.Options.UseForeColor = true;
            this.dgStariBon.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgStariBon.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgStariBon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgStariBon.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgStariBon.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgStariBon.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgStariBon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgStariBon.Appearance.VertLine.Options.UseBackColor = true;
            this.dgStariBon.ColumnPanelRowHeight = 50;
            this.dgStariBon.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgStariBon.GridControl = this.dgStariBonovi;
            this.dgStariBon.Name = "dgStariBon";
            this.dgStariBon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStariBon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgStariBon.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgStariBon.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgStariBon.OptionsBehavior.Editable = false;
            this.dgStariBon.OptionsCustomization.AllowColumnMoving = false;
            this.dgStariBon.OptionsCustomization.AllowFilter = false;
            this.dgStariBon.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgStariBon.OptionsSelection.MultiSelect = true;
            this.dgStariBon.OptionsView.ColumnAutoWidth = false;
            this.dgStariBon.OptionsView.EnableAppearanceEvenRow = true;
            this.dgStariBon.OptionsView.EnableAppearanceOddRow = true;
            this.dgStariBon.OptionsView.ShowAutoFilterRow = true;
            this.dgStariBon.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgStariBon.OptionsView.ShowGroupPanel = false;
            this.dgStariBon.OptionsView.ShowIndicator = false;
            this.dgStariBon.PaintStyleName = "WindowsXP";
            this.dgStariBon.SynchronizeClones = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrenesiFakture);
            this.panel2.Controls.Add(this.lvlStatus);
            this.panel2.Controls.Add(this.btnPrenesi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 82);
            this.panel2.TabIndex = 41;
            // 
            // btnPrenesiFakture
            // 
            this.btnPrenesiFakture.Enabled = false;
            this.btnPrenesiFakture.Location = new System.Drawing.Point(564, 30);
            this.btnPrenesiFakture.Name = "btnPrenesiFakture";
            this.btnPrenesiFakture.Size = new System.Drawing.Size(166, 23);
            this.btnPrenesiFakture.TabIndex = 2;
            this.btnPrenesiFakture.Text = "Prenesi fakture";
            this.btnPrenesiFakture.UseVisualStyleBackColor = true;
            this.btnPrenesiFakture.Visible = false;
            this.btnPrenesiFakture.Click += new System.EventHandler(this.btnPrenesiFakture_Click);
            // 
            // lvlStatus
            // 
            this.lvlStatus.AutoSize = true;
            this.lvlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvlStatus.ForeColor = System.Drawing.Color.Red;
            this.lvlStatus.Location = new System.Drawing.Point(227, 49);
            this.lvlStatus.Name = "lvlStatus";
            this.lvlStatus.Size = new System.Drawing.Size(0, 24);
            this.lvlStatus.TabIndex = 1;
            // 
            // btnPrenesi
            // 
            this.btnPrenesi.Location = new System.Drawing.Point(43, 18);
            this.btnPrenesi.Name = "btnPrenesi";
            this.btnPrenesi.Size = new System.Drawing.Size(166, 23);
            this.btnPrenesi.TabIndex = 0;
            this.btnPrenesi.Text = "Prenesi bonove";
            this.btnPrenesi.UseVisualStyleBackColor = true;
            this.btnPrenesi.Click += new System.EventHandler(this.btnPrenesi_Click);
            // 
            // dgNoviBonovi
            // 
            this.dgNoviBonovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgNoviBonovi.Location = new System.Drawing.Point(0, 327);
            this.dgNoviBonovi.MainView = this.dgNoviBon;
            this.dgNoviBonovi.Name = "dgNoviBonovi";
            this.dgNoviBonovi.Size = new System.Drawing.Size(758, 160);
            this.dgNoviBonovi.TabIndex = 42;
            this.dgNoviBonovi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgNoviBon});
            // 
            // dgNoviBon
            // 
            this.dgNoviBon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNoviBon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNoviBon.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgNoviBon.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgNoviBon.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgNoviBon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgNoviBon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNoviBon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgNoviBon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgNoviBon.Appearance.Empty.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNoviBon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNoviBon.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgNoviBon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNoviBon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgNoviBon.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgNoviBon.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgNoviBon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNoviBon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNoviBon.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgNoviBon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNoviBon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNoviBon.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgNoviBon.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNoviBon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNoviBon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgNoviBon.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNoviBon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNoviBon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgNoviBon.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgNoviBon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgNoviBon.Appearance.GroupRow.Options.UseFont = true;
            this.dgNoviBon.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgNoviBon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgNoviBon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgNoviBon.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgNoviBon.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgNoviBon.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgNoviBon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgNoviBon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgNoviBon.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgNoviBon.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgNoviBon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.OddRow.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.OddRow.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgNoviBon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgNoviBon.Appearance.Preview.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.Preview.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgNoviBon.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.Row.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.Row.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgNoviBon.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgNoviBon.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgNoviBon.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgNoviBon.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgNoviBon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgNoviBon.Appearance.VertLine.Options.UseBackColor = true;
            this.dgNoviBon.ColumnPanelRowHeight = 50;
            this.dgNoviBon.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgNoviBon.GridControl = this.dgNoviBonovi;
            this.dgNoviBon.Name = "dgNoviBon";
            this.dgNoviBon.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgNoviBon.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgNoviBon.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgNoviBon.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgNoviBon.OptionsBehavior.Editable = false;
            this.dgNoviBon.OptionsCustomization.AllowColumnMoving = false;
            this.dgNoviBon.OptionsCustomization.AllowFilter = false;
            this.dgNoviBon.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgNoviBon.OptionsSelection.MultiSelect = true;
            this.dgNoviBon.OptionsView.ColumnAutoWidth = false;
            this.dgNoviBon.OptionsView.EnableAppearanceEvenRow = true;
            this.dgNoviBon.OptionsView.EnableAppearanceOddRow = true;
            this.dgNoviBon.OptionsView.ShowAutoFilterRow = true;
            this.dgNoviBon.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgNoviBon.OptionsView.ShowGroupPanel = false;
            this.dgNoviBon.OptionsView.ShowIndicator = false;
            this.dgNoviBon.PaintStyleName = "WindowsXP";
            this.dgNoviBon.SynchronizeClones = false;
            // 
            // frmPrenesiStare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 487);
            this.Controls.Add(this.dgNoviBonovi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgStariBonovi);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrenesiStare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prenesi stare bonove";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStariBonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStariBon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNoviBonovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNoviBon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDohvati;
        private DevExpress.XtraGrid.GridControl dgStariBonovi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgStariBon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrenesi;
        private DevExpress.XtraGrid.GridControl dgNoviBonovi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgNoviBon;
        private System.Windows.Forms.Label lvlStatus;
        private System.Windows.Forms.Button btnDohvatiFakture;
        private System.Windows.Forms.Button btnPrenesiFakture;
        private System.Windows.Forms.TextBox txtBonKod;
        private System.Windows.Forms.Label label1;
    }
}