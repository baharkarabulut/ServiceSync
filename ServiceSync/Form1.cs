using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceSync
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ribbonControl1_Click(object sender, EventArgs e)
		{

		}

		private void BtnProductListForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmUrunListesi fr = new Forms.FrmUrunListesi();
			fr.MdiParent = this;
			fr.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmYeniUrun fr = new Forms.FrmYeniUrun();
			fr.Show();
		}
	}
}
