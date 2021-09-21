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

namespace Arabaotomasyon.PresantationLayer.Kiralama
{
    public partial class KiralamaListele : Form
    {
        public SqlCommand sorgu;
        public KiralamaListele()
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
       
        public string secim_musteri;
        public string secim_isim;
        public string secim_soyisim;
        public string secim_telefon;
        public string secim_alınantarih;
        public string secim_teslimtarih;
        public string secim_fiyat;

        private void Vtlistele_Click(object sender, EventArgs e)
        {
            if (tümliste.Checked == true)
            {
                VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
                sorgu = new SqlCommand("Select*from kiralama", yenivtbaglanti.baglanti);

                listeleme();
            }
            if (secililiste.Checked == true)
            {
                if (musteriid.Checked == true) { secim_musteri = "musteriid,"; } else { secim_musteri = ""; }
                if (isim.Checked == true) { secim_isim = "isim,"; } else { secim_isim = ""; }
                if (soyisim.Checked == true) { secim_soyisim = "soyisim,"; } else { secim_soyisim = ""; }
                if (telefon.Checked == true) { secim_telefon = "telefon,"; } else { secim_telefon = ""; }
                if (alınantarih.Checked == true) { secim_alınantarih = "alınantarih,"; } else { secim_alınantarih = ""; }
                if (teslimtarih.Checked == true) { secim_teslimtarih = "teslimtarih,"; } else { secim_teslimtarih = ""; }
                if (fiyat.Checked == true) { secim_fiyat = "fiyat"; } else { secim_fiyat = ""; }


                VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
                sorgu = new SqlCommand("Select " + secim_musteri + secim_isim + secim_soyisim + secim_telefon + secim_alınantarih + secim_teslimtarih + secim_fiyat + " from kiralama",
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
            musteriid.Enabled = false;
            isim.Enabled = false;
            soyisim.Enabled = false;
            telefon.Enabled = false;
            teslimtarih.Enabled = false;
            alınantarih.Enabled = false;
            fiyat.Enabled = false;
        }

        private void secililiste_CheckedChanged(object sender, EventArgs e)
        {
            musteriid.Enabled = true;
            isim.Enabled = true;
            soyisim.Enabled = true;
            telefon.Enabled = true;
            teslimtarih.Enabled = true;
            alınantarih.Enabled = true;
            fiyat.Enabled = true;
        }

        private void KiralamaListele_Load(object sender, EventArgs e)
        {
            VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
            sorgu = new SqlCommand("Select*from kiralama", yenivtbaglanti.baglanti);
            
            musteriid.Enabled = false;
            isim.Enabled = false;
            soyisim.Enabled = false;
            telefon.Enabled = false;
            teslimtarih.Enabled = false;
            alınantarih.Enabled = false;
            fiyat.Enabled = false;
        }
    }
}
