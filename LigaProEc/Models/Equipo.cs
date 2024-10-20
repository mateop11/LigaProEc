using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Equipo
{
    [Key]
    public int EquipoId { get; set; }

    [Required]
    public string Nombre { get; set; }

    public string Ciudad { get; set; }

    public int Titulos { get; set; }

    public bool AceptaExtranjeros { get; set; }

    public int EstadioId { get; set; }

    public Estadio Estadio { get; set; }

    public ICollection<Jugador> Jugadores { get; set; }
}
