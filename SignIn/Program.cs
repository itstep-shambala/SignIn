using System;
using Authorization;
using Logging;

namespace SignIn
{
    internal static class Program
    {
        private static void Main()
        {
            var log = new Log();
            log.Info("Программа запустилась");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+++ Программа для авторизации и регистрации пользователей +++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ResetColor();
            
            Console.Write("Введите логин: ");
            var login = Console.ReadLine();
            log.Info("Введён логин");
            Console.Write("Введите пароль: ");
            var password = Console.ReadLine();
            log.Info("Введён пароль");

            var authorization = new Auth();
            var result = authorization.Login(login, password);
            if (result)
            {
                log.Success("Вход разрешён");
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Вход разрешён");
                Console.ResetColor();
            }
            else
            {
                log.Error("Вход запрещён");
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вход запрещён!");
                Console.ResetColor();
            }
        }
    }
}
