namespace Solid.ISP
{
    public class DesktopPc : IComputer
    {
        public void Action()
        {
            System.Console.WriteLine("Bilgisayar işlem yapıyor");
        }

        public void Run()
        {
            System.Console.WriteLine("Bilgisayar çalıştırılıyor");
        }

        public void Stop()
        {
            System.Console.WriteLine("Bilgisayar kapanıyor");
        }
    }
}