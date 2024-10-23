using System;

namespace ProyectoBibliotecaFrontend.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        // Relaciones con otras entidades
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int Libro_Id { get; set; }
        public Libro Libro { get; set; }

        // Atributos de préstamo
        public string Status { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }  // FechaDevolucion puede ser nula si aún no se ha devuelto
        public string Encargado { get; set; }
    }
}
