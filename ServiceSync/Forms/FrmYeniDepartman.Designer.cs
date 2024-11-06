namespace ServiceSync.Forms
{
	partial class FrmYeniDepartman
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniDepartman));
			this.KategoriAd = new DevExpress.XtraEditors.TextEdit();
			this.textDepartmanAd = new System.Windows.Forms.TextBox();
			this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.KategoriAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// KategoriAd
			// 
			this.KategoriAd.EditValue = "Departman Adı:";
			this.KategoriAd.Location = new System.Drawing.Point(81, 33);
			this.KategoriAd.Name = "KategoriAd";
			this.KategoriAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(184)))));
			this.KategoriAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KategoriAd.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
			this.KategoriAd.Properties.Appearance.Options.UseBackColor = true;
			this.KategoriAd.Properties.Appearance.Options.UseFont = true;
			this.KategoriAd.Properties.Appearance.Options.UseForeColor = true;
			this.KategoriAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.KategoriAd.Size = new System.Drawing.Size(121, 24);
			this.KategoriAd.TabIndex = 30;
			// 
			// textDepartmanAd
			// 
			this.textDepartmanAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(184)))));
			this.textDepartmanAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textDepartmanAd.Location = new System.Drawing.Point(194, 40);
			this.textDepartmanAd.Margin = new System.Windows.Forms.Padding(5);
			this.textDepartmanAd.Name = "textDepartmanAd";
			this.textDepartmanAd.Size = new System.Drawing.Size(211, 13);
			this.textDepartmanAd.TabIndex = 55;
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKaydet.Appearance.Options.UseFont = true;
			this.BtnKaydet.Location = new System.Drawing.Point(81, 88);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(309, 46);
			this.BtnKaydet.TabIndex = 54;
			this.BtnKaydet.Text = "KAYDET";
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(81, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(309, 3);
			this.panel1.TabIndex = 53;
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(8, 20);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.ZoomPercent = 140D;
			this.pictureEdit1.Size = new System.Drawing.Size(67, 62);
			this.pictureEdit1.TabIndex = 51;
			// 
			// FrmYeniDepartman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(208)))), ((int)(((byte)(184)))));
			this.ClientSize = new System.Drawing.Size(425, 160);
			this.Controls.Add(this.textDepartmanAd);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.KategoriAd);
			this.Name = "FrmYeniDepartman";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmYeniDepartman";
			this.Load += new System.EventHandler(this.FrmYeniDepartman_Load);
			((System.ComponentModel.ISupportInitialize)(this.KategoriAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.TextEdit KategoriAd;
		private System.Windows.Forms.TextBox textDepartmanAd;
		private DevExpress.XtraEditors.SimpleButton BtnKaydet;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
	}
}