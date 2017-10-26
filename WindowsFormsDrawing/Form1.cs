using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDrawing
{
    public partial class Drawing : Form
    {
        bool draw = false;

        int pX = 0;
        int pY = 0;

        string color = "";
        string size  = "";

        Bitmap drawing;

        public Drawing()
        {
            InitializeComponent();

            drawing = new Bitmap(DrawingPanel.Width, DrawingPanel.Height, DrawingPanel.CreateGraphics());
            Graphics.FromImage(drawing).Clear(Color.White);
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if (color == "black" && size == "small")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Black, 1);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }

                if (color == "blue" && size == "small")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Blue, 1);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }

                if (color == "red" && size == "small")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Red, 1);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }

                if (color == "black" && size == "medium")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Black, 5);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }

                if (color == "blue" && size == "medium")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Blue, 5);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }

                if (color == "red" && size == "medium")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Red, 5);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }

                if (color == "black" && size == "large")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Black, 9);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }

                if (color == "blue" && size == "large")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Blue, 9);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }

                if (color == "red" && size == "large")
                {
                    Graphics panel = Graphics.FromImage(drawing);

                    Pen pen = new Pen(Color.Red, 9);

                    panel.DrawLine(pen, pX, pY, e.X, e.Y);

                    DrawingPanel.CreateGraphics().DrawImageUnscaled(drawing, new Point(0, 0));
                }
            }

            pX = e.X;
            pY = e.Y;
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;

            pX = e.X;
            pY = e.Y;
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(drawing, new Point(0, 0));
        }

        private void toolStripMenuColorBlack_Click(object sender, EventArgs e)
        {
            toolStripMenuColorBlack.Checked = true;
            toolStripMenuColorBlue.Checked = false;
            toolStripMenuColorRed.Checked = false;
            color = "black";
        }

        private void toolStripMenuColorBlue_Click(object sender, EventArgs e)
        {
            toolStripMenuColorBlack.Checked = false;
            toolStripMenuColorBlue.Checked = true;
            toolStripMenuColorRed.Checked = false;
            color = "blue";
        }

        private void toolStripMenuRed_Click(object sender, EventArgs e)
        {
            toolStripMenuColorBlack.Checked = false;
            toolStripMenuColorBlue.Checked = false;
            toolStripMenuColorRed.Checked = true;
            color = "red";
        }

        private void toolStripMenuSizeSmall_Click(object sender, EventArgs e)
        {
            toolStripMenuSizeSmall.Checked = true;
            toolStripMenuSizeMedium.Checked = false;
            toolStripMenuSizeLarge.Checked = false;
            size = "small";
        }

        private void toolStripMenuSizeMedium_Click(object sender, EventArgs e)
        {
            toolStripMenuSizeSmall.Checked = false;
            toolStripMenuSizeMedium.Checked = true;
            toolStripMenuSizeLarge.Checked = false;
            size = "medium";
        }

        private void toolStripMenuSizeLarge_Click(object sender, EventArgs e)
        {
            toolStripMenuSizeSmall.Checked = false;
            toolStripMenuSizeMedium.Checked = false;
            toolStripMenuSizeLarge.Checked = true;
            size = "large";
        }
    }
}
