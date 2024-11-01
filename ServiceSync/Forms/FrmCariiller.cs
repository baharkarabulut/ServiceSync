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
	public partial class FrmCariiller : Form
	{
		public FrmCariiller()
		{
			InitializeComponent();
		}

		private void FrmCariiller_Load(object sender, EventArgs e)
		{
			chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
			chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 12);
			chartControl1.Series["Series 1"].Points.AddPoint("Bursa", 8);
			chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 14);
			chartControl1.Series["Series 1"].Points.AddPoint("Antalya", 17);
			chartControl1.Series["Series 1"].Points.AddPoint("Mersin", 11);
			chartControl1.Series["Series 1"].Points.AddPoint("Adana", 4);
		}
	}
}
