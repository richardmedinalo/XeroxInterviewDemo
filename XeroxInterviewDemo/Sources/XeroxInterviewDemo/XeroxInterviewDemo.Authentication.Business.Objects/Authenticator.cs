using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XeroxInterviewDemo.Authentication.Business;

namespace XeroxInterviewDemo.Authentication.Business.Objects
{

    /// <summary>
    /// This is a simple authentication metbhod, we can ensure credentials are encrypted with (for instance) SHA2
    /// In addition we can store UserCredential in our database.
    /// This is demostrative only.
    /// </summary>
    public class Authenticator
    {
        public bool Authenticate (UserCredential userCredential)
        {
            if (userCredential.Username == "xerox" && userCredential.Password == "interviewdemo")
                return true;

            return false;
        }
    }
}
