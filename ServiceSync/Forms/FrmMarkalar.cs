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
	public partial class FrmMarkalar : Form
	{
		public FrmMarkalar()
		{
			InitializeComponent();
		}
		DbServicesEntities db = new DbServicesEntities();
		private void FrmMarkalar_Load(object sender, EventArgs e)
		{
			var degerler = db.TblURUN.OrderBy(x=>x.MARKA).GroupBy(y=>y.MARKA).
				Select(z=>new
			{
				Marka = z.Key,
				Toplam = z.Count()
			});
			gridControl1.DataSource = degerler.ToList();
			labelControl2.Text = db.TblURUN.Count().ToString();
			labelControl3.Text = (from x in db.TblURUN
								   select x.MARKA).Distinct().Count().ToString();
			labelControl7.Text = (from x in db.TblURUN
								   orderby x.SATISFIYATI descending
								   select x.MARKA).FirstOrDefault();

		}

		private void labelControl10_Click(object sender, EventArgs e)
		{

		}
	}
}
