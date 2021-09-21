using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arabaotomasyon.PocosLayer;
using Arabaotomasyon.BussinesLogicLayer;
using Arabaotomasyon.DbConnection;
using System.Data.SqlClient;

namespace Arabaotomasyon.PresantationLayer.Kullanıcılar
{
    public partial class KullanıcıGuncelle : Form
    {
        private KullanicilarBLL kullanicilarBLL;
        public KullanıcıGuncelle()
        {
            InitializeComponent();
            kullanicilarBLL = new KullanicilarBLL();
        }
        public void listele()
        {
            VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
            SqlCommand sorgu = new SqlCommand("Select*from kullanıcılar", yenivtbaglanti.baglanti);

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;

        }

        private void Vtguncelle_Click(object sender, EventArgs e)
        {
            KullanicilarPoco kullanicilar = new KullanicilarPoco();
            kullanicilar = kullanicilarBLL.updatekullanıcı(Kullaniciid.Text, isim.Text, sifre.Text);
            
            MessageBox.Show("Güncelleme işlemi başarılı.");
            listele();
        }

        private void Anamenudon_Click(object sender, EventArgs e)
        {
            Anamenu anaMenü = new Anamenu();
            anaMenü.Show();
            Hide();
        }

        private void KullanıcıGuncelle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Kullaniciid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

    }
}
