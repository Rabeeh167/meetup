using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<AppUser> Users {get; set;} // Users willbe name of table, id, name will be columns, id willbe primary key by default
}

