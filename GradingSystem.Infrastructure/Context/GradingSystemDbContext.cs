using Microsoft.EntityFrameworkCore;
using GradingSystem.Domain.Entities;
using GradingSystem.Infrastructure.Context.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.Infrastructure.Context
{
    public interface IGradingSystemDbContext : IDisposable
    {
        public DbSet<T> GetDbSet<T>() where T : BaseEntity;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
    public class GradingSystemDbContext : DbContext, IGradingSystemDbContext
    {
        public DbSet<T> GetDbSet<T>() where T : BaseEntity => Set<T>();

        public DbSet<Score> Score { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<List> List { get; set; }
        public DbSet<DayList> DayList { get; set; }






        public GradingSystemDbContext(DbContextOptions<GradingSystemDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(type.ClrType))
                {
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
                }
            }
        }

        public void SetAuditEntities()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State != EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.Deleted = true;
                }
            }
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
