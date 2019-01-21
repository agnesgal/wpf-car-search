using System.Data.Entity;

namespace DataAccess
{
    public class CarDBContext : DbContext
    {
        public CarDBContext() : base("name=CarDBEntities") { }
        public DbSet<Car> Cars { get; set; }
    }
}
