namespace ServiceSync.Forms
{
	partial class FrmKategori
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategori));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.textID = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
			this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
			this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.textKategoriAd = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
			this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
			this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
			this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textKategoriAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			this.groupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
			this.groupControl3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
			this.groupControl4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
			this.groupControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(-2, -2);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1011, 385);
			this.gridControl1.TabIndex = 1;
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
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.textID);
			this.groupControl1.Controls.Add(this.labelControl7);
			this.groupControl1.Controls.Add(this.BtnListele);
			this.groupControl1.Controls.Add(this.BtnGuncelle);
			this.groupControl1.Controls.Add(this.BtnSil);
			this.groupControl1.Controls.Add(this.BtnKaydet);
			this.groupControl1.Controls.Add(this.textKategoriAd);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new System.Drawing.Point(1015, -2);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(507, 606);
			this.groupControl1.TabIndex = 2;
			this.groupControl1.Text = "Kategori İşlemleri";
			// 
			// textID
			// 
			this.textID.Enabled = false;
			this.textID.Location = new System.Drawing.Point(112, 59);
			this.textID.Name = "textID";
			this.textID.Size = new System.Drawing.Size(336, 20);
			this.textID.TabIndex = 20;
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(48, 62);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(58, 13);
			this.labelControl7.TabIndex = 19;
			this.labelControl7.Text = "Kategori ID:";
			// 
			// BtnListele
			// 
			this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
			this.BtnListele.Location = new System.Drawing.Point(112, 260);
			this.BtnListele.Name = "BtnListele";
			this.BtnListele.Size = new System.Drawing.Size(336, 40);
			this.BtnListele.TabIndex = 18;
			this.BtnListele.Text = "LİSTELE";
			this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
			this.BtnGuncelle.Location = new System.Drawing.Point(112, 214);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(336, 40);
			this.BtnGuncelle.TabIndex = 17;
			this.BtnGuncelle.Text = "GÜNCELLE";
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
			this.BtnSil.Location = new System.Drawing.Point(112, 168);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(336, 40);
			this.BtnSil.TabIndex = 16;
			this.BtnSil.Text = "SİL";
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
			this.BtnKaydet.Location = new System.Drawing.Point(112, 122);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(336, 40);
			this.BtnKaydet.TabIndex = 15;
			this.BtnKaydet.Text = "KAYDET";
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// textKategoriAd
			// 
			this.textKategoriAd.Location = new System.Drawing.Point(112, 85);
			this.textKategoriAd.Name = "textKategoriAd";
			this.textKategoriAd.Size = new System.Drawing.Size(336, 20);
			this.textKategoriAd.TabIndex = 4;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(44, 88);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(62, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Kategori Adı:";
			// 
			// groupControl2
			// 
			this.groupControl2.Controls.Add(this.pictureEdit1);
			this.groupControl2.Location = new System.Drawing.Point(13, 389);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(242, 215);
			this.groupControl2.TabIndex = 3;
			this.groupControl2.Text = "Lenovo";
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(2, 23);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(238, 190);
			this.pictureEdit1.TabIndex = 0;
			// 
			// groupControl3
			// 
			this.groupControl3.Controls.Add(this.pictureEdit2);
			this.groupControl3.Location = new System.Drawing.Point(261, 389);
			this.groupControl3.Name = "groupControl3";
			this.groupControl3.Size = new System.Drawing.Size(242, 215);
			this.groupControl3.TabIndex = 4;
			this.groupControl3.Text = "Arçelik";
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
			this.pictureEdit2.Location = new System.Drawing.Point(2, 23);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit2.Size = new System.Drawing.Size(238, 190);
			this.pictureEdit2.TabIndex = 1;
			// 
			// groupControl4
			// 
			this.groupControl4.Controls.Add(this.pictureEdit3);
			this.groupControl4.Location = new System.Drawing.Point(509, 389);
			this.groupControl4.Name = "groupControl4";
			this.groupControl4.Size = new System.Drawing.Size(242, 215);
			this.groupControl4.TabIndex = 5;
			this.groupControl4.Text = "Siemens";
			// 
			// pictureEdit3
			// 
			this.pictureEdit3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
			this.pictureEdit3.Location = new System.Drawing.Point(2, 23);
			this.pictureEdit3.Name = "pictureEdit3";
			this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit3.Size = new System.Drawing.Size(238, 190);
			this.pictureEdit3.TabIndex = 1;
			// 
			// groupControl5
			// 
			this.groupControl5.Controls.Add(this.pictureEdit4);
			this.groupControl5.Location = new System.Drawing.Point(757, 389);
			this.groupControl5.Name = "groupControl5";
			this.groupControl5.Size = new System.Drawing.Size(242, 215);
			this.groupControl5.TabIndex = 4;
			this.groupControl5.Text = "Bosch";
			// 
			// pictureEdit4
			// 
			this.pictureEdit4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
			this.pictureEdit4.Location = new System.Drawing.Point(2, 23);
			this.pictureEdit4.Name = "pictureEdit4";
			this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit4.Size = new System.Drawing.Size(238, 190);
			this.pictureEdit4.TabIndex = 1;
			// 
			// FrmKategori
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1618, 677);
			this.Controls.Add(this.groupControl5);
			this.Controls.Add(this.groupControl4);
			this.Controls.Add(this.groupControl3);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmKategori";
			this.Text = "FrmKategori";
			this.Load += new System.EventHandler(this.FrmKategori_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textKategoriAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			this.groupControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
			this.groupControl3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
			this.groupControl4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
			this.groupControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.TextEdit textID;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.SimpleButton BtnListele;
		private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
		private DevExpress.XtraEditors.SimpleButton BtnSil;
		private DevExpress.XtraEditors.SimpleButton BtnKaydet;
		private DevExpress.XtraEditors.TextEdit textKategoriAd;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.GroupControl groupControl3;
		private DevExpress.XtraEditors.GroupControl groupControl4;
		private DevExpress.XtraEditors.GroupControl groupControl5;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.PictureEdit pictureEdit2;
		private DevExpress.XtraEditors.PictureEdit pictureEdit3;
		private DevExpress.XtraEditors.PictureEdit pictureEdit4;
	}
}