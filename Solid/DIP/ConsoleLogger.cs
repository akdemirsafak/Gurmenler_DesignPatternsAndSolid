namespace Solid.DIP
{
    public class ConsoleLogger : ILogger
    {

        public void Write()
        {
            System.Console.WriteLine("Console'a loglandı.");
        }
    }
}