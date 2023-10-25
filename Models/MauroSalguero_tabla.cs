using System.ComponentModel.DataAnnotations;

namespace MauroSalguero_1P.Models
{
    public class MauroSalguero_tabla
    {
        [Key]
        [Required(ErrorMessage = "Debe contener un nombre")]
        [Display(Name = "Nombre")]
        [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "Solo se aceptan caracteres alfanumericos")]
        public string? msName { get; set; }
        [Display(Name = "Cedula")]
        [MaxLength(10, ErrorMessage = "No debe superar los 10 digitos")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Solo se aceptan caracteres numericos")]
        public string msID { get; set; }
        [Display(Name = "Es estudiante Udla?")]
        [Required]
        public bool msUdlaStudent { get; set; }
        [Display(Name = "Edad")]
        [Range(10, 100, ErrorMessage = "Edad Invalida")]
        public decimal msEdad { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.DateTime)]
        public DateTime msDateOfBirth { get; set; }
        [Display(Name = "Promedio")]
        [Range(0, 10, ErrorMessage = "Debe estar entre 0(cero) y 10(diez)")]
        public decimal msGrade { get; set; }




    }
}
