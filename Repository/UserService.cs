using InteriorDesignStudioApi.Context;
using InteriorDesignStudioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace InteriorDesignStudioApi.Repository;

public class UserService : IUserRepository
{
    private UserStudioContext _context;
    private ILogger<UserService> _logger;

    public UserService(UserStudioContext context, ILogger<UserService> logger)
    {
        _context = context;
        _logger = logger;
    }
    
    public async Task<OrderModel> SendOrder(OrderModel order)
    {
        _logger.LogInformation("Preparing order!");
        var result = await _context.AddAsync(order);
        
        try
        {
            _logger.LogInformation("Order sent!");
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        catch(Exception ex)
        {
            _logger.LogError(ex.Message);
            throw;
        }
        
    }
}