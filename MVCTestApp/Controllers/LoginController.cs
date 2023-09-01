using Microsoft.AspNetCore.Mvc;
using MVCTestApp.BAL.Inferaces;
using MVCTestApp.Entities;
using MVCTestApp.Models;

namespace MVCTestApp.Controllers
{
    public class LoginController : Controller
    {
        private ILoginService _loginService;
        private ISignUpService _signUpService;
        public LoginController(ILoginService loginService, ISignUpService signUpService)
        {
            _loginService = loginService;
            _signUpService = signUpService;
        }


        

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var isValid = _loginService.Login(model.Username, model.Password);
                if (isValid)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(RegisterModel model)
        {
            if (ModelState.IsValid)

            {

                Login login = new Login() { Username = model.Username, Password = model.Password };

                var result = _signUpService.SignUp(login);
                if (result)
                    return RedirectToAction("SignIn");

            }

            return View();
        }

            public IActionResult LogOut()
            {
                return RedirectToAction("SingIn");
            }


        
    }
}

