using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ASI.DataBase.ConnectionForMySQL
{
    internal class DB
    {
        private static string server;
        private static string port;
        private static string username;
        private static string password;
        private static string database;

        public static string Server { get => server; set => server = value; }
        public static string Port { get => port; set => port = value; }
        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static string Database { get => database; set => database = value; }


        //MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root; database=asi");
        MySqlConnection connection = new MySqlConnection($"server={Server};port={Port};username={Username}; password={Password}; database={Database}");


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
