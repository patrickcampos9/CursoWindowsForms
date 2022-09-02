using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class MySqlDBClass
    {
        public string server = "127.0.0.1";
        public string port = "3306";
        public string dataBase = "bytebank";
        public string userName = "root";
        public string password = "admin123";
        public string stringConn;
        public MySqlConnection connDB;

        public MySqlDBClass()
        {
            try
            {
                stringConn = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + dataBase + ";" + "UID=" + userName + ";" + "PASSWORD=" + password + ";";
                connDB = new MySqlConnection(stringConn);
                connDB.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new MySqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable MySQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var myCommand = new MySqlCommand(SQL, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }


        public void Close()
        {
            connDB.Close();
        }
    }
}
