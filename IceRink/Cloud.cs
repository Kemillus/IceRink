﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceRink
{
    internal class Cloud : Item
    {
        public int Step { get; set; }
        public Cloud(int x, int y, Color color, int size, int step) : base(x, y, color, size, step)
        {
            Step = step;
        }
    }
}