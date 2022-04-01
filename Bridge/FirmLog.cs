namespace Bridge
{
    public class FirmLog : ILogWriter
    {
        public void LogWrite()
        {
            System.Console.WriteLine("Firma log");
        }
    }
}