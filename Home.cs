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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado", "Alerta do Sistema");
            //System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DrawScreen drawScreen = new DrawScreen();
            drawScreen.Show();

        }
    }
}
