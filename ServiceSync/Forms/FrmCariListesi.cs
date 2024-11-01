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
	public partial class FrmCariListesi : Form
	{
		public FrmCariListesi()
		{
			InitializeComponent();
		}
		DbServicesEntities db = new DbServicesEntities();

		private void FrmCariListesi_Load(object sender, EventArgs e)
		{
			gridControl1.DataSource = db.TblCARI.ToList();
		}
	}
}
