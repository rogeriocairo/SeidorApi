using Microsoft.EntityFrameworkCore;
using SeidorApi.Core.Entities;

namespace SeidorApi.Infra.Data;

public class DbaContext : DbContext
{
    

    public DbaContext(IConfiguration configuration)
    {
        
    }

    //public DbaContext(DbContextOptions<DbaContext> options)
    //: base(options)
    //{
    //}    

    //public DbSet<UserEntity> Users { get; set; }


    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer(
    //        @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
    //}

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<UserEntity>().ToTable("Usuario");

    //    modelBuilder.ApplyConfiguration(new MegaSenaMap());
    //    modelBuilder.ApplyConfiguration(new EventLogMap());
    //}

    //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    //{
    //    int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

    //    var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
    //        .Select(e => e.Entity)
    //        .ToArray();

    //    return result;
    //}

    //public override int SaveChanges()
    //{
    //    return SaveChangesAsync().GetAwaiter().GetResult();
    //}
}