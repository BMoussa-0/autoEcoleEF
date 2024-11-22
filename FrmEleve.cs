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
    public partial class FrmEleve : Form
    {
        private autoecoleEntities mesDonneesEF;

        public FrmEleve(autoecoleEntities mesDonneesEF)
        {   
            InitializeComponent();
            for (int i = 0; i < 30; i++) 
                this.cmbCredit.Items.Add(i);
        }

        private void FrmEleve_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
