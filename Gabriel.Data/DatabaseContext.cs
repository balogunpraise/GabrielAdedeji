using Gabriel.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Gabriel.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
                    
        }
        public DbSet<Sheet> Sheets { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
