using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Front.Classes;
using System.Net.Http;

namespace Front
{
    public class POST
    {        
        public async Task POST_ClientData(ClientData data)
        {
            // Crear la instancia de HttpClient
            using (HttpClient client = new HttpClient())
            {
                // URL de la API donde se enviarán los datos
                string apiUrl = "http://localhost:44308/mi-info"; // Reemplaza PORT_NUMBER por tu puerto

                // Convertir los datos del cliente a JSON
                string jsonData = JsonConvert.SerializeObject(data);

                // Crear el contenido de la solicitud (POST)
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar la solicitud POST y esperar la respuesta
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Comprobar si la solicitud fue exitosa
                if (response.IsSuccessStatusCode)
                {
                    // Procesar la respuesta si es exitosa
                    string responseContent = await response.Content.ReadAsStringAsync();
                    // Aquí puedes hacer algo con la respuesta (por ejemplo, loguearla o mostrarla)
                }
                else
                {
                    // Si la solicitud falla
                    string errorContent = await response.Content.ReadAsStringAsync();
                    // Aquí puedes manejar el error (por ejemplo, loguearlo o mostrar un mensaje de error)
                }
            }
        }
    }    
}