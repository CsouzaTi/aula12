namespace aula12
{
    using MySql.Data.MySqlClient;
    using System.Data;

    public class Database
    {
        private MySqlConnection connection;

        public Database()
        {

            string connectionString = "server=localhost;database=CrudExample;user=root;password=helo1918;";


            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                
                if (connection.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Tentando abrir a conexão...");
                    connection.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");
                }
            }
            catch (MySqlException ex)
            {
               
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                
                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("Tentando fechar a conexão...");
                    connection.Close();
                    Console.WriteLine("Conexão fechada com sucesso!");
                }
            }
            catch (MySqlException ex)
            {
                
                Console.WriteLine("Erro ao fechar a conexão: " + ex.Message);
            }
        }
    }
}
