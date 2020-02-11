using System.ComponentModel;

namespace PocGraphicQL.Domain.Model
{
    public enum BankAccountType : byte
    {
        [Description("Conta Corrente")]
        CurrentAccount = 0,

        [Description("Conta Poupança")]
        SavingsAccount = 1
    }
}
