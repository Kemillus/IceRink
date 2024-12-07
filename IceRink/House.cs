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
        public House(int x, int y, Color color, int size, int stages, int step) : base(x, y, color, size, step)
        {
            Stages = stages;
        }
    }
}
