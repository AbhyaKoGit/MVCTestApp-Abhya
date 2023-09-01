using System;
using MVCTestApp.Entities;

namespace MVCTestApp.BAL.Inferaces
{
	public interface ISignUpService
	{
     
            bool SignUp(Login model);
        
    }
}

