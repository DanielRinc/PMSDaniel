using Microsoft.EntityFrameworkCore;
using WebApplication5.Entities;

namespace WebApplication5.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        public DbSet<reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<reserva>().HasData(new reserva
            {
                Num_reserva = "OYH432"
            });
            modelBuilder.Entity<reserva>().HasData(new reserva
            {
                Num_reserva = "RDH567"
            });
            modelBuilder.Entity<reserva>().HasData(new reserva
            {
                Num_reserva = "CVB71"
            });
        }


    }
}
