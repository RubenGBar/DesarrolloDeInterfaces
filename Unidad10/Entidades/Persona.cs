using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Atributos
        int id { get; }
        String nombre { get; set; }
        String apellidos { get; set; }
		DateTime fechaNac { get; set; }
		String foto { get; set; }
		String direccion { get; set; }
		int telefono { get; set; }
        #endregion Atributos

        #region Propiedades
        public int Id 
        {
            get { return id; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        #endregion Propiedades

        #region Constructores
        public Persona() { }

        public Persona(int id, String nombre, String apellidos, DateTime fechaNac, String foto, String direccion, int telefono) 
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.foto = foto;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        #endregion Constructores
    }
}