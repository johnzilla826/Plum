using Microsoft.EntityFrameworkCore;
using Plum.Models;

namespace Plum.Data;

public class PlumDbContext : DbContext
{  
    public PlumDbContext(DbContextOptions<PlumDbContext> options) : base(options) {}
    
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Split> Splits { get; set; }
}