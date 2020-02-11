using System;
using System.Collections.Generic;

namespace PocGraphicQL.Domain.Model
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }

        public string NickName { get; set; }

        public IList<Phone> Phones { get; set; }

        public GenderType Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public IList<Address> Address { get; set; }

        public IList<BankAccount> BankAccount { get; set; }

        public string Photo { get; set; }

        public Customer()
        {
            Phones = new List<Phone>();
            Address = new List<Address>();
            BankAccount = new List<BankAccount>();
        }
    }
}
