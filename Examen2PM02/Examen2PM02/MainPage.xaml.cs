using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen2PM02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnPerfilAlumno_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilAlumno());
        }

        private async void btnListadoAlumnos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaAlumnos());
            
        }
    }
}
