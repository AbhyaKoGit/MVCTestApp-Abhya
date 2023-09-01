using System;
using MVCTestApp.DAL.DataContext;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.Entities;

namespace MVCTestApp.DAL.Services
{
	
        public class SignupRepo : ISignUpRepo
        {
            private DbDataContext _dbDataContext;

            public SignupRepo(DbDataContext dbDataContext)
            {
                _dbDataContext = dbDataContext;
            }

            public bool SaveNewUser(Login model)
            {
                try
                {
                    _dbDataContext.Login.Add(model);
                    _dbDataContext.SaveChanges();

                    return true;

                }
                
                catch
                {
                    return false;

                }

            }
        }
    
}

