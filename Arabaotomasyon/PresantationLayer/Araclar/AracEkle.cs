using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arabaotomasyon.PresantationLayer;
using Arabaotomasyon.PocosLayer;
using Arabaotomasyon.BussinesLogicLayer;
using Arabaotomasyon.DbConnection;
using System.Data.SqlClient;

namespace Arabaotomasyon.PresantationLayer.Araclar
{
    public partial class AracEkle : Form
    {
        AracEkleBLL aracEkleBLL;
        public AracEkle()
        {
            InitializeComponent();
            aracEkleBLL = new AracEkleBLL();
        }

        public void listele()
        {
            VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
            SqlCommand sorgu = new SqlCommand("Select*from arac", yenivtbaglanti.baglanti);

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;

        }

        private void Vtekle_Click(object sender, EventArgs e)
        {
            AracEklePoco arac = new AracEklePoco();
            arac = aracEkleBLL.kaydetarac(aracid.Text, marka.Text, model.Text, yil.Text, plaka.Text);
            MessageBox.Show("İşlem Başarılı.");
            listele();
        }

        private void Anamenudon_Click(object sender, EventArgs e)
        {
            Anamenu anaMenü = new Anamenu();
            anaMenü.Show();
            Hide();
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            aracid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            plaka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
