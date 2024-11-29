using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using WEB_API.Classes;
namespace WEB_API.Controllers
{
    public class DataController : ApiController
    {
        [HttpPost]
        [Route("mi-info")]
        public async Task<IHttpActionResult> PostFormData([FromBody] ClientData Data)
        {
            var ZipData = Data.ZipCode;
            var Result = await GetZipCodeInfo(Data.ZipCode);

            if (Result == null)
            {
                return InternalServerError(new Exception("Código postal incorrecto."));
            }
            var repository = new DataRepository();
            bool success = await repository.InsertClientDataAsync(Data.Name, Data.SName, Data.Phone, Data.Adress, Data.ZipCode, Data.Mail, Data.Message, Result.latitude, Result.longitude);

            if (success)
            {
                return Ok(new { message = "Datos insertados correctamente", zipData = Result });
            }
            else
            {
                return InternalServerError(new Exception("Error al insertar datos en la base de datos."));
            }
        }

        private async Task<dynamic> GetZipCodeInfo(string zipCode)
        {
            using (var client = new HttpClient())
            {
                var url = $"http://api.zippopotam.us/us/{zipCode}";
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    //var zipData = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();

                        // Deserializar la respuesta JSON
                        var zipData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                        return zipData;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    //return e.Message;
                    return new { error = $"Error al intentar obtener la información: {e.Message}" };
                }
            }             
                
                //if (string.IsNullOrEmpty(response))
                //{
                //    return "Error";
                //}
               
            
        }
    }
}
