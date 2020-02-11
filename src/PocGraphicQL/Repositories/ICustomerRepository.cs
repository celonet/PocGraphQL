using PocGraphicQL.Domain.Model;
using System.Threading.Tasks;

namespace PocGraphicQL.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomer(string customerId);
    }
}
