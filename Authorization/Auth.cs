namespace Authorization
{
    public delegate void Message(string message);
    public class Auth
    {
        private string _login;
        private string _password;

        public event Message Success;
        public event Message Error;

        public bool Login(string login, string password)
        {
            if (_login == login && _password == password)
            {
                Success?.Invoke("Вход разрешён");
                return true;
            }
            Error?.Invoke("Вход запрещён");
            return false;
        }

        public Auth()
        {
            _login = "user";
            _password = "123";
        }
    }
}