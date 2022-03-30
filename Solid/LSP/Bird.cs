namespace Solid.LSP
{
    public class Bird : IAnimal
    {
        public void Stop()
        {
            System.Console.WriteLine("Bird Stoped");
        }

        public void Walk()
        {
            System.Console.WriteLine("Bird Walking");
        }
        public void Fly()
        {
            System.Console.WriteLine("Bird Fly");
        }
    }
}