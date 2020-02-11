namespace PocGraphicQL.Domain.Model
{
    public class Address
    {
        public string PostalCode { get; }
        public string StreetName { get; }
        public string AddressNumber { get; }
        public string Complement { get; }
        public string Neighborhood { get; }
        public string City { get; }
        public string StateCode { get; }
        public string CountryCode { get; }
        public AddressType Type { get; }
    }
}
