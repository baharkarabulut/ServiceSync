namespace ServiceSync.Forms
{
	partial class FrmCariiller
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
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(2, 2);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(754, 618);
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
			// chartControl1
			// 
			simpleDiagram3D1.RotationMatrixSerializable = "0.868147283678642;-0.276282052255139;-0.412296642531911;0;-0.0570162866844381;0.7" +
    "69710163397156;-0.635842281871727;0;0.493020726637447;0.5755123734246;0.65246921" +
    "0875939;0;0;0;0;1";
			this.chartControl1.Diagram = simpleDiagram3D1;
			this.chartControl1.Location = new System.Drawing.Point(762, 2);
			this.chartControl1.Name = "chartControl1";
			series1.LegendTextPattern = "{A}";
			series1.Name = "Series 1";
			series1.SeriesID = 0;
			series1.View = pie3DSeriesView1;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartControl1.Size = new System.Drawing.Size(775, 396);
			this.chartControl1.TabIndex = 3;
			// 
			// FrmCariiller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1580, 624);
			this.Controls.Add(this.chartControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmCariiller";
			this.Text = "FrmCariiller";
			this.Load += new System.EventHandler(this.FrmCariiller_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraCharts.ChartControl chartControl1;
	}
}