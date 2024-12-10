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
        public Rink(int x, int y, Color color, int size, int step) : base(x, y, color, size, step)
        {

        }
        public override void Draw(Graphics g)
        {
            int roadTop = Y; // Using Y property of the Item class for flexibility

            // Road surface (light brown)
            //using (SolidBrush brush = new SolidBrush(Color.FromArgb(250, 220, 180)))
            //{
            //    g.FillRectangle(brush, X, roadTop, Size, 500 - roadTop);
            //}

            // Asphalt (dark gray) - calculate position relative to roadTop
            int asphaltTop = roadTop + 75;  // Example offset
            int asphaltHeight = 250; // Example height
            using (SolidBrush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, asphaltTop, Size, asphaltHeight);
            }


            // Center line (yellow)
            //int centerLineTop = asphaltTop + (asphaltHeight / 2) - 5; // Calculate center based on asphalt
            //using (SolidBrush brush = new SolidBrush(Color.FromArgb(250, 210, 0)))
            //{
            //    g.FillRectangle(brush, X, centerLineTop, Size, 10);
            //}

            // Roadside markings (loop) - adjust positions relative to other elements
            //using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 180, 180)))
            //{
            //    for (int xOffset = 50; xOffset < Size; xOffset += 100)
            //    {
            //        g.FillRectangle(brush, X + xOffset - 10, centerLineTop + 100, 10, 35); //Example offset
            //        g.FillRectangle(brush, X + xOffset, roadTop + 45, 10, 25); //Example offset from road top


            //    }
            //}



            // Lane separator lines (Brighter, then darker gray) - Adjust for better visibility
            //using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 200, 200)))
            //{
            //    g.FillRectangle(brush, X, centerLineTop + 95, Size, 5);
            //    g.FillRectangle(brush, X, roadTop + 40, Size, 5);  // Example offset from roadTop
            //}

            //using (SolidBrush brush = new SolidBrush(Color.FromArgb(220, 220, 220)))
            //{

            //    g.FillRectangle(brush, X, centerLineTop + 90, Size, 5);
            //    g.FillRectangle(brush, X, roadTop + 35, Size, 5); //Example offset from roadTop

            //}
        }
    }
}
