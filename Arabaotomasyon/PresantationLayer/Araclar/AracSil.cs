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
    public partial class AracSil : Form
    {
        private AracEkleBLL aracBLL;
        public AracSil()
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

        private void AracSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Vtsil_Click(object sender, EventArgs e)
        {
            AracEklePoco aracsil = new AracEklePoco();
            aracsil = aracBLL.silarac(aracid.Text);
            MessageBox.Show("Silme işlemi gerçekleştirildi.");
            listele();
        }

        private void Anamenudon_Click(object sender, EventArgs e)
        {
            Anamenu anaMenü = new Anamenu();
            anaMenü.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aracid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            marka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            plaka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
