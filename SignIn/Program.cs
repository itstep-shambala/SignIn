using System;
using Authorization;

namespace SignIn
{
    internal static class Program
    {
        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++ Программа для авторизации и регистрации пользователей +++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ResetColor();
            
            Console.Write("Введите логин: ");
            var login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            var password = Console.ReadLine();

            var authorization = new Auth();
            var result = authorization.Login(login, password);
            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вход разрешён");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вход запрещён!");
                Console.ResetColor();
            }
        }
    }
}
