using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace BackEnd.Models
{
    public class DAL
    {
        public static String con = "server=HELLO-WORLD-PC\\NEWSERVER; database=WebAPI; Integrated Security= true";
        public static DataTable connect(string query)
        {
            try
            {
                DataTable table = new DataTable() ;
                SqlConnection conn = new SqlConnection(con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                conn.Open();
                adapter.Fill(table);
                return table;
            }
            catch (Exception e1)
            {
                Debug.WriteLine("SQLError "+e1.ToString());
                return null;
            }
            }
    }
}