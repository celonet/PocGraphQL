using GraphQL.Types;
using PocGraphicQL.Domain.Model;

namespace PocGraphicQL.GraphQL.Types
{
    public class AddressType : ObjectGraphType<Address>
    {
        public AddressType()
        {
            Field(t => t.StateCode);
            Field(t => t.Neighborhood);
            Field(t => t.CountryCode);
            Field(t => t.Complement);
            Field(t => t.City);
            Field(t => t.StreetName);
            Field(t => t.AddressNumber);
            //Field<AddressTypeEnumType>("AdressType", "type of adress");
        }
    }
}
