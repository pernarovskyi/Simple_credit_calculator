using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ipoteka
{
    class DataBase
    {
        static readonly string connetionString = "Data Source=localhost; Initial Catalog=home_test_db;User ID=root; Password=";
        MySqlConnection connection = new MySqlConnection(connetionString);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                try
                {
                    connection.Open();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Cann't open dataBase");
                    MessageBox.Show(ex.Message);
                }        
        }

        public void closeConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                return;
            connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
