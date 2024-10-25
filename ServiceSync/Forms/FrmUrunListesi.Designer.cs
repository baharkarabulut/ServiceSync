namespace ServiceSync.Forms
{
	partial class FrmUrunListesi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListesi));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.textID = new DevExpress.XtraEditors.TextEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
			this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
			this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
			this.textStok = new DevExpress.XtraEditors.TextEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.textSatisFiyat = new DevExpress.XtraEditors.TextEdit();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.textAlisFiyat = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.textMarkaAd = new DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.textUrunAd = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textStok.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textSatisFiyat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textAlisFiyat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textMarkaAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textUrunAd.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(0, -1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1024, 833);
			this.gridControl1.TabIndex = 0;
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
			this.groupControl1.Controls.Add(this.labelControl6);
			this.groupControl1.Controls.Add(this.lookUpEdit1);
			this.groupControl1.Controls.Add(this.textStok);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.textSatisFiyat);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.textAlisFiyat);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.textMarkaAd);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.textUrunAd);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new System.Drawing.Point(1030, -1);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(886, 761);
			this.groupControl1.TabIndex = 1;
			this.groupControl1.Text = "Ürün İşlemleri";
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
			this.labelControl7.Location = new System.Drawing.Point(91, 62);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(15, 13);
			this.labelControl7.TabIndex = 19;
			this.labelControl7.Text = "ID:";
			// 
			// BtnListele
			// 
			this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
			this.BtnListele.Location = new System.Drawing.Point(112, 400);
			this.BtnListele.Name = "BtnListele";
			this.BtnListele.Size = new System.Drawing.Size(336, 40);
			this.BtnListele.TabIndex = 18;
			this.BtnListele.Text = "LİSTELE";
			this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
			this.BtnGuncelle.Location = new System.Drawing.Point(112, 354);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(336, 40);
			this.BtnGuncelle.TabIndex = 17;
			this.BtnGuncelle.Text = "GÜNCELLE";
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
			this.BtnSil.Location = new System.Drawing.Point(112, 308);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(336, 40);
			this.BtnSil.TabIndex = 16;
			this.BtnSil.Text = "SİL";
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
			this.BtnKaydet.Location = new System.Drawing.Point(112, 262);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(336, 40);
			this.BtnKaydet.TabIndex = 15;
			this.BtnKaydet.Text = "KAYDET";
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(62, 218);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(44, 13);
			this.labelControl6.TabIndex = 14;
			this.labelControl6.Text = "Kategori:";
			// 
			// lookUpEdit1
			// 
			this.lookUpEdit1.Location = new System.Drawing.Point(112, 215);
			this.lookUpEdit1.Name = "lookUpEdit1";
			this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lookUpEdit1.Properties.DisplayMember = "AD";
			this.lookUpEdit1.Properties.ValueMember = "ID";
			this.lookUpEdit1.Size = new System.Drawing.Size(336, 20);
			this.lookUpEdit1.TabIndex = 13;
			// 
			// textStok
			// 
			this.textStok.Location = new System.Drawing.Point(112, 189);
			this.textStok.Name = "textStok";
			this.textStok.Size = new System.Drawing.Size(336, 20);
			this.textStok.TabIndex = 12;
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(81, 192);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(25, 13);
			this.labelControl5.TabIndex = 11;
			this.labelControl5.Text = "Stok:";
			// 
			// textSatisFiyat
			// 
			this.textSatisFiyat.Location = new System.Drawing.Point(112, 163);
			this.textSatisFiyat.Name = "textSatisFiyat";
			this.textSatisFiyat.Size = new System.Drawing.Size(336, 20);
			this.textSatisFiyat.TabIndex = 10;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(50, 166);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(56, 13);
			this.labelControl4.TabIndex = 9;
			this.labelControl4.Text = "Satış Fiyatı:";
			// 
			// textAlisFiyat
			// 
			this.textAlisFiyat.Location = new System.Drawing.Point(112, 137);
			this.textAlisFiyat.Name = "textAlisFiyat";
			this.textAlisFiyat.Size = new System.Drawing.Size(336, 20);
			this.textAlisFiyat.TabIndex = 8;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(57, 140);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(49, 13);
			this.labelControl3.TabIndex = 7;
			this.labelControl3.Text = "Alış Fiyatı:";
			// 
			// textMarkaAd
			// 
			this.textMarkaAd.Location = new System.Drawing.Point(112, 111);
			this.textMarkaAd.Name = "textMarkaAd";
			this.textMarkaAd.Size = new System.Drawing.Size(336, 20);
			this.textMarkaAd.TabIndex = 6;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(29, 114);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(77, 13);
			this.labelControl2.TabIndex = 5;
			this.labelControl2.Text = "Ürün Marka Adı:";
			// 
			// textUrunAd
			// 
			this.textUrunAd.Location = new System.Drawing.Point(112, 85);
			this.textUrunAd.Name = "textUrunAd";
			this.textUrunAd.Size = new System.Drawing.Size(336, 20);
			this.textUrunAd.TabIndex = 4;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(61, 88);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(45, 13);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Ürün Adı:";
			// 
			// FrmUrunListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1580, 624);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmUrunListesi";
			this.Text = "Ürünler Listesi";
			this.Load += new System.EventHandler(this.FrmProductList_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textStok.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textSatisFiyat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textAlisFiyat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textMarkaAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textUrunAd.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.TextEdit textUrunAd;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.TextEdit textStok;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.TextEdit textSatisFiyat;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.TextEdit textAlisFiyat;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit textMarkaAd;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
		private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
		private DevExpress.XtraEditors.SimpleButton BtnSil;
		private DevExpress.XtraEditors.SimpleButton BtnKaydet;
		private DevExpress.XtraEditors.SimpleButton BtnListele;
		private DevExpress.XtraEditors.TextEdit textID;
		private DevExpress.XtraEditors.LabelControl labelControl7;
	}
}