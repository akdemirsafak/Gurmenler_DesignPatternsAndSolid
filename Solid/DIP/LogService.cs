namespace Solid.DIP
{
    public class LogService
    {
        private readonly ILogger logger;
        public LogService(ILogger _logger)
        {
            _logger = logger;
        }
        public void Handle()
        {
            /*
                Burada logger ile çalışacağız 
                fakat parametre olarak verilen Console veya DbLogger çalışacak.
                İleride farklı bir Loglama sistemiyle çalışmak istersek 
                tek bir yerden değiştirmek yeterli olacak.
            */
        }

    }
}