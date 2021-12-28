using Microsoft.EntityFrameworkCore;

namespace BlazorSv
{
    public interface IDbContextFactory<TContext> where TContext : DbContext
    {
        TContext CreateDbContext();
    }
}
