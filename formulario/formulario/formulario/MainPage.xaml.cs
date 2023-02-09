using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void registrar(object sender, EventArgs e)
        {
            DisplayAlert("¡Registro completado!","Usted se ha registrado con exito","Ok");
        }
    }
}
