using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmMenu : Form
    {
        private autoecoleEntities mesDonneesEF;
        public FrmMenu()
        {
            InitializeComponent();
            this.mesDonneesEF = new autoecoleEntities();
        }

        private void valierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEleve f = new FrmEleve(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }
    }
}
