using Microsoft.EntityFrameworkCore;

public class SistemaGestionEscolarContext(DbContextOptions<SistemaGestionEscolarContext> options) : DbContext(options)
{
    public DbSet<SistemaGestionEscolar.Models.Estudiante> Estudiante { get; set; } = default!;
    public DbSet<SistemaGestionEscolar.Models.Maestro> Maestro { get; set; } = default!;
    public DbSet<SistemaGestionEscolar.Models.Aula> Aula { get; set; } = default!;
    public DbSet<SistemaGestionEscolar.Models.Libro> Libros { get; set; } = default!;


}
