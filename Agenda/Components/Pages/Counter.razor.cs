using Microsoft.Data.SqlClient;
using System.Data;

namespace Agenda.Components.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            // Cadena de conexión usando credenciales sql server
            // string connectionString = "Server=localhost;Database=AgendaDb;User Id=sa;Password=your_password;";

            // Cadena de conexión usando autenticación integrada de Windows
            string connectionString = "Server=localhost;Database=AgendaDb;Trusted_connection=True;TrustServerCertificate=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Contactos (Nombre, Apellido, Telefono, CorreoElectronico) " +
                "VALUES ('Mayra', 'Tovar', '6621993584','mayra.alet@icloud.com')";

            SqlCommand command = new SqlCommand(query , connection);

            command.CommandType = CommandType.Text;

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
