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

namespace Arabaotomasyon.PresantationLayer.Kiralama
{
    public partial class KiralamaGuncelle : Form
    {
        KiralamaBLL kiralamabll;
        public KiralamaGuncelle()
        {
            InitializeComponent();
            kiralamabll = new KiralamaBLL();
        }
        public void listele()
        {
            VeriTabanibaglantisi yenivtbaglanti = new VeriTabanibaglantisi();
            SqlCommand sorgu = new SqlCommand("Select*from kiralama", yenivtbaglanti.baglanti);

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;

        }

        private void Vtekle_Click(object sender, EventArgs e)
        {
            KiralamaPoco kiralamaPoco = new KiralamaPoco();
            kiralamaPoco = kiralamabll.updatekiralama(musteriid.Text, isim.Text, soyisim.Text, telefon.Text, alınantarih.Text, teslimtarih.Text, fiyat.Text);

            MessageBox.Show("Güncelleme işlemi başarılı.");
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
            musteriid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            telefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            alınantarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            teslimtarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            fiyat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void KiralamaGuncelle_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
