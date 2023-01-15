using FreeCodeCamp.Data;
using FreeCodeCamp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace FreeCodeCamp.Controllers
{
    public class UserLoginController : Controller
    {
        private readonly ApplicationDbContext? _db;

        public UserLoginController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Login> objUsersList = _db.GemUserDetails;
            return View(objUsersList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //FORGOT PASSWORD
        //POST
        //[HttpPost]
        //[ValidateAntiForgeryToken]  //for cross site request forgery
        //public IActionResult Index(Login obj)
        //{
        //    if (ModelState.IsValid)
        //    {


        //        //_db.GemUserDetails.Add(obj);
        //        //_db.SaveChanges();
        //        //string email = obj.Email;
        //        //var pwd = PasswordEnc.pwdEncryption(obj.Password);
        //        //var user = _db.GemUserDetails.FirstOrDefault(x => x.Email == email);
        //        //if (user != null)
        //        //{
        //        //    int id = user.ID;
        //        //}


        //        TempData["success"] = "Check email for verification";
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);
        //}
    }
}