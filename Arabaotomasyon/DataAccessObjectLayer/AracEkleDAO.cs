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
    class AracEkleDAO
    {
        private VeriTabanibaglantisi baglanti;

        public AracEkleDAO()
        {

            baglanti = new VeriTabanibaglantisi();
        }

        public bool insertarac(string arac, string marka, string model, string yıl, string plaka)
        {

            string sorgu = string.Format("insert into arac(aracid, marka, model, yıl, plaka)" +
                "values (@aracno, @marka, @model, @yil, @plaka)");

            SqlParameter[] sqlParameter = new SqlParameter[5];

            sqlParameter[0] = new SqlParameter("@aracno", SqlDbType.Int);
            sqlParameter[0].Value = Convert.ToInt32(arac);

            sqlParameter[1] = new SqlParameter("@marka", SqlDbType.VarChar);
            sqlParameter[1].Value = Convert.ToString(marka);

            sqlParameter[2] = new SqlParameter("@model", SqlDbType.VarChar);
            sqlParameter[2].Value = Convert.ToString(model);

            sqlParameter[3] = new SqlParameter("@yil", SqlDbType.VarChar);
            sqlParameter[3].Value = Convert.ToString(yıl);

            sqlParameter[4] = new SqlParameter("@plaka", SqlDbType.VarChar);
            sqlParameter[4].Value = Convert.ToString(plaka);

            return baglanti.exucuteInsertQuery(sorgu, sqlParameter);

        }

        public bool guncellearac(string arac, string marka, string model, string yıl, string plaka)
        {
            string sorgu = string.Format("update arac set marka=@marka, model=@model, yıl=@yıl, plaka=@plaka " +
                "where aracid = '" + arac + "'");

            SqlParameter[] sqlParameter = new SqlParameter[4];

            sqlParameter[0] = new SqlParameter("@marka", SqlDbType.VarChar);
            sqlParameter[0].Value = Convert.ToString(marka);

            sqlParameter[1] = new SqlParameter("@model", SqlDbType.VarChar);
            sqlParameter[1].Value = Convert.ToString(model);

            sqlParameter[2] = new SqlParameter("@yıl", SqlDbType.VarChar);
            sqlParameter[2].Value = Convert.ToString(yıl);

            sqlParameter[3] = new SqlParameter("@plaka", SqlDbType.VarChar);
            sqlParameter[3].Value = Convert.ToString(plaka);



            return baglanti.exucuteUpdateQuery(sorgu, sqlParameter);
        }

        public bool deletearac(string arac)
        {

            string sorgu = string.Format("delete arac where aracid = '" + arac + "'");

            return baglanti.exucuteDeleteQuery(sorgu);

        }
    }
}
