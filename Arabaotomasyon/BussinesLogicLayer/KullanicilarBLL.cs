using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arabaotomasyon.DataAccessObjectLayer;
using Arabaotomasyon.PocosLayer;
using System.Data;



namespace Arabaotomasyon.BussinesLogicLayer
{
    class KullanicilarBLL
    {
        private KullanicilarDAO KullanicilarDAO;



        public KullanicilarBLL()
        {
            KullanicilarDAO = new KullanicilarDAO();

        }

        public KullanicilarPoco getSorgu(string kullaniciAdi, string sifre)
        {
            KullanicilarPoco kullaniciGirisi = new KullanicilarPoco();

            DataTable dataTable = new DataTable();
            dataTable = KullanicilarDAO.SearchKullaniciAdiveSifre(kullaniciAdi, sifre);


            foreach (DataRow dr in dataTable.Rows)
            {
                kullaniciGirisi.isim = dr["isim"].ToString();
                kullaniciGirisi.sifre = dr["sifre"].ToString();

            }
            

            return kullaniciGirisi;
        }

        public KullanicilarPoco kaydetkullanici(string kullanici, string isim, string sifre)
        {

            KullanicilarPoco kullanicikaydet = new KullanicilarPoco();
            DataTable dataTable = new DataTable();

            KullanicilarDAO.insertkullanıcılar(kullanici, isim, sifre);

            foreach(DataRow dr in dataTable.Rows)
            {
                dr["kullanici"] = kullanicikaydet.kullanici;
                dr["isim"] = kullanicikaydet.isim;
                dr["sifre"] = kullanicikaydet.sifre;
            }
            return kullanicikaydet;
        }

        public KullanicilarPoco updatekullanıcı(string kullanici, string isim, string sifre)
        {
            KullanicilarPoco kullaniciguncelle = new KullanicilarPoco();
            DataTable dataTable = new DataTable();

            KullanicilarDAO.guncellekullanici(kullanici, isim, sifre);
            foreach (DataRow dr in dataTable.Rows)
            {


                dr["kullanici"] = kullaniciguncelle.kullanici;
                dr["isim"] = kullaniciguncelle.isim;
                dr["sifre"] = kullaniciguncelle.sifre;



            }
            return kullaniciguncelle;
        }

        public KullanicilarPoco silkullanıcı(string kullanici)
        {
            KullanicilarPoco kullanıcisil = new KullanicilarPoco();
            DataTable dataTable = new DataTable();

            KullanicilarDAO.deletekullanici(Convert.ToString(kullanici));

            return kullanıcisil;
        }
       
    }
}
