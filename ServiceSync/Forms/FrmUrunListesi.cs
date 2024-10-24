using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceSync.Forms
{
	public partial class FrmUrunListesi : Form
	{
		public FrmUrunListesi()
		{
			InitializeComponent();
		}
		void metot1()
		{
			var urunler = from u in db.TblURUN
						  select new
						  {
							  u.ID,
							  u.AD,
							  u.MARKA,
							  KATEGORI = u.TblKATEGORI.AD,
							  u.STOK,
							  u.ALISFIYATI,
							  u.SATISFIYATI
						  };
			gridControl1.DataSource = urunler.ToList();
		}
		DbServicesEntities db = new DbServicesEntities();
		private void FrmProductList_Load(object sender, EventArgs e)
		{
			//Listeleme = ToList
			// var urunler = db.TblURUN.ToList();
			metot1();
			lookUpEdit1.Properties.DataSource = db.TblKATEGORI.ToList();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			TblURUN t = new TblURUN();
			t.AD = textUrunAd.Text;
			t.MARKA = textMarkaAd.Text;
			t.ALISFIYATI = decimal.Parse(textAlisFiyat.Text);
			t.SATISFIYATI = decimal.Parse(textSatisFiyat.Text);
			t.STOK = short.Parse(textStok.Text);
			t.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
			db.TblURUN.Add(t);
			db.SaveChanges();
			MessageBox.Show("Ürün başarıyla kaydedildi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			//Listeleme = ToList
			metot1();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			textUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
			textMarkaAd.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
			textAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYATI").ToString();
			textSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYATI").ToString();
			textStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
		}


		// Silme işlemi: Remove
		private void BtnSil_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textID.Text);
			var deger = db.TblURUN.Find(id);
			db.TblURUN.Remove(deger);
			db.SaveChanges();
			MessageBox.Show("Ürün başarıyla silindi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textID.Text);
			var deger = db.TblURUN.Find(id);
			deger.AD = textUrunAd.Text;
			deger.MARKA = textMarkaAd.Text;
			deger.ALISFIYATI = decimal.Parse(textAlisFiyat.Text);
			deger.SATISFIYATI = decimal.Parse(textSatisFiyat.Text);
			deger.STOK = short.Parse(textStok.Text);
			deger.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
