using InteriorDesignStudioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace InteriorDesignStudioApi.Context;

public class UserStudioContext : DbContext
{
    public UserStudioContext(DbContextOptions<UserStudioContext> options) : base(options)
    {
        
    }
    
    public DbSet<OrderModel> Orders { get; set; }
}