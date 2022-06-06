using System.ComponentModel.DataAnnotations;

public class Personas
{
    [Key]
    [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
    public int PersonaId { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el Nombre")]
    [MinLength(3, ErrorMessage = "El Nombre debe tener al menos {1} caractéres.")]
    [MaxLength(35, ErrorMessage = "El Nombre no debe pasar de {1} caractéres.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el Apellido")]
    [MinLength(3, ErrorMessage = "El Apellido debe tener al menos {1} caractéres.")]
    [MaxLength(35, ErrorMessage = "El Apellido no debe pasar de {1} caractéres.")]
    public string? Apellido { get; set; }  


    [Required(ErrorMessage = "Es obligatorio introducir la Direccion")]
    [MinLength(3, ErrorMessage = "La Direccion debe tener al menos {1} caractéres.")]
    [MaxLength(50, ErrorMessage = "La Direccion no debe pasar de {1} caractéres.")]
    public string? Direccion { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir el Telefono")]
    [MinLength(10, ErrorMessage = "El telefono debe tener al menos {1} caractéres.")]
    [MaxLength(15, ErrorMessage = "El telefono no debe pasar de {1} caractéres.")]
    [Phone]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "Se debe elegir un sexo")]
    public char Sexo { get; set; }

    [Required(ErrorMessage = "Se debe elegir un estado civil")]
    public string? EstadoCivil { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la Cedula")]
    [MinLength(10, ErrorMessage = "La Cedula debe tener al menos {1} caractéres.")]
    [MaxLength(20, ErrorMessage = "La Cedula no debe pasar de {1} caractéres.")]
    public string? Cedula { get; set; }

}