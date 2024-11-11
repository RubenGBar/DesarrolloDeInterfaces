using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModeloEjercicio3
{
    public class clsPersona
    {

        /// <summary>
        /// Atributo que almacena el nombre de la persona
        /// </summary>
        private String nombre { get; set; }

        public clsPersona()
        {
            nombre = "Ruben";
        }

        /// <summary>
        /// Constructor de la clase persona
        /// </summary>
        /// <param name="nombre"></param>
        public clsPersona(string nombre)
        {
            this.nombre = nombre;
        }

        public String Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
            }
        }

    }
}
