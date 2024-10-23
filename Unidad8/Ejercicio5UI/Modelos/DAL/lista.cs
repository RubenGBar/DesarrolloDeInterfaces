using Ejercicio5Ent;
using System.Collections.ObjectModel;


namespace Ejercicio5UI.Modelos.DAL
{
    class lista
    {   
        public static ObservableCollection<clsPersona> agregarPersonas()
        {
            ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona> {

                (new clsPersona() { nombre = "Pepe", descripcion = "ªªªªªªªªªªªªª", apellido = "Mejorada" }),
                (new clsPersona() { nombre = "PepeLu", descripcion = "aaaaaaaaaaaaa", apellido = "Mejorado" }),
                (new clsPersona() { nombre = "PepeLuis", descripcion = "AAAAAAAAAAAAA", apellido = "Mejoradas" }),
                (new clsPersona() { nombre = "Jose", descripcion = "ªªªªªªªªªªªªª", apellido = "Mejorados" }),
                (new clsPersona() { nombre = "JoseLu", descripcion = "aaaaaaaaaa", apellido = "Mejor" }),
                (new clsPersona() { nombre = "JoseLuis", descripcion = "AAAAAAAAAAAAA", apellido = "Mejora" }),
                (new clsPersona() { nombre = "Marta", descripcion = "AAAAAAAAAAAAA", apellido = "Requejo" }),
                (new clsPersona() { nombre = "Yo", descripcion = "AAAAAAAAAAAAA", apellido = "García" }),
                (new clsPersona() { nombre = "Alonso", descripcion = "AAAAAAAAAAAAA", apellido = "Fernandez" }),
                (new clsPersona() { nombre = "Sergio", descripcion = "AAAAAAAAAAAAA", apellido = "Gonzalez" }),
                (new clsPersona() { nombre = "Alba", descripcion = "AAAAAAAAAAAAA", apellido = "Duque" }),
                (new clsPersona() { nombre = "Ivan", descripcion = "AAAAAAAAAAAAA", apellido = "Perez" }),
                (new clsPersona() { nombre = "Daniel", descripcion = "AAAAAAAAAAAAA", apellido = "Rios" })
            };

            return personas;

        }

    }
}
