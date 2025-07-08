using InteriorDesignStudioApi.Models;
using InteriorDesignStudioApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InteriorDesignStudioApi.Controller;
[ApiController]
[Route("api/orders")]
public class Controller : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public Controller(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost]
    [Route("SendOrder")]
    public async Task<OrderModel> SendingOrder(OrderModel order)
    {
        return await _userRepository.SendOrder(order);
    }
}