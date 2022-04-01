namespace Facade
{
    public class Order
    {
        protected Product _product;
        protected Payment _payment;
        protected Invoice _invoice;
        public Order()
        {
            _product = new Product();
            _payment = new Payment();
            _invoice = new Invoice();
        }
        public void Methods()
        {
            System.Console.WriteLine("Methods");
            _product.GetProductDetails();
            _invoice.SendInvoice();
            _invoice.CreateInvoice();
            _payment.MakePayment();

        }
        public void ProductDetailsShow()
        {
            _product.GetProductDetails();
        }

    }
}