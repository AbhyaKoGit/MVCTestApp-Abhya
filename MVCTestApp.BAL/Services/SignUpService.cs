using MVCTestApp.BAL.Inferaces;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.BAL.Services
{

    public class SignUpService : ISignUpService
    {
        private ISignUpRepo _signupRepo;
        public SignUpService(ISignUpRepo signupRepo)
        {
            _signupRepo = signupRepo;
        }

        public bool SignUp(Login model)
        {
            return _signupRepo.SaveNewUser(model);

        }
    }
}

