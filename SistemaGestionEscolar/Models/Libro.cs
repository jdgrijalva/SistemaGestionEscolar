using System.ComponentModel.DataAnnotations;
namespace SistemaGestionEscolar.Models
{
    public class Libro
    {
        [Key] public int libroId { get; set; }
        public string libroTitulo { get; set; } = "";
        public string libroAutor { get; set; } = "";
        public int libroAnioPublicacion { get; set; }
    }
}
