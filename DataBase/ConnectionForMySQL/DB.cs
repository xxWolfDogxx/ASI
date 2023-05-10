using MySql.Data.MySqlClient;

namespace ASI.DataBase.ConnectionForMySQL
{
    class DB
    {
        //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root; database=asi");
        MySqlConnection connection = new MySqlConnection("server=100.100.44.70; port=3306; uid=root; pwd=hvost; database=asi");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
