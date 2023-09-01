using MVCTestApp.BAL.Inferaces;
using MVCTestApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.BAL.Services
{
    public class LoginService : ILoginService
    {
        private ILoginRepo _loginRepo;
        public LoginService(ILoginRepo loginRepo)
        {
            _loginRepo = loginRepo;
        }
         
        public bool Login(string username, string password)
        {
            var isValidUser = _loginRepo.CheckValidUser(username, password);
            return isValidUser;
        }
    }
}
