namespace Solid.ISP
{
    public class Notebook : IComputer, IPortableComputer
    {
        public void Action()
        {
            System.Console.WriteLine("Notebook işlem yapıyor");
        }

        public void Move()
        {
            System.Console.WriteLine("Notebook taşınabilir");
        }

        public void Run()
        {
            System.Console.WriteLine("Notebook açıldı.");
        }

        public void Stop()
        {
            System.Console.WriteLine("Notebook kapanıyor");
        }
    }
}