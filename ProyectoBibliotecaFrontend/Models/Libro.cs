namespace ProyectoBibliotecaFrontend.Models
{
    public class Libro
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Publicacion { get; set; }

        // Relaciones con otras entidades
        public int Autor_Id { get; set; }
        public Autor Autor { get; set; }

        public int EditorialId { get; set; }
        public Editorial Editorial { get; set; }

        public int Categoria_Id { get; set; }
        public Categoria Categoria { get; set; }
    }
}
