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
	public partial class FrmPersonel : Form
	{
		public FrmPersonel()
		{
			InitializeComponent();
		}

		DbServicesEntities db = new DbServicesEntities();
		private void groupControl1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FrmPersonel_Load(object sender, EventArgs e)
		{
			var personel = from u in db.TblPERSONEL
							select new
							{
								u.ID,
								u.AD,
								u.SOYAD,
								u.MAIL,
								u.TELEFON,
								u.FOTOGRAF
							};
			gridControl1.DataSource = personel.ToList();

			lookUpEdit1.Properties.DataSource = (from x in db.TblDEPARTMAN
												select new
												{
													x.ID,
													x.AD
												}).ToList();

			labelControl8.Text = db.TblPERSONEL.First(x => x.ID == 1).AD;
			labelControl9.Text = db.TblPERSONEL.First(x => x.ID == 1).SOYAD;
			labelControl10.Text = db.TblPERSONEL.First(x => x.ID == 1).TblDEPARTMAN.AD;
			labelControl11.Text = db.TblPERSONEL.First(x => x.ID == 1).MAIL;

			labelControl12.Text = db.TblPERSONEL.First(x => x.ID == 2).AD;
			labelControl13.Text = db.TblPERSONEL.First(x => x.ID == 2).SOYAD;
			labelControl14.Text = db.TblPERSONEL.First(x => x.ID == 2).TblDEPARTMAN.AD;
			labelControl15.Text = db.TblPERSONEL.First(x => x.ID == 2).MAIL;

			labelControl16.Text = db.TblPERSONEL.First(x => x.ID == 3).AD;
			labelControl17.Text = db.TblPERSONEL.First(x => x.ID == 3).SOYAD;
			labelControl18.Text = db.TblPERSONEL.First(x => x.ID == 3).TblDEPARTMAN.AD;
			labelControl19.Text = db.TblPERSONEL.First(x => x.ID == 3).MAIL;

			labelControl20.Text = db.TblPERSONEL.First(x => x.ID == 4).AD;
			labelControl21.Text = db.TblPERSONEL.First(x => x.ID == 4).SOYAD;
			labelControl22.Text = db.TblPERSONEL.First(x => x.ID == 4).TblDEPARTMAN.AD;
			labelControl23.Text = db.TblPERSONEL.First(x => x.ID == 4).MAIL;
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
			textPersonelAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
			textPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
			textPersonelMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
			textPersonelTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
			textPersonelFotograf.Text = gridView1.GetFocusedRowCellValue("FOTOGRAF").ToString();
		}
	}
}
