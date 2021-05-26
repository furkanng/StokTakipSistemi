using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipSistemi
{
    public partial class FormAlüminyum : Form
    {
        public FormAlüminyum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BGJRLTE\\SQLEXPRESS;Initial Catalog=StokTakipSistemi;Integrated Security=True");

        private void verilerigörüntüle()
        {
            lstviewAlümin.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *From alüminyumstok", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["alüminyumadi"].ToString();
                ekle.SubItems.Add(oku["alüminyumcap"].ToString());
                ekle.SubItems.Add(oku["alüminyumkalinlik"].ToString());
                ekle.SubItems.Add(oku["alüminyumagirlik"].ToString());
                ekle.SubItems.Add(oku["alüminyumstok"].ToString());

                lstviewAlümin.Items.Add(ekle);
            }
            baglanti.Close();
        }


        private void FormAlüminyum_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=DESKTOP-BGJRLTE\\SQLEXPRESS;Initial Catalog=StokTakipSistemi;Integrated Security=SSPI";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM alüminyumstok";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboxalümin.Items.Add(dr["alüminyumadi"]);
            }
            baglanti.Close();

        }

        private void btnAlmListele_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
