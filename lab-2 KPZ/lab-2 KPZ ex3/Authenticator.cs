using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_KPZ_ex3
{
    using System;

    namespace lab2
    {
        // Патерн Singleton. Singleton: один контролер на весь проєкт
        public sealed class Authenticator
        {
            // Статичне поле, яке містить єдиний екземпляр
            private static readonly Lazy<Authenticator> _instance =
                new Lazy<Authenticator>(() => new Authenticator());

            // Приватний конструктор — забороняє створення об'єктів ззовні
            private Authenticator()
            {
                Console.WriteLine("Authenticator створено.");
            }

            // Публічна властивість для отримання екземпляру
            public static Authenticator Instance
            {
                get
                {
                    return _instance.Value;
                }
            }

            // Метод авторизації
            public void Authenticate(string username, string password)
            {
                //перевірка
                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Авторизація успішна!");
                }
                else
                {
                    Console.WriteLine("Невірні дані.");
                }
            }
        }
    }

}
