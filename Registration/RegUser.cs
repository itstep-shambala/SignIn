using System;
namespace Registration
{
    public class RegUser
    {
        public bool PasswordVerification (string password, string passwordCheck)
        {
            if (password == passwordCheck)
            {
                return true;
            }
            return false;
        }
    }
}

