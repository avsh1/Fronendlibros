﻿namespace ProyectoBibliotecaFrontend.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public string FechaRegistro { get; set; }
        public bool Estado { get; set; }

    }
}