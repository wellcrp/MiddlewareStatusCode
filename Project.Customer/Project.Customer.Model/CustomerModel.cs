namespace Project.Customer.Model
{
    public class CustomerModel
    {
        public CustomerModel(int customerId, string customerName, string customerEmail)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
    }
}
