using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDrawingVector
{
    public class Figure
    {
        public Figure()
        {

        }

        public Figure(int x, int y, int x2, int y2, int w, Color col, int type)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
            this.w = w;            
            this.col = col;
            this.type = type;
        }

        public int x;
        public int y;
        public int x2;
        public int y2;
        public int w;
        public Color col;
        public int type;
    }
}
