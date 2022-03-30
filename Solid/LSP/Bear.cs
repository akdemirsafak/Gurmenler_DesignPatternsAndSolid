using System;
namespace Solid.LSP
{
    public class Bear : IAnimal
    {
        public void Walk()
        {
            Console.WriteLine("Bear walking");
        }
        public void Stop()
        {
            Console.WriteLine("Bear Stoped");
        }
    }
}

