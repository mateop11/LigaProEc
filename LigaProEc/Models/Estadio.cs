using System.ComponentModel.DataAnnotations;

public class Estadio
{
    [Key]
    public int EstadioId { get; set; }

    [Required]
    public string Direccion { get; set; }

    public string Ciudad { get; set; }

    public int Capacidad { get; set; }

    public Equipo Equipo { get; set; }
}
