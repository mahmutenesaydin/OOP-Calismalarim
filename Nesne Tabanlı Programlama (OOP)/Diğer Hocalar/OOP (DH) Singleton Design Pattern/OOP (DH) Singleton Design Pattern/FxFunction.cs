using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__DH__Singleton_Design_Pattern
{
    public class FxFunction
    {
        private static FxFunction _instance;
        private FxFunction() { }
        public static FxFunction GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FxFunction();
            }
            return _instance;
        }


        SqlConnection baglanti = new SqlConnection("Data Source=ABC-BILGISAYAR\\MHMTENES13;Initial Catalog=Northwind;Integrated Security=True");
        public int Insert(string sqlCmd)
        {
            SqlCommand cmd = new SqlCommand(sqlCmd, baglanti);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            int sonuc = cmd.ExecuteNonQuery();
            baglanti.Close();
            return sonuc;
        }
        public DataTable GetData(string sqlCmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
