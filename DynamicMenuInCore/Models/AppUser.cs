using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DynamicMenuInCore.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [StringLength(50)]
        public string? MiddleName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        public string? ProfileImage { get; set; }
    }
}
