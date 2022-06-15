using Project.Customer.Model;
using Project.Customer.Service.Interface;

namespace Project.Customer.Service
{
    public class CustomerService : ICustomerService
    {
        public Task<CustomerModel> GetCustomerAsync(int customerId)
        {
           return Task.FromResult(new CustomerModel(1, "Wellington", "wellcrp@gmail.com"));
        }

        public Task<string> GetCustomerEmptyAsync()
        {
            var customer = new CustomerModel(0, String.Empty, String.Empty);

            var result = customer.CustomerEmail.Where(x => x.Equals("Não existe")).FirstOrDefault().ToString();

            return Task.FromResult(result);
        }
    }
}
