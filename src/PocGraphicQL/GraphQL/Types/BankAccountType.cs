using GraphQL.Types;
using PocGraphicQL.Domain.Model;

namespace PocGraphicQL.GraphQL.Types
{
    public class BankAccountType : ObjectGraphType<BankAccount>
    {
        public BankAccountType()
        {
            Field(t => t.BankNumber);
            Field(t => t.AccountNumber);
            Field(t => t.AgencyNumber);
        }
    }
}
