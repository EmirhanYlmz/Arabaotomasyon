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
using Arabaotomasyon.BussinesLogicLayer;
using Arabaotomasyon.PocosLayer;

namespace Arabaotomasyon
{
    public partial class OturumAc : Form
    {
        KullanicilarBLL _kullanicibll;
        public OturumAc()
        {
            InitializeComponent();
            _kullanicibll = new KullanicilarBLL();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void giris_Click(object sender, EventArgs e)
        {
             KullanicilarPoco _kullanicilarpoco = new KullanicilarPoco();
            _kullanicilarpoco = _kullanicibll.getSorgu(textBox1.Text, textBox2.Text);

            if (_kullanicilarpoco.isim == null || _kullanicilarpoco.sifre == null)
            {
                MessageBox.Show("Hatalı Giriş");
            }
            else
            {
                this.Hide();
                MessageBox.Show("Hoş Geldiniz", _kullanicilarpoco.isim);
                Anamenu loginScreen = new Anamenu();
                loginScreen.Show();
            }
        }

        private void OturumAc_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
