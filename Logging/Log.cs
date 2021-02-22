using System;
using System.IO;
using System.Security;

namespace Logging
{
    public class Log
    {
        private readonly string _path;

        public Log()
        {
            _path = "SignIn.log";
        }

        public Log(string path)
        {
            _path = path;
        }
        private void WriteToFile(string mes)
        {
            try
            {
                using var file = new StreamWriter(_path, true);
                file.WriteLine(mes);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Отказано в доступе");
            }
            catch (ArgumentException)
            {
                Console.WriteLine(
                    "Параметр path пуст или path содержит имя системного устройства (com1, com2 и т. д.).");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Указан недопустимый путь (например, он ведет на несопоставленный диск)");
            }
            catch (IOException)
            {
                Console.WriteLine("Параметр path включает неверный или недопустимый синтаксис имени файла, имени каталога или метки тома");
            }
            catch (SecurityException)
            {
                Console.WriteLine("У вызывающего объекта отсутствует необходимое разрешение");
            }
        }
        public void Info(string message)
        {
            var msg = DateTime.Now.ToString("G") + " [INFO] : " + message;
            WriteToFile(msg);
        }
        public void Error(string message)
        {
            var msg = DateTime.Now.ToString("G") + " [ERROR] : " + message;
            WriteToFile(msg);
        }
        public void Success(string message)
        {
            var msg = DateTime.Now.ToString("G") + " [SUCCESS] : " + message;
            WriteToFile(msg);
        }
    }
}
