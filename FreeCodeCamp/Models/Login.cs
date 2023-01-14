using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeCodeCamp.Models
{
    public class Login
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email format incorrect. Format: user@email.com")]
        [Required]
        public string? Email { get; set; }

        [Required]
        [DisplayName("Gender")]
        public string? Gender { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [DobValidation(ErrorMessage = "Age must be between 18 - 30")]
        [DisplayName("Date of Birth")]
        public string? DOB { get; set; }

        [StringLength(100, ErrorMessage = "Password \"{0}\" must have {2} character", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}$", ErrorMessage = "Password must contain: Minimum 8 characters atleast 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number and 1 Special Character")]
        [Required]
        [DataType(DataType.Password)]
        [DisplayName("Password")]
        public string? Password { get; set; }

        [NotMapped]
        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Please enter confirm password")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [DataType(DataType.Password)]
        public string Confirmpwd { get; set; }
    }
}
