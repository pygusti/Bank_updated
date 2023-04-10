using Microsoft.EntityFrameworkCore;

namespace DatabaseApplication.DatabaseLogic
{
    public class databaseDbContext:DbContext
    {
        public databaseDbContext(DbContextOptions<databaseDbContext> options) : base(options)
        {

        }
        /*public DbSet<UserModel> userModels { get; set; }*/
    }
}
