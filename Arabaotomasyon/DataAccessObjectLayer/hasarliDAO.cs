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
    class hasarliDAO
    {
        private VeriTabanibaglantisi baglanti;
        public hasarliDAO()
        {

            baglanti = new VeriTabanibaglantisi();
        }
        public bool inserthasarlı(string hasarlı, string marka, string model, string yıl, string hasartipi)
        {

            string sorgu = string.Format("insert into hasarlı(hasarliid, marka, model, yıl, hasartipi)" +
                "values (@hasarlino, @marka, @model, @yil, @hasartipi)");

            SqlParameter[] sqlParameter = new SqlParameter[5];

            sqlParameter[0] = new SqlParameter("@hasarlino", SqlDbType.Int);
            sqlParameter[0].Value = Convert.ToInt32(hasarlı);

            sqlParameter[1] = new SqlParameter("@marka", SqlDbType.VarChar);
            sqlParameter[1].Value = Convert.ToString(marka);

            sqlParameter[2] = new SqlParameter("@model", SqlDbType.VarChar);
            sqlParameter[2].Value = Convert.ToString(model);

            sqlParameter[3] = new SqlParameter("@yil", SqlDbType.VarChar);
            sqlParameter[3].Value = Convert.ToString(yıl);
           
            sqlParameter[4] = new SqlParameter("@hasartipi", SqlDbType.VarChar);
            sqlParameter[4].Value = Convert.ToString(hasartipi);

            return baglanti.exucuteInsertQuery(sorgu, sqlParameter);

        }
        public bool guncellehasar(string hasarlı, string marka, string model, string yıl,  string hasartipi)
        {
            string sorgu = string.Format("update hasarlı set marka=@marka, model=@model, yıl=@yıl, hasartipi=@hasartipi " +
                "where hasarliid = '" + hasarlı + "'");

            SqlParameter[] sqlParameter = new SqlParameter[4];

            sqlParameter[0] = new SqlParameter("@marka", SqlDbType.VarChar);
            sqlParameter[0].Value = Convert.ToString(marka);

            sqlParameter[1] = new SqlParameter("@model", SqlDbType.VarChar);
            sqlParameter[1].Value = Convert.ToString(model);

            sqlParameter[2] = new SqlParameter("@yıl", SqlDbType.VarChar);
            sqlParameter[2].Value = Convert.ToString(yıl);

            sqlParameter[3] = new SqlParameter("@hasartipi", SqlDbType.VarChar);
            sqlParameter[3].Value = Convert.ToString(hasartipi);



            return baglanti.exucuteUpdateQuery(sorgu, sqlParameter);
        }
        public bool deletehasar(string hasarlı)
        {

            string sorgu = string.Format("delete hasarlı where hasarliid = '" + hasarlı + "'");

            return baglanti.exucuteDeleteQuery(sorgu);

        }
    }
}
