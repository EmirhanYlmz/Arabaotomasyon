using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arabaotomasyon.DbConnection;
using System.Data;
using System.Data.SqlClient;

namespace Arabaotomasyon.DataAccessObjectLayer
{
    class KullanicilarDAO
    {
        private VeriTabanibaglantisi baglanti;

        public KullanicilarDAO()
        {

            baglanti = new VeriTabanibaglantisi();
        }


        public DataTable SearchKullaniciAdiveSifre(string kullaniciAdi, string sifre)
        {
            string sorgu = string.Format("select *from kullanıcılar where isim =@kullaniciAdi and  sifre = @sifre");

            SqlParameter[] sqlParemeters = new SqlParameter[2];
            sqlParemeters[0] = new SqlParameter("@kullaniciAdi", SqlDbType.NVarChar);
            sqlParemeters[0].Value = Convert.ToString(kullaniciAdi);

            sqlParemeters[1] = new SqlParameter("@sifre", SqlDbType.NVarChar);
            sqlParemeters[1].Value = Convert.ToString(sifre);


            return baglanti.executeSelectQuery(sorgu, sqlParemeters);
        }
        public bool insertkullanıcılar(string kullanici, string isim, string sifre) {

            string sorgu = string.Format("insert into kullanıcılar(kullanici, isim, sifre)" +
                "values (@kullanici, @isim, @sifre)");

            SqlParameter[] sqlParameter = new SqlParameter[3];

            sqlParameter[0] = new SqlParameter("@kullanici", SqlDbType.Int);
            sqlParameter[0].Value = Convert.ToInt32(kullanici);

            sqlParameter[1] = new SqlParameter("@isim", SqlDbType.VarChar);
            sqlParameter[1].Value = Convert.ToString(isim);

            sqlParameter[2] = new SqlParameter("@sifre", SqlDbType.VarChar);
            sqlParameter[2].Value = Convert.ToString(sifre);

            return baglanti.exucuteInsertQuery(sorgu, sqlParameter);

        }

        public bool guncellekullanici(string kullanici, string isim, string sifre)
        {
            string sorgu = string.Format("update kullanıcılar set isim=@isim, sifre=@sifre " +
                "where kullanici = '" + kullanici + "'");

            SqlParameter[] sqlParameter = new SqlParameter[2];

            sqlParameter[0] = new SqlParameter("@isim", SqlDbType.VarChar);
            sqlParameter[0].Value = Convert.ToString(isim);

            sqlParameter[1] = new SqlParameter("@sifre", SqlDbType.VarChar);
            sqlParameter[1].Value = Convert.ToString(sifre);



            return baglanti.exucuteUpdateQuery(sorgu, sqlParameter);
        }
        public bool deletekullanici(string kullanici){

            string sorgu = string.Format("delete kullanıcılar where kullanici = '" + kullanici + "'");

            return baglanti.exucuteDeleteQuery(sorgu);
      
        }

    }
}
