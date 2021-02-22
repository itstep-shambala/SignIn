using System;
using System.IO;
using System.Security;

namespace Logging
{
    public class Log
    {
        private readonly string path;

        public Log()
        {
            path = "SignIn.log";
        }
        private void WriteToFile(string mes)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(mes);
                }
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
       
    }
}
