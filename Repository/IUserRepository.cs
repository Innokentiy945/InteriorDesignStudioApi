using InteriorDesignStudioApi.Models;

namespace InteriorDesignStudioApi.Repository;

public interface IUserRepository
{
    public Task<OrderModel> SendOrder(OrderModel order);
}