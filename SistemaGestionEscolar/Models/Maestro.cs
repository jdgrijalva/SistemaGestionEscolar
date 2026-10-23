using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEscolar.Models
{
    public class Maestro
    {
        [Key]
        public int maestroId { get; set; }

        public string maestroNombre { get; set; } = "";

        public string maestroApellido { get; set; } = "";

        public string maestroEspecialidad { get; set; } = "";
    }
}