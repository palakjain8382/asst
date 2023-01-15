using System.ComponentModel.DataAnnotations;
namespace FreeCodeCamp.Models
{
    public class DobValidation : ValidationAttribute
    {

        int MinAge = 18, MaxAge = 80;
        int age = 0;

        public override bool IsValid(object? value)
        {
            age = DateTime.Now.Year - Convert.ToDateTime(value).Year;
            if (age >= MinAge && age <= MaxAge)
                return true;/*IsValid(value, null!) == ValidationResult.Success*/;
            return false;
        }
    }
}
        
