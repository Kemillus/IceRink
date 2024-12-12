using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceRink
{
    internal class Rink : Item
    {
        public Rink(int x, int y, Color color, int size, int step) 
            : base(x, y, color, size, step)
        {

        }

        public override void Draw(Graphics g)
        {
            int roadTop = Y;
            int asphaltTop = roadTop + 75;
            int asphaltHeight = 250;

            SolidBrush brush = new SolidBrush(Color);
            g.FillRectangle(brush, X, asphaltTop, Size, asphaltHeight);
        }
    }
}
