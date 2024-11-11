using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ModeloEjercicio3;

namespace Ejercicio3.Models
{
    internal class viewModel: INotifyPropertyChanged
    {
        //private Persona _persona;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                INotifyPropertyChanged("Persona");
            }
        }

        public clsPersona Persona
        {
            get { return new clsPersona(Nombre); }
        }

        #region Notify
        private void INotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
    }
}
