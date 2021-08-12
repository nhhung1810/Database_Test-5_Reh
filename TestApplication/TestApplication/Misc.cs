using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Misc
    {
        //VARIABLE
        public static string[] connectionString;
        private static int control;
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
            control = (int)name;
            return;
        }

        public static string getConnectionString()
        {
            connectionString = new string[6];
            connectionString[0] = "Data Source=LAPTOP-HSGL6DT0\\SQLEXPRESS;Initial Catalog=CS486_Team11_DB;Integrated Security=True"; // Tuan
            connectionString[1] = "Data Source=LAPTOP-SMBGUUTC\\SQLEXPRESS01;Initial Catalog=CS468_team11_DB;Integrated Security=True"; //Khoa
            connectionString[2] = "Data Source=DESKTOP-2VSJGTL\\SQLEXPRESS;Initial Catalog=CS468_Team11_DB;Integrated Security=True"; // Tuong
            connectionString[3] = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=CS468_Team11_DB;Integrated Security=True"; //Hung
            connectionString[4] = ""; //Minh
            connectionString[5] = ""; //Trung
            return connectionString[control];
        }
    }
}
