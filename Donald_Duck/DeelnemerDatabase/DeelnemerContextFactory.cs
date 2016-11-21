using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeelnemerDatabase
{
    public class DeelnemerContextFactory : IDbContextFactory<DeelnemerContext>
    {
        public DeelnemerContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<DeelnemerContext>()
            .UseSqlServer(@"Server=.\SQLEXPRESS;Database=JeroenDonaldDuckDeelnemers;Trusted_Connection=True");

            return new DeelnemerContext(builder.Options);
        }
        
    }
}
