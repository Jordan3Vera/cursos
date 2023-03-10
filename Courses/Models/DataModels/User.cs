using System.ComponentModel.DataAnnotations;

namespace Courses.Models.DataModels
{
    public class User :  BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(280)]
        public string Descripcion_Corta { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Descripcion_larga { get; set; } = string.Empty;

        public string Publico_objetivo { get; set; } = string.Empty;

        public string Objetivos { get; set; } = string.Empty;

        [Required]
        public string Requisitos { get; set; } = string.Empty;

        [Required]
        public string Nivel { get; set; } = string.Empty;
    }
}
