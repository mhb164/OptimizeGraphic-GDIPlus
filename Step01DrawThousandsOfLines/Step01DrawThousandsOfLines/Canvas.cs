using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace Step01DrawThousandsOfLines
{
    public partial class Canvas : UserControl
    {
        public Canvas()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.Selectable, true);
        }

        List<Point> Points = new List<Point>();
        bool Optimized = false;
        internal void Show(List<Point> points, bool optimized)
        {
            Points = points;
            Optimized = optimized;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.Graphics.TextContrast = 8;

            Stopwatch stopwatch = Stopwatch.StartNew();
            using (Pen pen = new Pen(Color.Green) { Width = 1.5f })
            {
                if (Optimized)
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        for (int i = 0; i < Points.Count - 1; i++)
                            path.AddLine(Points[i], Points[i + 1]);
                        e.Graphics.DrawPath(pen, path);
                    }
                }
                else//Common
                {
                    for (int i = 0; i < Points.Count - 1; i++)
                        e.Graphics.DrawLine(pen, Points[i], Points[i + 1]);
                }
            }
            stopwatch.Stop();

            StringBuilder result = new StringBuilder();
            result.AppendFormat("Benchmark for {0} lines:\r\n", Points.Count / 2);
            if (Optimized)                result.AppendFormat("Optimized: {0}\r\n", stopwatch.Elapsed);
            else result.AppendFormat("   Common: {0}\r\n", stopwatch.Elapsed);

            e.Graphics.DrawString(result.ToString(), Font, Brushes.Red, 10, 10);

        }
    }
}
