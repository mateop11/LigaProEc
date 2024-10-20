using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Jugador
{
    [Key]
    public int JugadorId { get; set; }

    [Required]
    public string Nombre { get; set; }

    public string Posicion { get; set; }

    public int Edad { get; set; }

    public int EquipoId { get; set; }

    [ForeignKey("EquipoId")]
    public Equipo Equipo { get; set; }
}
