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

namespace Arabaotomasyon.PresantationLayer.Hasarlı
{
    public partial class HasarlıListele : Form
    {
        public SqlCommand sorgu;
        public HasarlıListele()
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

        public string secim_hasarli;
        public string secim_marka;
        public string secim_model;
        public string secim_yıl;
        public string secim_hasartipi;

        private void Vtlistele_Click(object sender, EventArgs e)
        {
            if (tümliste.Checked == true)
            {
                VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
                sorgu = new SqlCommand("Select*from hasarlı", yenivtbaglanti.baglanti);

                listeleme();
            }
            if (secililiste.Checked == true)
            {
                if (hasarliid.Checked == true) { secim_hasarli = "hasarliid,"; } else { secim_hasarli = ""; }
                if (marka.Checked == true) { secim_marka = "marka,"; } else { secim_marka = ""; }
                if (model.Checked == true) { secim_model = "model,"; } else { secim_model = ""; }
                if (Yil.Checked == true) { secim_yıl = "yıl,"; } else { secim_yıl = ""; }
                if (hasartipi.Checked == true) { secim_hasartipi = "hasartipi"; } else { secim_hasartipi = ""; }


                VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
                sorgu = new SqlCommand("Select " + secim_hasarli + secim_marka + secim_model + secim_yıl + secim_hasartipi + " from hasarlı",
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
            hasarliid.Enabled = false;
            marka.Enabled = false;
            model.Enabled = false;
            Yil.Enabled = false;
            hasartipi.Enabled = false;
        }

        private void secililiste_CheckedChanged(object sender, EventArgs e)
        {
            hasarliid.Enabled = true;
            marka.Enabled = true;
            model.Enabled = true;
            Yil.Enabled = true;
            hasartipi.Enabled = true;
        }

        private void HasarlıListele_Load(object sender, EventArgs e)
        {
            VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
            sorgu = new SqlCommand("Select*from hasarlı", yenivtbaglanti.baglanti);
            
            listeleme();

            hasarliid.Enabled = false;
            marka.Enabled = false;
            model.Enabled = false;
            Yil.Enabled = false;
            hasartipi.Enabled = false;
        }
    }
}
