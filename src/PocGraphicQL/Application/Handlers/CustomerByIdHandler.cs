using MediatR;
using PocGraphicQL.Application.Queries;
using PocGraphicQL.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace PocGraphicQL.Application.Handlers
{
    public class CustomerByIdHandler : IRequestHandler<CustomerByIdQuery, Response>
    {
        private readonly ICustomerRepository _repository;

        public CustomerByIdHandler(ICustomerRepository repository) => _repository = repository;

        public async Task<Response> Handle(CustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetCustomer(request.CustomerId);
            return new Response(customer);
        }
    }
}
