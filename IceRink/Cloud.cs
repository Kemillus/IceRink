using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceRink
{
    internal class Cloud : Item
    {
        public Cloud(int x, int y, Color color, int size, int step) 
            : base(x, y, color, size, step)
        {

        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);

            g.FillRectangle(brush, X + 0.2f * Size, 
                Y + 0.3f * Size,0.65f * Size, 0.3f * Size);

            g.FillEllipse(brush, X + 0.2f * Size - 0.2f * Size,
                Y + 0.4f * Size - 0.2f * Size, 0.4f * Size, 0.4f * Size);

            g.FillEllipse(brush, X + 0.4f * Size - 0.25f * Size,
                Y + 0.25f * Size - 0.25f * Size,0.5f * Size, 0.5f * Size);

            g.FillEllipse(brush, X + 0.65f * Size - 0.2f * Size,
                Y + 0.3f * Size - 0.2f * Size,0.4f * Size, 0.4f * Size);

            g.FillEllipse(brush,X + 0.85f * Size - 0.15f * Size, 
                Y + 0.45f * Size - 0.15f * Size,0.3f * Size, 0.3f * Size);
        }
    }
}
