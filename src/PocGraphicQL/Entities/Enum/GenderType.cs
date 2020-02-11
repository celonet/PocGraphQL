using System.ComponentModel;

namespace PocGraphicQL.Domain.Model
{
    public enum GenderType
    {
        [Description("Masculino")]
        Male = 0,

        [Description("Feminino")]
        Female = 1
    }
}
