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
            var _db = (ApplicationDbContext)validationContext.GetService(typeof(ApplicationDbContext));

            string[]? memberNames = validationContext.MemberName is { } memberName
    ? new[] { memberName }
    : null;
            var result = ValidationResult.Success;

            foreach (var item in _db.GemUserDetails)
            {
                if (item.Email == email.ToString())
                   result = new ValidationResult(FormatErrorMessage(validationContext.DisplayName), memberNames);
                return result;
            }
            return ValidationResult.Success;
        }
    }
}
