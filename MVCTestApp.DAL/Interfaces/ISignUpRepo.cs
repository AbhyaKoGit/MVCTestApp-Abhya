using System;
using MVCTestApp.Entities;

namespace MVCTestApp.DAL.Interfaces
{

        public interface ISignUpRepo
        {
        bool SaveNewUser(Login model);
        }
   
}

