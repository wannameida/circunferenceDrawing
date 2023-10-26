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
        int x = 0, y = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não implementado", "Alerta do Sistema");
            //System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtXCenter_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConcluido_Click(object sender, EventArgs e)
        {
            grpCentro.Enabled = false;
        }

        private void btnConPo_Click(object sender, EventArgs e)
        {
            grpPoint.Enabled = false;
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            DrawScreen drawScreen = new DrawScreen();
            drawScreen.Show();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grpCentro.Enabled = true;
            grpPoint.Enabled = true;
        }

    }
}
