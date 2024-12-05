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
	public partial class FrmCariEkle : Form
	{
		DbServicesEntities db = new DbServicesEntities();
		public FrmCariEkle()
		{
			InitializeComponent();
		}
		private void FrmCariEkle_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			TblCARI t = new TblCARI();
			t.AD = textCariAd.Text;
			t.SOYAD = textCariSoyad.Text;
			t.TELEFON = textCariTelefon.Text;
			t.MAIL = textCariMail.Text;
			t.IL = textCariil.Text;
			t.ILCE = textCariilce.Text;
			t.BANKA = textCariBanka.Text;
			t.VERGIDAIRESI = textCariVergiD.Text;
			t.VERGINO = textCariVergiN.Text;
			t.STATU = textCariStatu.Text;
			t.ADRES = textCariAdres.Text;
			db.TblCARI.Add(t);
			db.SaveChanges();
			MessageBox.Show("Yeni Cari Sisteme Başarıyla Eklendi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
