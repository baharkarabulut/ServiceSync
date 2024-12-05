namespace ServiceSync.Forms
{
	partial class FrmYeniKategori
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniKategori));
			this.txtKategoriAd = new System.Windows.Forms.TextBox();
			this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.KategoriAd = new DevExpress.XtraEditors.TextEdit();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.KategoriAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKategoriAd
			// 
			this.txtKategoriAd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.txtKategoriAd.Location = new System.Drawing.Point(191, 83);
			this.txtKategoriAd.Margin = new System.Windows.Forms.Padding(5);
			this.txtKategoriAd.Name = "txtKategoriAd";
			this.txtKategoriAd.Size = new System.Drawing.Size(241, 20);
			this.txtKategoriAd.TabIndex = 50;
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKaydet.Appearance.Options.UseFont = true;
			this.BtnKaydet.Location = new System.Drawing.Point(85, 143);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(347, 46);
			this.BtnKaydet.TabIndex = 48;
			this.BtnKaydet.Text = "KAYDET";
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Location = new System.Drawing.Point(85, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(347, 3);
			this.panel1.TabIndex = 30;
			// 
			// KategoriAd
			// 
			this.KategoriAd.EditValue = "Kategori Adı:";
			this.KategoriAd.Location = new System.Drawing.Point(85, 81);
			this.KategoriAd.Name = "KategoriAd";
			this.KategoriAd.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.KategoriAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.KategoriAd.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
			this.KategoriAd.Properties.Appearance.Options.UseBackColor = true;
			this.KategoriAd.Properties.Appearance.Options.UseFont = true;
			this.KategoriAd.Properties.Appearance.Options.UseForeColor = true;
			this.KategoriAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.KategoriAd.Size = new System.Drawing.Size(98, 24);
			this.KategoriAd.TabIndex = 29;
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(20, 66);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(59, 46);
			this.pictureEdit1.TabIndex = 28;
			// 
			// FrmYeniKategori
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(465, 236);
			this.Controls.Add(this.txtKategoriAd);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.KategoriAd);
			this.Controls.Add(this.pictureEdit1);
			this.Name = "FrmYeniKategori";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmYeniKategori";
			this.Load += new System.EventHandler(this.FrmYeniKategori_Load);
			((System.ComponentModel.ISupportInitialize)(this.KategoriAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtKategoriAd;
		private DevExpress.XtraEditors.SimpleButton BtnKaydet;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.TextEdit KategoriAd;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
	}
}