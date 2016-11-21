using Microsoft.EntityFrameworkCore;

namespace PersonCreatedListener
{
    public interface IPersonCreatedContext
    {
        DbSet<PersonCreated> Persons { get; }

        int SaveChanges();
    }
}
