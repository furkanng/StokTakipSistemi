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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnaCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Formun büyümesini engelliyor.

        }

        private void btnTencereUretim_Click(object sender, EventArgs e)
        {
            FormTencereUretim frmTenUret = new FormTencereUretim();
            frmTenUret.Show();
            
        }

        private void btnHamMadde_Click(object sender, EventArgs e)
        {
            formHammadde frmHamMad = new formHammadde();
            frmHamMad.Show();
        }
    }
}
