using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using azuretest6.Authorization.Roles;
using azuretest6.Authorization.Users;
using azuretest6.MultiTenancy;

namespace azuretest6.EntityFrameworkCore
{
    public class azuretest6DbContext : AbpZeroDbContext<Tenant, Role, User, azuretest6DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public azuretest6DbContext(DbContextOptions<azuretest6DbContext> options)
            : base(options)
        {
        }
    }
}
