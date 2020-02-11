using GraphQL;
using GraphQL.Types;

namespace PocGraphicQL.GraphQL
{
    public class CustomerSchema : Schema
    {
        public CustomerSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<CustomerQuery>();
        }
    }
}
