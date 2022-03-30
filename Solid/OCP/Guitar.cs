namespace Solid.OCP
{
    public class Guitar : Voice
    {


        public override void MakeSound()
        {
            GuitarSound();
        }
        private void GuitarSound()
        {
            System.Console.WriteLine("Etude No.7");
        }
    }
}