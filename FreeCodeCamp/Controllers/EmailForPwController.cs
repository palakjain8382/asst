using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using NuGet.Protocol.Core.Types;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using System;
using FreeCodeCamp.Data;
using FreeCodeCamp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;

namespace FreeCodeCamp.Controllers
{
    public class EmailForPwController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmailForPwController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult sendEmailForPw(string? email)
        {

            try
            {
                var fromAddress = new MailAddress("palakjain838207@gmail.com", "From Name");
                var toAddress = new MailAddress(email!, "To Name");
                const string fromPassword = "cpdsvxddzqpfjqed";
                const string subject = "Welcome Mail";
                const string body = "Hi! Your account has successfully created.";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                };
                smtp.Send(message);
            }
            catch (SmtpException)
            {
                // handle error
            }
            return View();
        }

    }
}
