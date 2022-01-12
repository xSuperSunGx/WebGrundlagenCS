using System;
using Microsoft.AspNetCore.Mvc;
using Web_Grundlagen.Models;

namespace Web_Grundlagen.Controllers
{
    public class UserController : Controller
    {
        // GET
        public IActionResult Index()
        {
            //einen User erzeugen un an die View übergeben, in der View sollen dann die Userdaten angezeigt werden

            User user = new User(1, "Noah","password123", new DateTime(2004, 4, 13),"noah.glatzl@gmail.com", Gender.MALE);
            
            return View(user);
        }
        public IActionResult Login()
        {
            return View();
        } 
        [HttpGet]
        public IActionResult Registration()
        {
            User u = new User();
            return View(u);
        }
        [HttpPost]
        public IActionResult Registration(User data)
        {
            
            //Parameter überprüfen
            if (data == null)
            {
                return RedirectToAction("Registration");
            }
            
            //Formulardaten überprüfen! (Validierung - serverseitig)
            ValidateRegistrationData(data);
            if (ModelState.IsValid)
            {
                return View("_Message", new Message("Registrierung", "Ihre Daten wurden erfolgreich abgespeichert"));
            }
            //TODO: in DB-Tabelle abspeichern
            
            //falls die Validierung nicht erfolgreich war, wird das Formular mit den eingegeben Daten gefüllt werden.
            return View(data);
        }

        private void ValidateRegistrationData(User u)
        {
            if (u == null)
            {
                return;
            }

            if (u.Username.Trim().Length < 3)
            {
                ModelState.AddModelError("Username", "Der Benutzername muss mind. 3 Zeichen lang sein!");
            }

            if (u.Passsword.Length < 8)
            {
                ModelState.AddModelError("Passsword", "Das Passwort muss mindestens 8 Zeichen lang sein!");
            }

            if (!(u.Birthdate < DateTime.Now))
            {
                ModelState.AddModelError("Birthdate", "Dein Geburtstag muss in der Vergangenheit liegen!");
            }
        }
        
    }
}