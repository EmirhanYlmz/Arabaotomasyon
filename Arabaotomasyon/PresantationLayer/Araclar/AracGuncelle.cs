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

namespace Arabaotomasyon.PresantationLayer.Araclar
{
    public partial class AracGuncelle : Form
    {
       
        private AracEkleBLL aracBLL;
        public AracGuncelle()
        {
            InitializeComponent();
            aracBLL = new AracEkleBLL();
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

        private void Anamenudon_Click(object sender, EventArgs e)
        {
            Anamenu anaMenü = new Anamenu();
            anaMenü.Show();
            Hide();
        }

        private void Vtguncelle_Click(object sender, EventArgs e)
        {
            AracEklePoco arac = new AracEklePoco();
            arac = aracBLL.updatearac(aracid.Text, marka.Text, model.Text, yil.Text, plaka.Text);

            MessageBox.Show("Güncelleme işlemi başarılı.");
            listele();
        }

        private void AracGuncelle_Load(object sender, EventArgs e)
        {
            listele();
        }



        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            aracid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            plaka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
