﻿namespace FEPV.Views
{
    partial class ShowVoucherView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowVoucherView));
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.VouList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VouList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.VouList);
            this.xtraTabPage1.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(773, 397);
            this.xtraTabPage1.Text = "Show Data";
            // 
            // VouList
            // 
            this.VouList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VouList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.VouList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.VouList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.VouList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.VouList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.VouList.Location = new System.Drawing.Point(0, 0);
            this.VouList.MainView = this.gridView1;
            this.VouList.Name = "VouList";
            this.VouList.Size = new System.Drawing.Size(773, 397);
            this.VouList.TabIndex = 1;
            this.VouList.UseEmbeddedNavigator = true;
            this.VouList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.VouList;
            this.gridView1.GroupFormat = "[#image]{1} {2}";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(779, 425);
            this.xtraTabControl1.TabIndex = 14;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // ShowVoucherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.Controls.Add(this.xtraTabControl1);
            this.Font = new System.Drawing.Font("SimSun", 9.75F);
            this.Name = "ShowVoucherView";
            this.Size = new System.Drawing.Size(779, 425);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VouList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        public DevExpress.XtraGrid.GridControl VouList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;

    }
}
