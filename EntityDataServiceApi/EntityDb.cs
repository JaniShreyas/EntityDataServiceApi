using Microsoft.EntityFrameworkCore;

namespace EntityDataServiceApi;

public class EntityDb: DbContext
{
    public EntityDb(DbContextOptions<EntityDb> options): base(options)
    {

    }

    public DbSet<Entity> Entities => Set<Entity>();
}