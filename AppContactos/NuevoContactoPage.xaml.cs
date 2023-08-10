using AppContactos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppContactos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoContactoPage : ContentPage
    {
        public NuevoContactoPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Contacto nuevoContacto = new Contacto()
            {
                Nombre = nombreEntry.Text,
                Apellido = apellidoEntry.Text,
                Telefono = telefonoEntry.Text,
                Email = emailEntry.Text
            };
            //var conexion = new SQLite.SQLiteConnection(App.RUTA_DB);
            //conexion.CreateTable<Contacto>();
            //conexion.Insert(nuevoContacto);
            //conexion.Close();
             using ( var conexion = new SQLite.SQLiteConnection(App.RUTA_DB) )
            {
                conexion.CreateTable<Contacto>();
                conexion.Insert(nuevoContacto);
            }

        }
    }
}