namespace Bridge
{
    public class CustomerLog : ILogWriter
    {
        public void LogWrite()
        {
            System.Console.WriteLine("Customer Log writed");
        }
    }
}