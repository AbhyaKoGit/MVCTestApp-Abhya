using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.DAL.Interfaces
{
    public interface ILoginRepo
    {
        bool CheckValidUser(string username, string password);
    }
}
