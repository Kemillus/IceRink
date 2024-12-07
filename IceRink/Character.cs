using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceRink
{
    internal class Character : Item
    {
        private Image image;
        public Character(int x, int y, Color color, int size, int step, Image image) : base(x, y, color, size, step)
        {
            this.image = image;
        }
    }
}
