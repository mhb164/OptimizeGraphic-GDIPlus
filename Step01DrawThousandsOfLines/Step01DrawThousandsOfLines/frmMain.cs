using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Step01DrawThousandsOfLines
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBenchmark_Click(object sender, EventArgs e)        {            Benchmark((int)numCount.Value);        }



        private void Benchmark(int count)
        {
            List<Point> points = new List<Point>();

            //create random points...
            Random random = new Random(DateTime.Now.Millisecond);
            count *= 2;
            int XMAX = cnvsCommon.Width;
            int YMAX = cnvsCommon.Height;
            for (int i = 0; i < count; i++) points.Add(new Point(random.Next(5, XMAX), random.Next(5, YMAX)));

            cnvsCommon.Show(points,false);
            cnvsOptimized.Show(points,true);
        }

    }
}
