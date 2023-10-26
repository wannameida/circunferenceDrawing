using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circunferenceDraw
{
    public partial class DrawScreen : Form
    {
        public DrawScreen()
        {
            InitializeComponent();
        }

        private void DrawScreen_Load(object sender, EventArgs e)
        {
         
        }

        private void DrawScreen_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawEllipse(pen, 500, 500, 100, 100);
        }
    }
}
