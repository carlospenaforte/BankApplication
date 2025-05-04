using Microsoft.EntityFrameworkCore;
using BankApplication.Models;

namespace BankApplication.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<BankAccountModel> BankAccounts { get; set; }
        public DbSet<TransfersModel> BankTransactions { get; set; }
    }
}
