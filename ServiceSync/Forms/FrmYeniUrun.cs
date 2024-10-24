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
	public partial class FrmYeniUrun : DevExpress.XtraEditors.XtraForm
	{
		public FrmYeniUrun()
		{
			InitializeComponent();
		}

		private void BtnVazgec_Click(object sender, EventArgs e)
		{
			//FrmYeniUrun fr = new FrmYeniUrun();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			DbServicesEntities db = new DbServicesEntities();
			TblURUN t = new TblURUN();

			// Ürün adı ve marka
			t.AD = txtUrunAd.Text;
			t.MARKA = txtMarkaAd.Text;

			// Alış Fiyatı - Geçerli bir sayı olup olmadığını kontrol et
			if (decimal.TryParse(txtAlisFiyat.Text, out decimal alisFiyati))
			{
				t.ALISFIYATI = alisFiyati;
			}
			else
			{
				MessageBox.Show("Geçerli bir alış fiyatı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // Geçersiz giriş varsa işlemi durdur
			}

			// Satış Fiyatı - Geçerli bir sayı olup olmadığını kontrol et
			if (decimal.TryParse(txtSatisFiyat.Text, out decimal satisFiyati))
			{
				t.SATISFIYATI = satisFiyati;
			}
			else
			{
				MessageBox.Show("Geçerli bir satış fiyatı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // Geçersiz giriş varsa işlemi durdur
			}

			// Stok - Geçerli bir kısa sayı olup olmadığını kontrol et
			if (short.TryParse(txtStok.Text, out short stok))
			{
				t.STOK = stok;
			}
			else
			{
				MessageBox.Show("Geçerli bir stok miktarı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // Geçersiz giriş varsa işlemi durdur
			}

			// Kategori - Geçerli bir kategori olup olmadığını kontrol et
			if (byte.TryParse(txtKategori.Text, out byte kategori))
			{
				t.KATEGORİ = kategori;
			}
			else
			{
				MessageBox.Show("Geçerli bir kategori giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // Geçersiz giriş varsa işlemi durdur
			}

			// Veritabanına ekleme işlemi
			db.TblURUN.Add(t);
			db.SaveChanges();

			// Başarı mesajı
			MessageBox.Show("Ürün başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

	}
}