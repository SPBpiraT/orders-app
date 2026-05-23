using System.Reflection;
using Orders.Web.Entities;
using Microsoft.EntityFrameworkCore;

namespace Orders.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        public void SeedData()
        {
            if (Orders.Any()) return;

            Orders.AddRange(
                new Order
                {
                    SenderCity = "Москва",
                    SenderAddress = "ул. Ленина, д. 10, оф. 5",
                    RecipientCity = "Санкт-Петербург",
                    RecipientAddress = "Невский пр., д. 25, кв. 12",
                    CargoWeightKg = 15.5m,
                    PickDate = DateTimeOffset.UtcNow
                },
                new Order
                {
                    SenderCity = "Санкт-Петербург",
                    SenderAddress = "Невский пр., д. 25, кв. 12",
                    RecipientCity = "Москва",
                    RecipientAddress = "ул. Ленина, д. 10, оф. 5",
                    CargoWeightKg = 25.5m,
                    PickDate = DateTimeOffset.UtcNow
                }
            );

            SaveChanges();
        }
    }
}
