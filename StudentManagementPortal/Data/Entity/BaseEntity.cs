using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace StudentManagementPortal.Data.Entity
{
    public class BaseEntity
    {
        [Required]
        [NotNull]
        public Guid Id { get; set; }      
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
