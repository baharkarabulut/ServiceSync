namespace ServiceSync.Forms
{
	partial class FrmMarkalar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarkalar));
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.panel4 = new System.Windows.Forms.Panel();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
			this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(1, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(519, 677);
			this.gridControl1.TabIndex = 2;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Appearance.Row.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
			this.gridView1.Appearance.Row.Options.UseBackColor = true;
			this.gridView1.Appearance.Row.Options.UseBorderColor = true;
			this.gridView1.Appearance.Row.Options.UseForeColor = true;
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.pictureEdit1);
			this.panel1.Controls.Add(this.labelControl2);
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Location = new System.Drawing.Point(537, 13);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(239, 146);
			this.panel1.TabIndex = 3;
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(143, 74);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.ZoomPercent = 150D;
			this.pictureEdit1.Size = new System.Drawing.Size(93, 69);
			this.pictureEdit1.TabIndex = 3;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(25, 67);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(63, 50);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "584";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(15, 22);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(157, 19);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Toplam Ürün Sayısı";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.pictureEdit2);
			this.panel2.Controls.Add(this.labelControl3);
			this.panel2.Controls.Add(this.labelControl4);
			this.panel2.Location = new System.Drawing.Point(1031, 13);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(239, 146);
			this.panel2.TabIndex = 4;
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
			this.pictureEdit2.Location = new System.Drawing.Point(143, 74);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
			this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit2.Properties.ZoomPercent = 150D;
			this.pictureEdit2.Size = new System.Drawing.Size(93, 69);
			this.pictureEdit2.TabIndex = 4;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Appearance.Options.UseForeColor = true;
			this.labelControl3.Location = new System.Drawing.Point(25, 67);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(63, 50);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "584";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Appearance.Options.UseForeColor = true;
			this.labelControl4.Location = new System.Drawing.Point(15, 22);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(169, 19);
			this.labelControl4.TabIndex = 0;
			this.labelControl4.Text = "Toplam Marka Sayısı";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(227)))));
			this.panel3.Controls.Add(this.labelControl5);
			this.panel3.Controls.Add(this.labelControl6);
			this.panel3.Location = new System.Drawing.Point(784, 13);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(239, 146);
			this.panel3.TabIndex = 5;
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Appearance.Options.UseForeColor = true;
			this.labelControl5.Location = new System.Drawing.Point(26, 77);
			this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(114, 40);
			this.labelControl5.TabIndex = 1;
			this.labelControl5.Text = "Siemens";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Appearance.Options.UseForeColor = true;
			this.labelControl6.Location = new System.Drawing.Point(15, 22);
			this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(220, 19);
			this.labelControl6.TabIndex = 0;
			this.labelControl6.Text = "En Fazla Ürünü Olan Marka";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(234)))));
			this.panel4.Controls.Add(this.labelControl7);
			this.panel4.Controls.Add(this.labelControl8);
			this.panel4.Location = new System.Drawing.Point(1278, 13);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(239, 146);
			this.panel4.TabIndex = 6;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Appearance.Options.UseForeColor = true;
			this.labelControl7.Location = new System.Drawing.Point(26, 77);
			this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(51, 40);
			this.labelControl7.TabIndex = 1;
			this.labelControl7.Text = "584";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Appearance.Options.UseForeColor = true;
			this.labelControl8.Location = new System.Drawing.Point(15, 22);
			this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(195, 19);
			this.labelControl8.TabIndex = 0;
			this.labelControl8.Text = "En Yüksek Fiyatlı Marka";
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.pictureEdit3);
			this.panelControl1.Controls.Add(this.labelControl10);
			this.panelControl1.Controls.Add(this.labelControl9);
			this.panelControl1.Controls.Add(this.chartControl1);
			this.panelControl1.Location = new System.Drawing.Point(537, 166);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(486, 511);
			this.panelControl1.TabIndex = 8;
			// 
			// pictureEdit3
			// 
			this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
			this.pictureEdit3.Location = new System.Drawing.Point(7, 14);
			this.pictureEdit3.Name = "pictureEdit3";
			this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
			this.pictureEdit3.Properties.ZoomPercent = 150D;
			this.pictureEdit3.Size = new System.Drawing.Size(81, 66);
			this.pictureEdit3.TabIndex = 4;
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl10.Appearance.Options.UseFont = true;
			this.labelControl10.Location = new System.Drawing.Point(94, 50);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(355, 21);
			this.labelControl10.TabIndex = 2;
			this.labelControl10.Text = "Ürünlerinizin marka istatistikleri aşağıda verilmiştir.";
			this.labelControl10.Click += new System.EventHandler(this.labelControl10_Click);
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl9.Appearance.Options.UseFont = true;
			this.labelControl9.Location = new System.Drawing.Point(94, 14);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(211, 30);
			this.labelControl9.TabIndex = 1;
			this.labelControl9.Text = "Marka ve İstatistikleri";
			// 
			// chartControl1
			// 
			this.chartControl1.Location = new System.Drawing.Point(7, 86);
			this.chartControl1.Name = "chartControl1";
			series1.Name = "Series 1";
			series1.SeriesID = 0;
			series1.View = pieSeriesView1;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartControl1.Size = new System.Drawing.Size(474, 409);
			this.chartControl1.TabIndex = 0;
			// 
			// panelControl2
			// 
			this.panelControl2.Location = new System.Drawing.Point(1031, 166);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new System.Drawing.Size(486, 338);
			this.panelControl2.TabIndex = 9;
			// 
			// panelControl3
			// 
			this.panelControl3.Location = new System.Drawing.Point(1031, 511);
			this.panelControl3.Name = "panelControl3";
			this.panelControl3.Size = new System.Drawing.Size(486, 166);
			this.panelControl3.TabIndex = 10;
			// 
			// FrmMarkalar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1618, 677);
			this.Controls.Add(this.panelControl3);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.panelControl1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmMarkalar";
			this.Text = "FrmMarkalar";
			this.Load += new System.EventHandler(this.FrmMarkalar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.Panel panel2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private System.Windows.Forms.Panel panel3;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private System.Windows.Forms.Panel panel4;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.PictureEdit pictureEdit2;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraEditors.PanelControl panelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.PictureEdit pictureEdit3;
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
	}
}