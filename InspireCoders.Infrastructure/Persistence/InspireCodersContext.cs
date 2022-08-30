using InspireCoders.Domain.Common;
using InspireCoders.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InspireCoders.Infrastructure.Persistence
{
    public class InspireCodersContext : DbContext
    {
        public InspireCodersContext(DbContextOptions<InspireCodersContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Facilitator> Facilitators { get; set; }
        public DbSet<Forum> Forums { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        // entry.Entity.CreatedBy = "swn";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        // entry.Entity.LastModifiedBy = "swn";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
