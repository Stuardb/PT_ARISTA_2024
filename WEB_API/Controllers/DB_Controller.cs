using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace WEB_API.Controllers
{

    public class DataRepository
    {
        private readonly string _connectionString;

        // Constructor que obtiene la cadena de conexión
        public DataRepository()
        {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public async Task<bool> InsertClientDataAsync(string NAME, string SNAME, int PHONE, string ADRESS, string ZIPCODE, string MAIL, string MESSAGE, string LATITUDE, string LONGITUDE)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync();

                    string query = @"
                    INSERT INTO CLIENTE (NAME, SNAME, PHONE, ADRESS, ZIPCODE, MAIL, MESSAGE, LATITUDE, LONGITUDE) 
                    VALUES (@NAME, @SNAME, @PHONE, @ADRESS, @ZIPCODE, @MAIL, @MESSAGE, @LATITUDE, @LONGITUDE)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros para evitar SQL Injection
                        command.Parameters.AddWithValue("@NAME", NAME);
                        command.Parameters.AddWithValue("@SNAME", SNAME);
                        command.Parameters.AddWithValue("@PHONE", PHONE);
                        command.Parameters.AddWithValue("@ADRESS", ADRESS);
                        command.Parameters.AddWithValue("@ZIPCODE", ZIPCODE);
                        command.Parameters.AddWithValue("@MAIL", MAIL);
                        command.Parameters.AddWithValue("@MESSAGE", MESSAGE);
                        command.Parameters.AddWithValue("@LATITUDE", LATITUDE);
                        command.Parameters.AddWithValue("@LONGITUDE", LONGITUDE);
                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        return rowsAffected > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar datos: {ex.Message}");
                return false;
            }
        }
    }

}