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
	public partial class FrmYeniKategori : Form
	{
		DbServicesEntities db = new DbServicesEntities();
		public FrmYeniKategori()
		{
			InitializeComponent();
		}

		private void FrmYeniKategori_Load(object sender, EventArgs e)
		{

		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			TblKATEGORI t = new TblKATEGORI();
			t.AD = txtKategoriAd.Text;
			db.TblKATEGORI.Add(t);
			db.SaveChanges();
			MessageBox.Show("Kategori başarıyla kaydedildi.");
		}
	}
}
