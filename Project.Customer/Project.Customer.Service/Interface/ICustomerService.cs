using Project.Customer.Model;

namespace Project.Customer.Service.Interface
{
    public interface ICustomerService
    {
        Task<CustomerModel> GetCustomerAsync(int customerId);
        Task<string> GetCustomerEmptyAsync();
    }
}
