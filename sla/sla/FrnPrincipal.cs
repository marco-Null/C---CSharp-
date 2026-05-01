using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sla
{
    public partial class FrnPrincipal : Form
    {
        public FrnPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stlDATA.Text = DateTime.Now.ToString("dd/MM/yyyy");
            stlHORA.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrnUsuario fuUsuario = new FrnUsuario();

            fuUsuario.Show();
        }
    }
}
