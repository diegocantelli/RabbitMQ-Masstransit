using MassTransitTutorial.Domain.Customer;
using System.Threading.Tasks;

namespace MassTransitTutorial.Domain
{
    public interface ICustomerRepository
    {
        Task<CustomerEntity> WithId(CustomerId customerId);
        Task<CustomerEntity> CreateCustomer(NewCustomer customer);
        Task ChangeBirthDate(CustomerEntity customer);
    }
}