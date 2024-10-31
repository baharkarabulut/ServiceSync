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
	public partial class Frmİstatistik : Form
	{
		public Frmİstatistik()
		{
			InitializeComponent();
		}
		DbServicesEntities db = new DbServicesEntities();
		private void Frmİstatistik_Load(object sender, EventArgs e)
		{
			labelControl2.Text = db.TblURUN.Count().ToString();
			labelControl3.Text = db.TblKATEGORI.Count().ToString();
			labelControl5.Text = "10";
			labelControl7.Text = db.TblURUN.Sum(x=> x.STOK).ToString();
			labelControl19.Text = (from x in db.TblURUN
								   orderby x.STOK descending
								   select x.AD).FirstOrDefault();
			labelControl17.Text = (from x in db.TblURUN
								   orderby x.STOK ascending
								   select x.AD).FirstOrDefault();
			labelControl13.Text = (from x in db.TblURUN
								   orderby x.SATISFIYATI descending
								   select x.AD ).FirstOrDefault();
			labelControl11.Text = (from x in db.TblURUN
								   orderby x.SATISFIYATI ascending
								   select x.AD).FirstOrDefault();
			labelControl25.Text = db.TblURUN.Count( x=> x.KATEGORİ ==4).ToString();
			labelControl23.Text = db.TblURUN.Count(x => x.KATEGORİ == 1).ToString();
			labelControl21.Text = db.TblURUN.Count(x => x.KATEGORİ == 3).ToString();
			labelControl39.Text = ( from x in db.TblURUN
									select x.MARKA).Distinct().Count().ToString();
		}

		private void labelControl2_Click(object sender, EventArgs e)
		{

		}
	}
}
