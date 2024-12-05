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
			chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
			chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 3);
			chartControl1.Series["Series 1"].Points.AddPoint("Lg", 2);
			chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Samsung", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Casper", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Asus", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Fury", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Hd", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Huawei", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Kingston", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Logitech", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Monster", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Msi", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Trust", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Philips", 1);
			chartControl1.Series["Series 1"].Points.AddPoint("Snoopy", 1);

			chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 6);
			chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 5);
			chartControl2.Series["Kategoriler"].Points.AddPoint("Televizyon", 1);
			chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aleti", 3);
			chartControl2.Series["Kategoriler"].Points.AddPoint("Tablet", 1);
			chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar Parçaları", 5);
			chartControl2.Series["Kategoriler"].Points.AddPoint("Kulaklık", 3);
			chartControl2.Series["Kategoriler"].Points.AddPoint("Çantalar", 1);
		}

		private void labelControl10_Click(object sender, EventArgs e)
		{

		}

		private void pictureEdit5_EditValueChanged(object sender, EventArgs e)
		{

		}
	}
}
