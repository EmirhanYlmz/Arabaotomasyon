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
using Arabaotomasyon.DbConnection;
using Arabaotomasyon.PresantationLayer;

namespace Arabaotomasyon.PresantationLayer.Kullanıcılar
{

    public partial class KullanıcıListele : Form
    {
        public SqlCommand sorgu;
        public KullanıcıListele()
        {
            InitializeComponent();
        }

        public void listeleme()
        {        
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;
        }

        public string secim_kullanici;
        public string secim_isim;
        public string secim_sifre;

        private void Vtlistele_Click(object sender, EventArgs e)
        {
            if(tümliste.Checked == true)
            {
                VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
                sorgu = new SqlCommand("Select*from kullanıcılar", yenivtbaglanti.baglanti);

                listeleme();
            }

            if (secililiste.Checked == true)
            {
                if (kullaniciid.Checked == true) { secim_kullanici = "kullanici,"; } else { secim_kullanici = ""; }
                if (isim.Checked == true) { secim_isim = "isim,"; } else { secim_isim = ""; }
                if (sifre.Checked == true) { secim_sifre = "sifre"; } else { secim_sifre = ""; }


                VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
                sorgu = new SqlCommand("Select " + secim_kullanici + secim_isim + secim_sifre + " from kullanıcılar",
                    yenivtbaglanti.baglanti);
                listeleme();

            }


        }

        private void KullanıcıListele_Load(object sender, EventArgs e)
        {
            VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
            sorgu = new SqlCommand("Select*from kullanıcılar", yenivtbaglanti.baglanti);

            listeleme();

            
            kullaniciid.Enabled = false;
            isim.Enabled = false;
            sifre.Enabled = false;
        }

        private void Anamenudon_Click(object sender, EventArgs e)
        {
            Anamenu anaMenü = new Anamenu();
            anaMenü.Show();
            Hide();
        }

        private void tümliste_CheckedChanged(object sender, EventArgs e)
        {
            kullaniciid.Enabled = false;
            isim.Enabled = false;
            sifre.Enabled = false;
        }

        private void secililiste_CheckedChanged(object sender, EventArgs e)
        {
            kullaniciid.Enabled = true;
            isim.Enabled = true;
            sifre.Enabled = true;
        }
    }
}
