using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDrawingClasses
{
    public partial class pDraw1 : PictureBox
    {
        int x = 0;
        int y = 0;
        public XData data = null;

        public pDraw1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.DrawImage(data.img, 0, 0);
        }

        private void pBox_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage (data.img);
                Pen pen = new Pen(data.col, data.width);
                g.DrawLine(pen, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
                Invalidate();
            }
        }
    }
}
