namespace Bridge
{
    public class Customer : Log
    {
        public Customer(ILogWriter logWriter) : base(logWriter)
        {
        }
        public override void LogWrite()
        {
            System.Console.WriteLine("Customer Added");
            base.LogWrite();
        }
    }
}