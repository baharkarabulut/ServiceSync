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
	public partial class FrmDepartman : Form
	{
		public FrmDepartman()
		{
			InitializeComponent();
		}
		DbServicesEntities db = new DbServicesEntities();
		private void FrmDepartman_Load(object sender, EventArgs e)
		{
			var departman = from u in db.TblDEPARTMAN
						  select new
						  {
							  u.ID,
							  u.AD,
							  u.ACIKLAMA
						  };
			gridControl1.DataSource = departman.ToList();
			labelControl18.Text = db.TblDEPARTMAN.Count().ToString();
			labelControl12.Text = db.TblPERSONEL.Count().ToString();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			TblDEPARTMAN t = new TblDEPARTMAN();

			if (textDepartmanAd.Text.Length <= 50 && textDepartmanAd.Text != "" && TextBoxDepartmanAciklama.Text.Length >= 1)
			{
				t.AD = textDepartmanAd.Text;
				t.ACIKLAMA = TextBoxDepartmanAciklama.Text;
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
