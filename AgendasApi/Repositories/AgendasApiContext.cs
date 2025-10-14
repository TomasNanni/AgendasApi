using AgendasApi.Entities;
using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;

namespace AgendasApi.Repositories
{
    public class AgendasApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public AgendasApiContext(DbContextOptions<AgendasApiContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User luis = new User()
            {
                Id = 1,
                FirstName = "Tomas",
                LastName = "nanni",
                Password = "contraseña",
                Email= "miemail",
                State = Models.State.Active,
            };

            modelBuilder.Entity<User>().HasData(luis);

            base.OnModelCreating(modelBuilder);
        }
    }
}
