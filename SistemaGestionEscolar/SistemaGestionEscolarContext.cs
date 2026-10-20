using Microsoft.EntityFrameworkCore;

public class SistemaGestionEscolarContext(DbContextOptions<SistemaGestionEscolarContext> options) : DbContext(options)
{
    public DbSet<SistemaGestionEscolar.Models.Estudiante> Estudiante { get; set; } = default!;
}
