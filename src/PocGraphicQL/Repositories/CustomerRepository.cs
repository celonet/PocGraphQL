using Dapper;
using Microsoft.Extensions.Configuration;
using PocGraphicQL.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocGraphicQL.Repositories
{
    public class CustomerRepository : Repository, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration)
            : base(configuration) { }

        public async Task<Customer> GetCustomer(string customerId)
        {
            Customer personalInfo = null;

            try
            {
                var query = @"
                    select * from customer where customerId = @customerId;
                    select * from bankaccount where customerId = @customerId;
                    select * from address where customerId = @customerId;
                ";

                using (var connection = CreateConnection())
                {
                    var result = await Connection
                                            .QueryMultipleAsync(query, new { customerId });

                    personalInfo = result.Read<Customer>().FirstOrDefault();
                    personalInfo.BankAccount = result.Read<BankAccount>().ToList();
                    personalInfo.Address = result.Read<Address>().ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return personalInfo;
        }
    }
}
