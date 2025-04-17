using System;
using lab_2_KPZ_ex3.lab2;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пробуємо отримати кілька екземплярів
            var auth1 = Authenticator.Instance;
            var auth2 = Authenticator.Instance;

            Console.WriteLine($"Об'єкти однакові: {auth1 == auth2}"); // true

            // Перевіримо авторизацію
            auth1.Authenticate("admin", "1234");
            auth2.Authenticate("user", "pass");
        }
    }
}
