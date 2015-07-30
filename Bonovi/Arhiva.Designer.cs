namespace Bonovi
{
    partial class frmArhiva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.colpg_opis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpg_papiri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colpg_server = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpg_katalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpg_godina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgPoslGod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgPoslovnaGodina = new DevExpress.XtraGrid.GridControl();
            this.poslovnagodinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arhiva = new Bonovi.Arhiva();
            this.poslovnagodinaTableAdapter = new Bonovi.ArhivaTableAdapters.poslovnagodinaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslGod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslovnaGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnagodinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhiva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIzlaz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 48);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "2 x klik ili enter za odabir poslovne godine";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(405, 7);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 0;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // colpg_opis
            // 
            this.colpg_opis.Caption = "Opis";
            this.colpg_opis.FieldName = "pg_opis";
            this.colpg_opis.Name = "colpg_opis";
            this.colpg_opis.Visible = true;
            this.colpg_opis.VisibleIndex = 1;
            this.colpg_opis.Width = 150;
            // 
            // colpg_papiri
            // 
            this.colpg_papiri.Caption = "Izrada papira";
            this.colpg_papiri.ColumnEdit = this.repositoryItemTextEdit1;
            this.colpg_papiri.FieldName = "pg_papiri";
            this.colpg_papiri.Name = "colpg_papiri";
            this.colpg_papiri.Visible = true;
            this.colpg_papiri.VisibleIndex = 2;
            this.colpg_papiri.Width = 106;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colpg_server
            // 
            this.colpg_server.FieldName = "pg_server";
            this.colpg_server.Name = "colpg_server";
            // 
            // colpg_katalog
            // 
            this.colpg_katalog.FieldName = "pg_katalog";
            this.colpg_katalog.Name = "colpg_katalog";
            // 
            // colpg_godina
            // 
            this.colpg_godina.Caption = "Godina";
            this.colpg_godina.FieldName = "pg_godina";
            this.colpg_godina.Name = "colpg_godina";
            this.colpg_godina.Visible = true;
            this.colpg_godina.VisibleIndex = 0;
            this.colpg_godina.Width = 126;
            // 
            // dgPoslGod
            // 
            this.dgPoslGod.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPoslGod.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslGod.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.dgPoslGod.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.dgPoslGod.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.dgPoslGod.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.dgPoslGod.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslGod.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.dgPoslGod.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.dgPoslGod.Appearance.Empty.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.EvenRow.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.EvenRow.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPoslGod.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslGod.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.dgPoslGod.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPoslGod.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.dgPoslGod.Appearance.FilterPanel.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.FilterPanel.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.dgPoslGod.Appearance.FixedLine.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgPoslGod.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPoslGod.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslGod.Appearance.FooterPanel.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.dgPoslGod.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslGod.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslGod.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.GroupButton.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.GroupButton.Options.UseBorderColor = true;
            this.dgPoslGod.Appearance.GroupButton.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslGod.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslGod.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.GroupFooter.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.dgPoslGod.Appearance.GroupFooter.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPoslGod.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslGod.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgPoslGod.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dgPoslGod.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.GroupRow.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.GroupRow.Options.UseBorderColor = true;
            this.dgPoslGod.Appearance.GroupRow.Options.UseFont = true;
            this.dgPoslGod.Appearance.GroupRow.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.dgPoslGod.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgPoslGod.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.dgPoslGod.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.dgPoslGod.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgPoslGod.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.dgPoslGod.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.dgPoslGod.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.dgPoslGod.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgPoslGod.Appearance.HorzLine.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.dgPoslGod.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.OddRow.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.OddRow.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.dgPoslGod.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.dgPoslGod.Appearance.Preview.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.Preview.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgPoslGod.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.Row.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.Row.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.dgPoslGod.Appearance.RowSeparator.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.dgPoslGod.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.dgPoslGod.Appearance.SelectedRow.Options.UseBackColor = true;
            this.dgPoslGod.Appearance.SelectedRow.Options.UseForeColor = true;
            this.dgPoslGod.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.dgPoslGod.Appearance.VertLine.Options.UseBackColor = true;
            this.dgPoslGod.ColumnPanelRowHeight = 30;
            this.dgPoslGod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpg_godina,
            this.colpg_opis,
            this.colpg_papiri,
            this.colpg_server,
            this.colpg_katalog});
            this.dgPoslGod.CustomizationFormBounds = new System.Drawing.Rectangle(1205, 603, 216, 199);
            this.dgPoslGod.GridControl = this.dgPoslovnaGodina;
            this.dgPoslGod.Name = "dgPoslGod";
            this.dgPoslGod.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPoslGod.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgPoslGod.OptionsBehavior.AutoSelectAllInEditor = false;
            this.dgPoslGod.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.dgPoslGod.OptionsBehavior.Editable = false;
            this.dgPoslGod.OptionsCustomization.AllowColumnMoving = false;
            this.dgPoslGod.OptionsCustomization.AllowFilter = false;
            this.dgPoslGod.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgPoslGod.OptionsSelection.MultiSelect = true;
            this.dgPoslGod.OptionsView.ColumnAutoWidth = false;
            this.dgPoslGod.OptionsView.EnableAppearanceEvenRow = true;
            this.dgPoslGod.OptionsView.EnableAppearanceOddRow = true;
            this.dgPoslGod.OptionsView.ShowAutoFilterRow = true;
            this.dgPoslGod.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.dgPoslGod.OptionsView.ShowGroupPanel = false;
            this.dgPoslGod.OptionsView.ShowIndicator = false;
            this.dgPoslGod.PaintStyleName = "WindowsXP";
            this.dgPoslGod.SynchronizeClones = false;
            // 
            // dgPoslovnaGodina
            // 
            this.dgPoslovnaGodina.DataSource = this.poslovnagodinaBindingSource;
            this.dgPoslovnaGodina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPoslovnaGodina.Location = new System.Drawing.Point(0, 0);
            this.dgPoslovnaGodina.MainView = this.dgPoslGod;
            this.dgPoslovnaGodina.Name = "dgPoslovnaGodina";
            this.dgPoslovnaGodina.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.dgPoslovnaGodina.Size = new System.Drawing.Size(584, 163);
            this.dgPoslovnaGodina.TabIndex = 18;
            this.dgPoslovnaGodina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgPoslGod});
            this.dgPoslovnaGodina.DoubleClick += new System.EventHandler(this.dgPoslovnaGodina_DoubleClick);
            this.dgPoslovnaGodina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgPoslovnaGodina_KeyDown);
            // 
            // poslovnagodinaBindingSource
            // 
            this.poslovnagodinaBindingSource.DataMember = "poslovnagodina";
            this.poslovnagodinaBindingSource.DataSource = this.arhiva;
            // 
            // arhiva
            // 
            this.arhiva.DataSetName = "Arhiva";
            this.arhiva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poslovnagodinaTableAdapter
            // 
            this.poslovnagodinaTableAdapter.ClearBeforeFill = true;
            // 
            // frmArhiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 163);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPoslovnaGodina);
            this.Name = "frmArhiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arhiva";
            this.Load += new System.EventHandler(this.frmArhiva_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslGod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoslovnaGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslovnagodinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhiva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzlaz;
        private DevExpress.XtraGrid.Columns.GridColumn colpg_opis;
        private DevExpress.XtraGrid.Columns.GridColumn colpg_papiri;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colpg_server;
        private DevExpress.XtraGrid.Columns.GridColumn colpg_katalog;
        private DevExpress.XtraGrid.Columns.GridColumn colpg_godina;
        private DevExpress.XtraGrid.Views.Grid.GridView dgPoslGod;
        private DevExpress.XtraGrid.GridControl dgPoslovnaGodina;
        private Arhiva arhiva;
        private System.Windows.Forms.BindingSource poslovnagodinaBindingSource;
        private ArhivaTableAdapters.poslovnagodinaTableAdapter poslovnagodinaTableAdapter;
    }
}