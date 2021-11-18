using Examen2PM02.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen2PM02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaAlumnos : ContentPage
    {
        public ListaAlumnos()
        {
            InitializeComponent();
            getAlumnos("");
            validarConexion();
        }

        private bool verifBD()
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();

                byte[] response = cliente.UploadValues(App.ruta + "conexion2.php", "POST", parametros);
                string c = Encoding.ASCII.GetString(response);
                if (c.Equals("1")) return true;
                else return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

         public async void validarConexion()
        {
            if (!verifBD())
            {
                await DisplayAlert("Error", "No hay conexion con los servicios de datos", "Ok");
            }
        }

        public async void getAlumnos(string year)
        {
            try
            {
                AlumnoHelper manager = new AlumnoHelper();

                var res = await manager.getAlumno(year);
                if (res != null)
                {
                    lstAlumnos.ItemsSource = res;
                }
                else
                {
                    await DisplayAlert("Notificacion", "No se encontraron registros en la busqueda", "ok");
                }
            }catch(Exception e)
            {
                await DisplayAlert("Error", "No se pueden obtener los datos desde el servidor", "ok");
            }
        }

        private async void btnBuscar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FormYear.Text))
            {
                getAlumnos(FormYear.Text);
            }
            else
            {
                await DisplayAlert("notificacion", "Debe ingresar un año", "ok");
            }
            
        }

        
    }
}