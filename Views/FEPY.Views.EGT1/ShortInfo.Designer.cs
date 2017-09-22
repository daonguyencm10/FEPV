﻿namespace FEPV.Views
{
    partial class ShortInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortInfo));
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.gcShort = new DevExpress.XtraGrid.GridControl();
            this.gridViewShort1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbInOrOut = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVehicleNO = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonClientPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcShort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewShort1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.groupPanel2);
            this.ribbonClientPanel1.Controls.Add(this.groupPanel1);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(0, 0);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.ShowFocusRectangle = true;
            this.ribbonClientPanel1.Size = new System.Drawing.Size(792, 449);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.BackColor = System.Drawing.Color.Transparent;
            this.ribbonClientPanel1.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.ribbonClientPanel1.Style.BackColorGradientAngle = 90;
            this.ribbonClientPanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile;
            this.ribbonClientPanel1.Style.BorderBottomWidth = 1;
            this.ribbonClientPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.ribbonClientPanel1.Style.BorderLeftWidth = 1;
            this.ribbonClientPanel1.Style.BorderRightWidth = 1;
            this.ribbonClientPanel1.Style.BorderTopWidth = 1;
            this.ribbonClientPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonClientPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ribbonClientPanel1.TabIndex = 191;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.groupPanel2.Controls.Add(this.gcShort);
            this.groupPanel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupPanel2.Location = new System.Drawing.Point(3, 126);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(776, 308);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.groupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.groupPanel2.TabIndex = 192;
            this.groupPanel2.Text = "[车辆信息]";
            this.groupPanel2.TitleImage = ((System.Drawing.Image)(resources.GetObject("groupPanel2.TitleImage")));
            // 
            // gcShort
            // 
            this.gcShort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcShort.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcShort.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcShort.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcShort.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcShort.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcShort.Location = new System.Drawing.Point(0, 0);
            this.gcShort.MainView = this.gridViewShort1;
            this.gcShort.Name = "gcShort";
            this.gcShort.Size = new System.Drawing.Size(770, 284);
            this.gcShort.TabIndex = 1;
            this.gcShort.UseEmbeddedNavigator = true;
            this.gcShort.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewShort1});
            // 
            // gridViewShort1
            // 
            this.gridViewShort1.FixedLineWidth = 1;
            this.gridViewShort1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridViewShort1.GridControl = this.gcShort;
            this.gridViewShort1.Name = "gridViewShort1";
            this.gridViewShort1.OptionsBehavior.Editable = false;
            this.gridViewShort1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewShort1.OptionsSelection.MultiSelect = true;
            this.gridViewShort1.OptionsView.ColumnAutoWidth = false;
            this.gridViewShort1.OptionsView.RowAutoHeight = true;
            this.gridViewShort1.OptionsView.ShowGroupPanel = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.cbInOrOut);
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Controls.Add(this.panel1);
            this.groupPanel1.Controls.Add(this.txtVehicleNO);
            this.groupPanel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(773, 117);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.groupPanel1.TabIndex = 191;
            this.groupPanel1.Text = "[查询条件]";
            this.groupPanel1.TitleImage = ((System.Drawing.Image)(resources.GetObject("groupPanel1.TitleImage")));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(78, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 279;
            this.label5.Text = "状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(78, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 278;
            this.label4.Text = "车号";
            // 
            // cbInOrOut
            // 
            this.cbInOrOut.BackColor = System.Drawing.Color.White;
            this.cbInOrOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInOrOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbInOrOut.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.cbInOrOut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbInOrOut.FormattingEnabled = true;
            this.cbInOrOut.Items.AddRange(new object[] {
            "申请进厂",
            "申请出厂"});
            this.cbInOrOut.Location = new System.Drawing.Point(188, 32);
            this.cbInOrOut.Name = "cbInOrOut";
            this.cbInOrOut.Size = new System.Drawing.Size(200, 21);
            this.cbInOrOut.TabIndex = 274;
            this.cbInOrOut.Tag = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(82, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 1);
            this.panel2.TabIndex = 257;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(82, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 1);
            this.panel1.TabIndex = 254;
            // 
            // txtVehicleNO
            // 
            this.txtVehicleNO.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtVehicleNO.Border.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.txtVehicleNO.Border.Class = "RibbonGalleryContainer";
            this.txtVehicleNO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtVehicleNO.Border.PaddingTop = 2;
            this.txtVehicleNO.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.txtVehicleNO.Location = new System.Drawing.Point(188, 6);
            this.txtVehicleNO.Name = "txtVehicleNO";
            this.txtVehicleNO.Size = new System.Drawing.Size(200, 21);
            this.txtVehicleNO.TabIndex = 252;
            this.txtVehicleNO.WatermarkColor = System.Drawing.Color.Silver;
            this.txtVehicleNO.WatermarkFont = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.txtVehicleNO.WordWrap = false;
            // 
            // ShortInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(178)))), ((int)(((byte)(195)))));
            this.Controls.Add(this.ribbonClientPanel1);
            this.Name = "ShortInfo";
            this.Size = new System.Drawing.Size(792, 449);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcShort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewShort1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevExpress.XtraGrid.GridControl gcShort;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewShort1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbInOrOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVehicleNO;
    }
}
