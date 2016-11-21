using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonCreatedListener
{
    public class PersonCreatedContext : DbContext, IPersonCreatedContext
    {
        public PersonCreatedContext()
        {

        }

        public DbSet<PersonCreated> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder
                .Entity<PersonCreated>()
                .Property(p => p.Id)
                .ValueGeneratedNever();
        }
    }
}
