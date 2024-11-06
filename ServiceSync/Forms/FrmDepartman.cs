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
							  u.AD
						  };
			gridControl1.DataSource = departman.ToList();
			labelControl18.Text = db.TblDEPARTMAN.Count().ToString();
			labelControl12.Text = db.TblPERSONEL.Count().ToString();
		}

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

		private void BtnSil_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textID.Text);
			var departman = db.TblDEPARTMAN.Find(id);
			db.TblDEPARTMAN.Remove(departman);
			db.SaveChanges();
			MessageBox.Show("Departman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			int id = int.Parse(textID.Text);
			var departman = db.TblDEPARTMAN.Find(id);
			departman.AD = textDepartmanAd.Text;
			db.SaveChanges();
			MessageBox.Show("Departman başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void BtnListele_Click(object sender, EventArgs e)
		{
			var departman = from u in db.TblDEPARTMAN
							select new
							{
								u.ID,
								u.AD
							};
			gridControl1.DataSource = departman.ToList();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			textDepartmanAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
		}
	}
}
