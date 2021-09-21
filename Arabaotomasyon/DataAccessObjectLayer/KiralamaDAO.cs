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
    class KiralamaDAO
    {
        private VeriTabanibaglantisi baglanti;
        public KiralamaDAO()
        {

            baglanti = new VeriTabanibaglantisi();
        }
        public bool insertkiralama(string musteriid, string isim, string soyisim, string telefon, string alınantarih, string teslimtarih, string fiyat)
        {

            string sorgu = string.Format("insert into kiralama(musteriid, isim, soyisim, telefon, alınantarih, teslimtarih, fiyat)" +
                "values (@musterino, @isim, @soyisim, @telefon, @alınantarih, @teslimtarihi, @fiyat)");

            SqlParameter[] sqlParameter = new SqlParameter[7];

            sqlParameter[0] = new SqlParameter("@musterino", SqlDbType.Int);
            sqlParameter[0].Value = Convert.ToInt32(musteriid);

            sqlParameter[1] = new SqlParameter("@isim", SqlDbType.VarChar);
            sqlParameter[1].Value = Convert.ToString(isim);

            sqlParameter[2] = new SqlParameter("@soyisim", SqlDbType.VarChar);
            sqlParameter[2].Value = Convert.ToString(soyisim);

            sqlParameter[3] = new SqlParameter("@telefon", SqlDbType.VarChar);
            sqlParameter[3].Value = Convert.ToString(telefon);

            sqlParameter[4] = new SqlParameter("@alınantarih", SqlDbType.VarChar);
            sqlParameter[4].Value = Convert.ToString(alınantarih);

            sqlParameter[5] = new SqlParameter("@teslimtarihi", SqlDbType.VarChar);
            sqlParameter[5].Value = Convert.ToString(teslimtarih);

            sqlParameter[6] = new SqlParameter("@fiyat", SqlDbType.VarChar);
            sqlParameter[6].Value = Convert.ToString(fiyat);

            return baglanti.exucuteInsertQuery(sorgu, sqlParameter);

        }
        public bool guncellekiralama(string musteriid, string isim, string soyisim, string telefon, string alınantarih, string teslimtarih, string fiyat)
        {

            string sorgu = string.Format("update kiralama set isim=@isim, soyisim=@soyisim, telefon=@telefon, alınantarih=@alınantarih, teslimtarih=@teslimtarih, fiyat=@fiyat " +
                "where musteriid = '" + musteriid + "'");

            SqlParameter[] sqlParameter = new SqlParameter[6];

            sqlParameter[0] = new SqlParameter("@isim", SqlDbType.VarChar);
            sqlParameter[0].Value = Convert.ToString(isim);

            sqlParameter[1] = new SqlParameter("@soyisim", SqlDbType.VarChar);
            sqlParameter[1].Value = Convert.ToString(soyisim);

            sqlParameter[2] = new SqlParameter("@telefon", SqlDbType.VarChar);
            sqlParameter[2].Value = Convert.ToString(telefon);

            sqlParameter[3] = new SqlParameter("@alınantarih", SqlDbType.VarChar);
            sqlParameter[3].Value = Convert.ToString(alınantarih);

            sqlParameter[4] = new SqlParameter("@teslimtarih", SqlDbType.VarChar);
            sqlParameter[4].Value = Convert.ToString(teslimtarih);

            sqlParameter[5] = new SqlParameter("@fiyat", SqlDbType.VarChar);
            sqlParameter[5].Value = Convert.ToString(fiyat);

            return baglanti.exucuteUpdateQuery(sorgu, sqlParameter);

        }
        public bool deletekiralama(string musteri)
        {

            string sorgu = string.Format("delete kiralama where musteriid = '" + musteri + "'");

            return baglanti.exucuteDeleteQuery(sorgu);

        }

    }
}
