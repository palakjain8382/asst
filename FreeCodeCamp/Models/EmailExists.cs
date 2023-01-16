using FreeCodeCamp.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Web.Helpers;

namespace FreeCodeCamp.Models
{
    public class EmailExists : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? email, ValidationContext validationContext)
        {
            var _db = (ApplicationDbContext)validationContext.GetService(typeof(ApplicationDbContext))!;

            foreach (var item in _db.GemUserDetails)
            {
                if (item.Email == email?.ToString())
                    return new ValidationResult("Email already exist!");
            }
            return ValidationResult.Success;
        }
    }
}