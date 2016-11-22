using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;

namespace DeelnemerDatabase
{
    public interface IDeelnemerContext
    {
        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
        DbSet<PersonCreated> Deelnemers { get; set; }
    }
}