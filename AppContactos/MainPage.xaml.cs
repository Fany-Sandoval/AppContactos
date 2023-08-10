using AppContactos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppContactos
{
    public partial class MainPage : ContentPage
    {
        List<Contacto> Contactos;
        public MainPage()
        {
            InitializeComponent();
            //Cargamos la lista de contactos.
            Contactos= new List<Contacto>();
        }
        //Sobrescribimos para la conexion de base de datos
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (var conexion = new SQLite.SQLiteConnection(App.RUTA_DB))
            {
                conexion.CreateTable<Contacto>();
                Contactos = conexion.Table<Contacto>().ToList();
                //Llenamos la vista
                contactosListView.ItemsSource = Contactos;
            }

        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoContactoPage());
        }
    }
}
