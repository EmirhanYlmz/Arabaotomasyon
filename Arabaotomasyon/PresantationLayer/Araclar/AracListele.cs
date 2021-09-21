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

namespace Arabaotomasyon.PresantationLayer.Araclar
{
    public partial class AracListele : Form
    {

        public SqlCommand sorgu;
        public AracListele()
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

        public string secim_arac;
        public string secim_marka;
        public string secim_model;
        public string secim_yıl;
        public string secim_plaka;

        private void Vtlistele_Click(object sender, EventArgs e)
        {
            if (tümliste.Checked == true)
            {
                VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
                sorgu = new SqlCommand("Select*from arac", yenivtbaglanti.baglanti);

                listeleme();
            }
            if (secililiste.Checked == true)
            {
                if (aracid.Checked == true) { secim_arac = "aracid,"; } else { secim_arac = ""; }
                if (marka.Checked == true) { secim_marka = "marka,"; } else { secim_marka = ""; }
                if (model.Checked == true) { secim_model = "model,"; } else { secim_model = ""; }
                if (Yil.Checked == true) { secim_yıl = "yıl,"; } else { secim_yıl = ""; }
                if (plaka.Checked == true) { secim_plaka = "plaka"; } else { secim_plaka = ""; }


                VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
                sorgu = new SqlCommand("Select " + secim_arac + secim_marka + secim_model + secim_yıl + secim_plaka + " from arac",
                    yenivtbaglanti.baglanti);
                listeleme();

            }
        }

        private void Anamenudon_Click(object sender, EventArgs e)
        {
            Anamenu anaMenü = new Anamenu();
            anaMenü.Show();
            Hide();
        }

        private void tümliste_CheckedChanged(object sender, EventArgs e)
        {
            aracid.Enabled = false;
            marka.Enabled = false;
            model.Enabled = false;
            Yil.Enabled = false;
            plaka.Enabled = false;
        }

        private void secililiste_CheckedChanged(object sender, EventArgs e)
        {
            aracid.Enabled = true;
            marka.Enabled = true;
            model.Enabled = true;
            Yil.Enabled = true;
            plaka.Enabled = true;
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
            sorgu = new SqlCommand("Select*from arac", yenivtbaglanti.baglanti);

            listeleme();


            aracid.Enabled = false;
            marka.Enabled = false;
            model.Enabled = false;
            Yil.Enabled = false;
            plaka.Enabled = false;
        }
    
    }
}
