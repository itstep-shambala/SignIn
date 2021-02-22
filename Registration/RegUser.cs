namespace Registration
{
    public delegate void Message(string message);
    public class RegUser
    {
        public event Message Error;
        public event Message Success;
        public bool PasswordVerification (string password, string passwordCheck)
        {
            if (password == passwordCheck)
            {
                Success?.Invoke("Пароли совпадают");
                return true;
            }
            Error?.Invoke("Пароли не совпадают");
            return false;
        }
    }
}

