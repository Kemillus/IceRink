using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceRink
{
    internal class Snowflake : Item
    {
        public Snowflake(int x, int y, Color color, int size, int step) 
            : base(x, y, color, size, step)
        {

        }

        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), X, Y, Size, Size);
        }
    }
}
