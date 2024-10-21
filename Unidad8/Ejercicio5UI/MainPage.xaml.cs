using Ejercicio5Ent;
using System.Collections.ObjectModel;


namespace Ejercicio5UI
{
    public partial class MainPage : ContentPage
    {

        ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona>();
        public ObservableCollection<clsPersona> Persona { get { return personas; } }
        public MainPage()
        {
            InitializeComponent();
            personas.Add(new clsPersona() { nombre = "Pepe", descripcion="ªªªªªªªªªªªªª", apellido="Mejorada"});
            personas.Add(new clsPersona() { nombre = "PepeLu", descripcion = "aaaaaaaaaaaaa", apellido = "Mejorado" });
            personas.Add(new clsPersona() { nombre = "PepeLuis", descripcion = "AAAAAAAAAAAAA", apellido = "Mejoradas" });
            personas.Add(new clsPersona() { nombre = "Jose", descripcion = "ªªªªªªªªªªªªª", apellido = "Mejorados" });
            personas.Add(new clsPersona() { nombre = "JoseLu", descripcion = "aaaaaaaaaa", apellido = "Mejor" });
            personas.Add(new clsPersona() { nombre = "JoseLuis", descripcion = "AAAAAAAAAAAAA", apellido = "Mejora" });
            PersonaListView.ItemsSource = personas;
        }

    }

}
