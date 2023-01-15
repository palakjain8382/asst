using FreeCodeCamp.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Web.Helpers;

namespace FreeCodeCamp.Models
{

    public class EmailExists : ValidationAttribute
    {
        public override bool IsValid(object? email)
        {
            //IEnumerable<Login> objUsersList = _db.GemUserDetails;
            //var IsCheck = objUsersList.Email.FirstOrDefault(e => e.Email == (string)value) == null; 

            //return IsCheck != null; 
            return true;
        }
    }
}
