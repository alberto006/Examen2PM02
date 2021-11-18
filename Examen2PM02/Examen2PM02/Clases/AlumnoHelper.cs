using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;

namespace Examen2PM02.Clases
{
    class AlumnoHelper
    {

        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");
            return client;

        }

        public async Task<IEnumerable<Alumno>> getAlumno(string year)
        {
            if (year != "")
            {
                HttpClient client = getCliente();
                var res = await client.GetAsync(App.ruta + "verAlumnos.php?year=" + year);
                if (res.IsSuccessStatusCode)
                {
                    string content = await res.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IEnumerable<Alumno>>(content);
                }               
            }
            return Enumerable.Empty<Alumno>();
        }


        public async Task<IEnumerable<Alumno>> traeUnAlumno(string cedula)
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(App.ruta + "verAlumno.php?cedula=" + cedula);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Alumno>>(content);
            }
            return Enumerable.Empty<Alumno>();
        }

    }
}
