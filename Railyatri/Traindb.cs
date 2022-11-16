using Microsoft.EntityFrameworkCore;

namespace Railyatri
{
    public class Traindb:DbContext
    {

        public DbSet<Trainslist> Trainslist { get; set; }
        public DbSet<TrainSchedule> TrainSchedule { get; set; }

        public DbSet<AvailabilitySchedule> AvailabilitySchedule { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TrainDb;Trusted_Connection=True;");
        }
    }
}
