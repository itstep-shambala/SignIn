using System;
using Logging;
namespace Registration
{
    public class RegUser
    {
        Log log = new Log();
        public bool PasswordVerification (string password, string passwordCheck)
        {
            if (password == passwordCheck)
            {
                log.Success("Пароли совпадают");
                return true;
            }
            log.Error("Пароли не совпадают");
            return false;
        }
    }
}

