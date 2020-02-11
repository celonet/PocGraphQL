namespace PocGraphicQL.Domain.Model
{
    public class Phone
    {
        public int CountryCode { get; }
        public int AreaCode { get; }
        public int PhoneNumber { get; }
        public PhoneType Type { get; }

    }
}
