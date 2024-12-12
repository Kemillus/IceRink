using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceRink
{
    internal class House : Item
    {
        private int Stages { get; set; }
        public House(int x, int y, Color color,
            int size, int stages, int step)
            : base(x, y, color, size, step)
        {
            Stages = stages;
        }

        public override void Draw(Graphics g)
        {
            SolidBrush baseBrush = new SolidBrush(Color);

            g.FillRectangle(baseBrush,
                X - 0.45f * Size, Y - (0.2f * Stages + 0.3f) * Size,
                0.9f * Size, (0.2f * Stages + 0.3f) * Size);

            for (int i = 0; i < Stages; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PointF[] points = new PointF[3];

                    points[0] = new PointF(X - (0.25f - 0.2f * j) *
                        Size, Y - (0.4f + 0.2f * i) * Size);
                    points[1] = new PointF(X - (0.35f - 0.2f * j) * 
                        Size, Y - (0.3f + 0.2f * i) * Size);

                    SolidBrush lightRoofBrush = new SolidBrush
                        (Color.FromArgb(110, 210, 250));

                    points[2] = new PointF(X - (0.35f - 0.2f * j) *
                        Size, Y - (0.4f + 0.2f * i) * Size);
                    g.FillPolygon(lightRoofBrush, points);

                    SolidBrush darkRoofBrush = new SolidBrush
                        (Color.FromArgb(0, 150, 200));

                    points[2] = new PointF(X - (0.25f - 0.2f * j) *
                        Size, Y - (0.3f + 0.2f * i) * Size);
                    g.FillPolygon(darkRoofBrush, points);
                }
            }
        }

    }
}
