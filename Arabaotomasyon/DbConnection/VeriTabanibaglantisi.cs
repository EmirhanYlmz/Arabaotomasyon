using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Arabaotomasyon.DbConnection
{
    class VeriTabanibaglantisi
    {

        private SqlDataAdapter dataAdapter;
        public SqlConnection baglanti;


        public VeriTabanibaglantisi(){

            dataAdapter = new SqlDataAdapter();
            baglanti = new SqlConnection(@"Data Source=DESKTOP-2MUVHCD;Initial Catalog=otomasyon;Integrated Security=True");
            }
        private SqlConnection openConnection()
        {
            if (baglanti.State == ConnectionState.Closed || baglanti.State == ConnectionState.Broken)
            {
                baglanti.Open();
            }

            return baglanti;
        }
        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameters);
                sqlCommand.ExecuteNonQuery();

                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(ds);
                dataTable = ds.Tables[0];

            }
            catch (SqlException e)
            {
                Console.WriteLine("seçme hatası: " + e.Message);
                return null;
            }

            return dataTable;


        }
        public bool exucuteInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameter);

                dataAdapter.InsertCommand = sqlCommand;

                sqlCommand.ExecuteNonQuery();



            }
            catch (SqlException e)
            {
                Console.WriteLine(" ekleme hatası: " + e.Message);
                return false;
            }

            return true;
        }
        public bool exucuteUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameter);
                dataAdapter.UpdateCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();


            }
            catch (SqlException e)
            {
                Console.WriteLine(" güncelleme hatası: " + e.Message);
                return false;
            }

            return true;
        }
        public bool exucuteDeleteQuery(String _query)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                dataAdapter.SelectCommand = sqlCommand;

                sqlCommand.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(" silme hatası: " + e.Message);
                return false;
            }

            return true;
        }

    }
}
