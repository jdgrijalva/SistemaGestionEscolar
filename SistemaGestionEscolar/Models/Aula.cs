
using System.ComponentModel.DataAnnotations;

namespace SistemaGestionEscolar.Models
{
    public class Aula
    {
        [Key]
        public int aulaId { get; set; }

        public string aulaNombre { get; set; } = "";

        public int aulaCapacidad { get; set; }
    }
}
