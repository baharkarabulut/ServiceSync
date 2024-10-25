using DevExpress.XtraEditors;
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
	public partial class FrmKategori : Form
	{
		public FrmKategori()
		{
			InitializeComponent();
		}
		DbServicesEntities db = new DbServicesEntities();
		private void FrmKategori_Load(object sender, EventArgs e)
		{
			var degerler = from k in db.TblKATEGORI
						   select new
						   {
							   k.ID,
							   k.AD
						   };
			gridControl1.DataSource = degerler.ToList();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			TblKATEGORI t = new TblKATEGORI();
			t.AD = textKategoriAd.Text;
			db.TblKATEGORI.Add(t);
			db.SaveChanges();
			MessageBox.Show("Kategori başarıyla kaydedildi.");
		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			var degerler = from k in db.TblKATEGORI
						   select new
						   {
							   k.ID,
							   k.AD
						   };
			gridControl1.DataSource = degerler.ToList();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			textKategoriAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textID.Text);
			var deger = db.TblKATEGORI.Find(id);
			db.TblKATEGORI.Remove(deger);
			db.SaveChanges();
			MessageBox.Show("Kategori başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textID.Text);
			var deger = db.TblKATEGORI.Find(id);
			deger.AD = textKategoriAd.Text;
			db.SaveChanges();
			MessageBox.Show("Kategori başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
