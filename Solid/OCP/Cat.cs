namespace Solid.OCP
{
    public class Cat : Voice
    {
        public override void MakeSound()
        {
            CatSound();
        }

        private void CatSound()
        {
            System.Console.WriteLine("Meow");
        }
    }
}