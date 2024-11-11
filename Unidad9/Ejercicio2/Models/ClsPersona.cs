using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio2.Models
{
    /// <summary>
    /// Clase persona
    /// </summary>
    public class ClsPersona: INotifyPropertyChanged
    {
        /// <summary>
        /// Atributo que almacena el nombre de la persona
        /// </summary>
        private String nombre { get; set; }

        public ClsPersona()
        {
            nombre = "Ruben";
        }

        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        /// <param name="nombre"></param>
        public ClsPersona(string nombre)
        {
            this.nombre = nombre;
        }

        public String Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
