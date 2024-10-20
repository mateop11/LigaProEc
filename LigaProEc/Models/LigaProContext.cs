using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class LigaProContext : DbContext
{
    public DbSet<Equipo> Equipos { get; set; }
    public DbSet<Jugador> Jugadores { get; set; }
    public DbSet<Estadio> Estadios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=LigaProDb;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipo>()
            .HasOne(e => e.Estadio)
            .WithOne(e => e.Equipo)
            .HasForeignKey<Equipo>(e => e.EstadioId);

        modelBuilder.Entity<Jugador>()
            .HasOne(j => j.Equipo)
            .WithMany(e => e.Jugadores)
            .HasForeignKey(j => j.EquipoId);
    }
}
