using GraphQL.Types;
using PocGraphicQL.Domain.Model;

namespace PocGraphicQL.GraphQL.Types
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Name = "Customer";
            Field(t => t.Id, type: typeof(IdGraphType));
            Field(t => t.NickName);
            Field(t => t.Photo);
            Field(t => t.CustomerId);
            Field(t => t.BirthDate);
            Field<GenderTypeEnumType>("Gender", "the type of gender");
            Field(t => t.BankAccount, type: typeof(ListGraphType<BankAccountType>));
            Field(t => t.Address, type: typeof(ListGraphType<AddressType>));
        }
    }
}
