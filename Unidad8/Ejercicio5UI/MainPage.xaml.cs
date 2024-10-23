using Ejercicio5Ent;
using Ejercicio5UI.Modelos.DAL;
using System.Collections.ObjectModel;


namespace Ejercicio5UI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            PersonaListView.ItemsSource = lista.agregarPersonas();

        }

    }

}
