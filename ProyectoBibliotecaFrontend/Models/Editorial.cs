namespace ProyectoBibliotecaFrontend.Models
{
    public class Editorial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Nuevas propiedades
        public string Pais { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
