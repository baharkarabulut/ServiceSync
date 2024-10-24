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
			t.AD = txtUrunAd.Text;
			t.ALISFIYATI = decimal.Parse(txtAlisFiyat.Text);
			t.SATISFIYATI = decimal.Parse(txtSatisFiyat.Text);
			t.STOK = short.Parse(txtStok.Text);
			t.KATEGORİ = byte.Parse(txtKategori.Text);	
			t.MARKA = txtMarkaAd.Text;
			db.TblURUN.Add(t);
			db.SaveChanges();
			MessageBox.Show("Ürün başarıyla kaydedildi.");
		}
	}
}