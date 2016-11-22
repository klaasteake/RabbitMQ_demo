using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DeelnemerDatabase
{
    public class DeelnemerContext : DbContext, IDeelnemerContext
    {
        public DeelnemerContext(DbContextOptions<DeelnemerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PersonCreated>()
                .Property(p => p.Id)
                .ValueGeneratedNever();
        }

        public DbSet<PersonCreated> Deelnemers { get; set; }
    }
}
