using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arabaotomasyon.PresantationLayer.Araclar;
using Arabaotomasyon.PresantationLayer.Kullanıcılar;
using Arabaotomasyon.PresantationLayer.Hasarlı;
using Arabaotomasyon.PresantationLayer.Kiralama;

namespace Arabaotomasyon.PresantationLayer

{
    public partial class Anamenu : Form
    {
        public Anamenu()
        {
            InitializeComponent();
        }

        private void bilgiİşlemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracListele araclistele = new AracListele();

            araclistele.Show();
            Hide();
        }

        private void çToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();

            aracEkle.Show();
            Hide();
        }

        private void araçSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracSil aracsil = new AracSil();

            aracsil.Show();
            Hide();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AracGuncelle aracguncelle = new AracGuncelle();

            aracguncelle.Show();
            Hide();
        }

        private void kullanıcıEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KullanıcıEkle kullanıcıEkle = new KullanıcıEkle();

            kullanıcıEkle.Show();
            Hide();
        }

        private void kullanıcıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıGuncelle kullanıcıGuncelle = new KullanıcıGuncelle();

            kullanıcıGuncelle.Show();
            Hide();
        }

        private void kullanıcıListeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıListele kullanıcıListele = new KullanıcıListele();

            kullanıcıListele.Show();
            Hide();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıSil kullanıcıSil = new KullanıcıSil();

            kullanıcıSil.Show();
            Hide();
        }

        private void hasarlıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HasarlıEkle hasarlıEkle = new HasarlıEkle();

            hasarlıEkle.Show();
            Hide();
        }

        private void hasarlıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HasarlıGüncelle hasarlıguncelle = new HasarlıGüncelle();

            hasarlıguncelle.Show();
            Hide();
        }

        private void hasarlıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HasarlıSil hasarlısil = new HasarlıSil();

            hasarlısil.Show();
            Hide();
        }

        private void hasarlıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HasarlıListele hasarlılistele = new HasarlıListele();

            hasarlılistele.Show();
            Hide();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaEkle kiralamaEkle = new KiralamaEkle();

            kiralamaEkle.Show();
            Hide();
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaGuncelle kiralamaGuncelle = new KiralamaGuncelle();

            kiralamaGuncelle.Show();
            Hide();
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaSil kiralamaSil = new KiralamaSil();

            kiralamaSil.Show();
            Hide();
        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiralamaListele kiralamaListele = new KiralamaListele();
            kiralamaListele.Show();
            Hide();
        }
    }
}
