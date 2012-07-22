using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;
using Npgsql;



namespace PostgresEditor
{
    static class Conector
    {

        static DataSet ds = new DataSet();
        static DataTable dt = new DataTable();
        public static NpgsqlConnection MyConnection = new NpgsqlConnection();
        public static string zapytanie;
        public static string connectionStr;
        public static DataTable newdt = new DataTable();
        public static bool wczytane = false;

       public static  DataTable Connect()
        {


             


            MyConnection.ConnectionString = connectionStr;
            string sql = String.Format(zapytanie);
            MyConnection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, MyConnection);
            

            ds.Reset();
            da.Fill(ds);
            dt.Reset();
            dt = ds.Tables[0];
           
            MyConnection.Close();
            wczytane = true;

            return dt;
        }
       public static void Save() {


           
           MyConnection.ConnectionString = connectionStr;
           MyConnection.Open();
           string sql = String.Format(zapytanie);
           NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, MyConnection);
           NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(da);
           da.Update(newdt);
           MyConnection.Close();
           
        
       }
    }
}
