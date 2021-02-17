namespace Authorization
{
    public class Auth
    {
        private string _login;
        private string _password;

        public bool Login(string login, string password)
        {
            return _login == login && _password == password;
        }

        public Auth()
        {
            _login = "user";
            _password = "123";
        }
    }
}