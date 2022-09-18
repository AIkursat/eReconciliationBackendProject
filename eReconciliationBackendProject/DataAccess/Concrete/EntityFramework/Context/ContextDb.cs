using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class ContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KURSAT\MSSQLSERVER01;Database=eReconciliationDb;Integrated Security=True");
        }

        public DbSet<AccountReconciliationDetail> accountReconciliationDetails { get; set; }
        public DbSet<AccountReconciliations> AccountReconciliations { get; set; }
        public DbSet<BaBsReconciliation> baBsReconciliations { get; set; }
        public DbSet<BaBsReconciliationDetail> BaBsReconciliationDetails { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Currency> currencies { get; set; }
        public DbSet<CurrencyAccount> currencyAccounts { get; set; }
        public DbSet<MailParameter> mailParameters { get; set; }
        public DbSet<OperationClaim> operationClaims { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserCompany> userCompanies { get; set; }
        public DbSet<UserOperationClaim> userOperationClaims { get; set; }
    }
}
