namespace Solid.SRP
{
    public class BuyService
    {
        public void Buy(Customer customer)
        {
            Console.WriteLine($"{customer.Name} satın aldı.");
        }
    }
}