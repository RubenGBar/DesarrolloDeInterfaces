using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    internal class PersonaDAL
    {
        public List<Persona> obtenerDatosDAL() 
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona(1, "Juan", "Pérez", new DateTime(1990, 5, 15), "isaac.jpg", "Calle Falsa 123", 123456789),
                new Persona(2, "Ana", "Gómez", new DateTime(1985, 8, 23), "isaac.jpg", "Avenida Siempre Viva 456", 987654321),
                new Persona(3, "Carlos", "López", new DateTime(2000, 3, 10), "isaac.jpg", "Boulevard del Sol 789", 456123789),
                new Persona(4, "María", "Rodríguez", new DateTime(1995, 12, 1), "isaac.jpg", "Plaza Central 321", 741852963),
                new Persona(5, "Pedro", "Hernández", new DateTime(1988, 7, 22), "isaac.jpg", "Camino Real 101", 852963741),
                new Persona(6, "Lucía", "Martínez", new DateTime(1992, 11, 5), "isaac.jpg", "Parque del Norte 202", 369258147),
                new Persona(7, "Miguel", "García", new DateTime(1993, 6, 18), "isaac.jpg", "Plaza del Sol 303", 147852369),
                new Persona(8, "Elena", "Sánchez", new DateTime(1980, 2, 28), "isaac.jpg", "Calle Luna 404", 951753852),
                new Persona(9, "Sofía", "Torres", new DateTime(1999, 9, 9), "isaac.jpg", "Calle Estrella 505", 258369147),
                new Persona(10, "Diego", "Castro", new DateTime(1997, 4, 15), "isaac.jpg", "Avenida Primavera 606", 357159852),
                new Persona(11, "Valeria", "Ruiz", new DateTime(1986, 3, 30), "isaac.jpg", "Boulevard Sur 707", 654987321),
                new Persona(12, "Jorge", "Ortega", new DateTime(1991, 8, 1), "isaac.jpg", "Calle Otoño 808", 753951456),
                new Persona(13, "Paula", "Morales", new DateTime(1983, 12, 25), "isaac.jpg", "Avenida Invierno 909", 159753468),
                new Persona(14, "Andrés", "Mendoza", new DateTime(1998, 7, 7), "isaac.jpg", "Camino Verde 1001", 321654987),
                new Persona(15, "Camila", "Ramos", new DateTime(1996, 5, 18), "isaac.jpg", "Jardines del Sur 1111", 456789123),
                new Persona(16, "Sebastián", "Cruz", new DateTime(1989, 1, 12), "isaac.jpg", "Paseo de la Paz 1212", 789456123),
                new Persona(17, "Fernanda", "Jiménez", new DateTime(1994, 6, 22), "isaac.jpg", "Colinas del Este 1313", 123789456),
                new Persona(18, "Rodrigo", "Álvarez", new DateTime(1992, 10, 10), "isaac.jpg", "Centro Histórico 1414", 654123789),
                new Persona(19, "Natalia", "Vega", new DateTime(1990, 11, 25), "isaac.jpg", "Rincones de Luz 1515", 987321654),
                new Persona(20, "Gabriel", "Pardo", new DateTime(1987, 4, 3), "isaac.jpg", "Puerta del Cielo 1616", 321987654)
            };

            return personas;
        }
    }
}
