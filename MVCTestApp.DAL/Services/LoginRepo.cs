using MVCTestApp.DAL.DataContext;
using MVCTestApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.DAL.Services
{
    public class LoginRepo : ILoginRepo
    {
        private DbDataContext _dbDataContext;

        public LoginRepo(DbDataContext dbDataContext)
        {
            _dbDataContext = dbDataContext;
        }

        public bool CheckValidUser(string username, string password)
        {
            try
            {
                var result = _dbDataContext.Login.FirstOrDefault(x => x.Username == username && x.Password == password);
                if (result == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
