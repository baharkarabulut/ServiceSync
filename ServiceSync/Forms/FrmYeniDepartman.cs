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
	public partial class FrmYeniDepartman : Form
	{
		public FrmYeniDepartman()
		{
			InitializeComponent();
		}

		private void FrmYeniDepartman_Load(object sender, EventArgs e)
		{

		}
		DbServicesEntities db = new DbServicesEntities();
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			TblDEPARTMAN t = new TblDEPARTMAN();
			if (textDepartmanAd.Text.Length <= 50 && textDepartmanAd.Text != "")
			{
				t.AD = textDepartmanAd.Text;
				db.TblDEPARTMAN.Add(t);
				db.SaveChanges();
				MessageBox.Show("Departman kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Kayıt yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
