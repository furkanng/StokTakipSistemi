using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class formHammadde : Form
    {
        public formHammadde()
        {
            InitializeComponent();
        }

        private void btnAlüminyum_Click(object sender, EventArgs e)
        {
            FormAlüminyum frmAlimnym = new FormAlüminyum();
            frmAlimnym.Show();
        }
    }
}
