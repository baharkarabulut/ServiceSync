using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ServiceSync.Forms
{
	public partial class FrmCariiller : Form 
	{
		DbServicesEntities db = new DbServicesEntities();
		public FrmCariiller()
		{
			InitializeComponent();
		}
		SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NJP4QFR\SQLEXPRESS;Initial Catalog=DbServices;Integrated Security=True;Encrypt=False");
		private void FrmCariiller_Load(object sender, EventArgs e)
		{
			// chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
			// chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 12);
			// chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 8);
			// chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 14);
			// chartControl1.Series["Series 1"].Points.AddPoint("Antalya", 17);
			// chartControl1.Series["Series 1"].Points.AddPoint("Mersin", 11);
			// chartControl1.Series["Series 1"].Points.AddPoint("Adana", 4);

			gridControl1.DataSource= db.TblCARI.OrderBy(x => x.IL).
				GroupBy(y => y.IL).
				Select(z => new {İL = z.Key, TOPLAM = z.Count() }).ToList();

			baglanti.Open();
			SqlCommand komut = new SqlCommand("select IL, COUNT(*) fROM TblCARI group by Il",baglanti);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
			}
			baglanti.Close();
		}
	}
}
