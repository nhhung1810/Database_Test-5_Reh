﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestApplication
{
    public static class Connection{
        public static string[] connectionString = new string[6];
        public static int control;

        static Connection()
        {
            connectionString[0] = "Data Source=LAPTOP-HSGL6DT0\\SQLEXPRESS;Initial Catalog=CS486_Team11_DB;Integrated Security=True"; // Tuan
            connectionString[1] = "Data Source=LAPTOP-SMBGUUTC\\SQLEXPRESS01;Initial Catalog=CS486_team11_DB;Integrated Security=True"; //Khoa
            connectionString[2] = "Data Source=DESKTOP-2VSJGTL\\SQLEXPRESS;Initial Catalog=CS468_Team11_DB;Integrated Security=True"; // Tuong
            connectionString[3] = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=CS486_Team11_DB;Integrated Security=True"; //Hung
            connectionString[4] = ""; //Minh
            connectionString[5] = ""; //Trung
        }
    };
    class Misc
    {
        //VARIABLE
        public enum connectBy
        {
            Tuan = 0,
            Khoa = 1,
            Tuong = 2,
            Hung = 3,
            Minh = 4,
            Trung = 5
        }

        public static void setConnection(connectBy name){
            Connection.control = (int)name;
            return;
        }

        public static string getConnectionString()
        {
            return Connection.connectionString[Connection.control];
        }

        public static DataSet getData(string q)
        {
            DataSet ds = null;
            using(SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                //MessageBox.Show(conn.ConnectionString);
                //connection automatically close when go out of scope
                try { conn.Open(); }
                catch(Exception e)
                {
                    //if the connection is broken
                    System.Console.WriteLine(e.ToString());
                    if (conn.State != ConnectionState.Closed) conn.Close();
                    return null;
                }
                
                SqlDataAdapter dapt = new SqlDataAdapter(q, conn);
                ds = new DataSet();

                try { dapt.Fill(ds); }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.ToString());
                    ds = null;
                }
            }
            return ds;
        }

        public static DataTable getData(string q, Dictionary<string, string> parameters)
        {
            DataTable dt = null;
            //IDictionary<string, string> param = parameters;
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            using (SqlCommand cmd = new SqlCommand(q, conn))
            {
                //try to connect
                try { conn.Open(); }
                catch (Exception e)
                {
                    //if the connection is broken
                    System.Console.WriteLine(e.ToString());
                    if (conn.State != ConnectionState.Closed) conn.Close();
                    return null;
                }

                foreach(KeyValuePair<string, string>p in parameters)
                {
                    //SqlParameter sp = new SqlParameter("@" + p.Key, p.Value);
                    MessageBox.Show("@" + p.Key + " " + p.Value);
                    cmd.Parameters.AddWithValue("@" + p.Key, p.Value);
                    //MessageBox.Show(cmd.Parameters.);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                
                try
                {
                    dt = new DataTable();
                    dt.Load(reader);
                }
                catch(Exception e)
                {
                    System.Console.Write(e.ToString());
                    dt = null;
                }

                reader.Close();
                
            }
            return dt;
        }
    }
}
