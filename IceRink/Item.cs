using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceRink
{
    internal class Item
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public int Size { get; set; }
        public int Step { get; set; }

        public Item(int x, int y, Color color, int size, int step)
        {
            X = x;
            Y = y;
            Color = color;
            Size = size;
            Step = step;
        }

        public virtual void Draw(Graphics g)
        {

        }
    }
}
