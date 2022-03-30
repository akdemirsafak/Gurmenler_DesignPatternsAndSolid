namespace Solid.SRP
{
    public class BargainService
    {
        public void Bargain(Customer customer)
        {
            Console.WriteLine($"{customer.Name} iyi pazarlık etti.");
        }
    }
}