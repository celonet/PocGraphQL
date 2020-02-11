using System.ComponentModel;

namespace PocGraphicQL.Domain.Model
{
    public enum AddressType : byte
    {
        None = 0,
        [Description("Endereço Residencial")]
        Residential = 1,

        [Description("Endereço Comercial")]
        Commercial = 2
    }
}
