namespace lab_3_KPZ
{
    class Program
    {
        static void Main()
        {
            // Використання звичайного логера
            ILogger logger = new ConsoleLogger();
            logger.Log("Система запущена");
            logger.Warn("Пам’ять майже заповнена");
            logger.Error("Критична помилка");

            // Використання логера через адаптер
            ILogger fileLogger = new FileLoggerAdapter(new FileWriter("log.txt"));
            fileLogger.Log("Запис у файл");
            fileLogger.Warn("Попередження у файл");
            fileLogger.Error("Помилка у файл");
        }
    }
}