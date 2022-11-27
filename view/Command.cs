using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace view
{
    public class Command
    {
        SqlConnection connect = new SqlConnection(Connection.GetConnect);
        SqlCommand cmd;
        DataTable data = new DataTable();
        string query;

        public DataTable slctName(string tname)
        {
            connect.Open();
            query = "select * from www where CategoryName ='"+tname+"'";
            cmd = new SqlCommand(query, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            connect.Close();
            return data;
        }

    }
}