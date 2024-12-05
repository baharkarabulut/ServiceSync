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

		private void BtnKategoriListe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmKategori fr = new Forms.FrmKategori();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmYeniKategori fr = new Forms.FrmYeniKategori();
			fr.Show();
		}

		private void Btnistatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.Frmİstatistik fr = new Forms.Frmİstatistik();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnMarkaist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmMarkalar fr = new Forms.FrmMarkalar();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmCariListesi fr = new Forms.FrmCariListesi();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnCariiller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmCariiller fr = new Forms.FrmCariiller();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmCariEkle fr = new Forms.FrmCariEkle();
			fr.Show();
		}

		private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmDepartman fr = new Forms.FrmDepartman();
			fr.MdiParent = this;
			fr.Show();
		}

		private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmYeniDepartman fr = new Forms.FrmYeniDepartman();

			fr.Show();
		}

		private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Forms.FrmPersonel fr = new Forms.FrmPersonel();
			fr.MdiParent = this;
			fr.Show();
		}
	}
}
