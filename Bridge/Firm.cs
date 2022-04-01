namespace Bridge
{
    public class Firm : Log
    {
        public Firm(ILogWriter logWriter) : base(logWriter)
        {
        }
        public override void LogWrite()
        {
            System.Console.WriteLine("Firm added");
            base.LogWrite();
        }
    }
}