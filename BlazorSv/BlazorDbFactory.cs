using Microsoft.EntityFrameworkCore;

namespace BlazorSv
{
    public class BlazorDbFactory<TContext> :IDbContextFactory<TContext> where TContext : DbContext
    {
        public BlazorDbFactory(IServiceProvider provider)
        {
            this.provider = provider;
        }

        private readonly IServiceProvider provider;

        public TContext CreateDbContext()
        {
            return ActivatorUtilities.CreateInstance<TContext>(provider);
        }
    }
}
