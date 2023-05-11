using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ASI.DataBase.ConnectionForMySQL
{
    class DB
    {

        //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root; database=asi");
        MySqlConnection connection = new MySqlConnection("server=100.100.44.70;port=33061;username=sobol; password=6vxEE8u#; database=asi");
        MySqlConnection connection = new MySqlConnection("server=100.100.44.0;port=33061;username=sobol; password=6vxEE8u#; database=asi");

        public void openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
                        
            
            
        }

        public void closeConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        public MySqlConnection getConnection()
        {
            try
            {
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return connection;

            }
            
        }



    }
}
