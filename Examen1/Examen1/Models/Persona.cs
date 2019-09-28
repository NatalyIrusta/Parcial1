using System.ComponentModel.DataAnnotations;

namespace Examen1.Models
{
    public enum TypeLastname
    {
        Ingrid,
        Ivan,
        Irusta,
        Iriarte,
        Ilda,

    }
    public class Persona
    {
        [Key]
        public int Friendly { get; set; }
        [Required]
        public string Name { get; set; }

        public TypeLastname List { get; set; }
        [Required]
        public string Email { get; set; }

        public int Birthdate { get; set; }
    }
}
