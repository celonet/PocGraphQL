using System;

namespace PocGraphicQL.Domain.Model
{
    public class BankAccount
    {
        public int BankNumber { get; }
        public string AgencyNumber { get; }
        public string VerifyingDigitAgency { get; }
        public string AccountNumber { get; }
        public string VerifyingDigitAccount { get; }
        public bool MainBankAccount { get; }
        public BankAccountType BankAccountType { get; }
        public DateTime CreationDate { get; }
    }
}
