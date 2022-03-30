namespace Solid.DIP
{
    public class DbLogger : ILogger
    {

        public void Write()
        {
            System.Console.WriteLine("Database'e loglandı.");
        }
    }
}