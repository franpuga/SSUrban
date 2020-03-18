using Newtonsoft.Json;
using SSUrbanModelo;
using SSUrbanService.DataContract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SSUrban.Helpers
{
    public static class WebRequestHelper
    {
        public static void CallPostMethod()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:50378/api/AddInmueble");
            var postData = new InmuebleDTO()
            {
                Fecha = DateTime.Now,
                VendedorArrendador = "46902201A",
                Descripcion = "Piso Precioso 350E"
            };
            var serializedData = JsonConvert.SerializeObject(postData);
            var data = Encoding.UTF8.GetBytes(serializedData);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }

    public class TabAccessDTO
    {
        public string Tab { get; set; }

        public string UserName { get; set; }
    }
}
