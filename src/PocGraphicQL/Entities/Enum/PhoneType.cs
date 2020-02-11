using System.ComponentModel;

namespace PocGraphicQL.Domain.Model
{
    public enum PhoneType : byte
    {
        [Description("Telefone Residencial")]
        Residential = 0,

        [Description("Telefone Comercial")]
        Commercial = 1,

        [Description("Telefone Celular")]
        Cellphone = 2
    }
}
