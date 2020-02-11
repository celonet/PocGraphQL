using GraphQL.Types;
using PocGraphicQL.GraphQL.Types;
using PocGraphicQL.Repositories;

namespace PocGraphicQL.GraphQL
{
    public class CustomerQuery : ObjectGraphType
    {
        public CustomerQuery(ICustomerRepository repository)
        {
            Field<CustomerType>(
                "customer",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "customerId" }),
                resolve: context =>
                {
                    var customerId = context.GetArgument<string>("customerId");
                    return repository.GetCustomer(customerId);
                }
            );
        }
    }
}
