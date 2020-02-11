using MediatR;

namespace PocGraphicQL.Application.Queries
{
    public class CustomerByIdQuery : IRequest<Response>
    {
        public string CustomerId { get; private set; }

        public CustomerByIdQuery(string customerId) => CustomerId = customerId;
    }
}
