using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_KPZ
{
    using System;

    // Інтерфейси для девайсів

    interface ILaptop
    {
        void ShowInfo();
    }

    interface INetbook
    {
        void ShowInfo();
    }

    interface IEBook
    {
        void ShowInfo();
    }

    interface ISmartphone
    {
        void ShowInfo();
    }

    // Інтерфейс для Фабрики

    interface IDeviceFactory
    {
        ILaptop CreateLaptop();
        INetbook CreateNetbook();
        IEBook CreateEBook();
        ISmartphone CreateSmartphone();
    }

    // Реалізація девайсів для бренду IProne

    class IProneLaptop : ILaptop
    {
        public void ShowInfo()
        {
            Console.WriteLine("IProne Laptop: стильний і потужний");
        }
    }

    class IProneNetbook : INetbook
    {
        public void ShowInfo()
        {
            Console.WriteLine("IProne Netbook: легкий і зручний");
        }
    }

    class IProneEBook : IEBook
    {
        public void ShowInfo()
        {
            Console.WriteLine("IProne EBook: для справжніх книголюбів");
        }
    }

    class IProneSmartphone : ISmartphone
    {
        public void ShowInfo()
        {
            Console.WriteLine("IProne Smartphone: топовий телефон");
        }
    }

    // Фабрика девайсів для IProne

    class IProneFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new IProneLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new IProneNetbook();
        }

        public IEBook CreateEBook()
        {
            return new IProneEBook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone();
        }
    }

    // Аналогічно створимо ще один бренд: Kiaomi

    class KiaomiLaptop : ILaptop
    {
        public void ShowInfo()
        {
            Console.WriteLine("Kiaomi Laptop: бюджетно, але надійно");
        }
    }

    class KiaomiNetbook : INetbook
    {
        public void ShowInfo()
        {
            Console.WriteLine("Kiaomi Netbook: компактний і дешевий");
        }
    }

    class KiaomiEBook : IEBook
    {
        public void ShowInfo()
        {
            Console.WriteLine("Kiaomi EBook: ідеально для PDF");
        }
    }

    class KiaomiSmartphone : ISmartphone
    {
        public void ShowInfo()
        {
            Console.WriteLine("Kiaomi Smartphone: хороша ціна і якість");
        }
    }

    class KiaomiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop() => new KiaomiLaptop();
        public INetbook CreateNetbook() => new KiaomiNetbook();
        public IEBook CreateEBook() => new KiaomiEBook();
        public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
    }

    // Тест програми

    class Program
    {
        static void Main(string[] args)
        {
            // Обираємо бренд
            Console.WriteLine("Створюємо девайси IProne:");
            IDeviceFactory iProneFactory = new IProneFactory();
            var iLaptop = iProneFactory.CreateLaptop();
            var iPhone = iProneFactory.CreateSmartphone();
            iLaptop.ShowInfo();
            iPhone.ShowInfo();

            Console.WriteLine("\nСтворюємо девайси Kiaomi:");
            IDeviceFactory kiaomiFactory = new KiaomiFactory();
            var kNetbook = kiaomiFactory.CreateNetbook();
            var kEBook = kiaomiFactory.CreateEBook();
            kNetbook.ShowInfo();
            kEBook.ShowInfo();
        }
    }
}
