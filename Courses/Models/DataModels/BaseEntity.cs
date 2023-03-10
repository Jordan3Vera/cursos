using System.ComponentModel.DataAnnotations;
using System;

namespace Courses.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string CreateBy { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string UpdateBy { get; set; } = string.Empty;

        public DateTime? UpdateAt { get; set; } = DateTime.Now;

        public string DeletedBy { get; set; } = string.Empty;

        public DateTime? DeletedAt { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;
    }
}
