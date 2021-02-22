using System;
using Authorization;
using Logging;

namespace SignIn
{
    internal static class Program
    {
        static void ShowSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.ResetColor();
        }

        static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
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
            authorization.Success += log.Success;
            authorization.Error += log.Error;
            
            authorization.Success += ShowSuccess;
            authorization.Error += ShowError;
            
            authorization.Login(login, password);
        }
    }
}
