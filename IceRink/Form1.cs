using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceRink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(700, 700);
            this.Paint += new PaintEventHandler(this.OnPaint);
        }
        private void OnPaint (object sender, PaintEventArgs e)
        {

        }
    }
}
