using FIAP_MVC.Data;
using FIAP_MVC.DTOs;
using Microsoft.AspNetCore.Mvc;
using FIAP_MVC.Models;

namespace FIAP_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Register(RegisterDTO request)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.UserEmail==request.UserEmail);
            if (user != null)
            {
                return BadRequest("Usuário já existe");
            }

            User NewUser = new User
            {
                UserEmail = request.UserEmail,
                UserPassword = request.UserPassword
            };
            _dataContext.Add(NewUser);
            _dataContext.SaveChanges();
            return View();
        }
        
        public IActionResult Login(LoginDTO request)
        {
            var find = _dataContext.Users.FirstOrDefault(x => x.UserEmail == request.UserEmail);
            if (find == null)
            {
                return NotFound();
            }

            if (find.UserPassword != request.UserPassword)
            {
                return BadRequest("Senha inválida");
            }

            ViewBag.userData = find;
            return View(find);
        }

        
    }
}