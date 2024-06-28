using MenupApi.Application;
using MenupApi.Domain;
using MenupApi.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace MenupApi.API;


[ApiController]
[Route("restaurants")]
public class RestaurantController : ControllerBase
{
    private readonly ListRestaurantsUseCase _listRestaurantsUseCase;
    private readonly CreateRestaurantUseCase _createRestaurantUseCase;
    private readonly GetRestaurantByIdUseCase _getRestaurantByIdUseCase;

    public RestaurantController(IRestaurantRepository restaurantRepository)
    {
        _listRestaurantsUseCase = new ListRestaurantsUseCase(restaurantRepository);
        _createRestaurantUseCase = new CreateRestaurantUseCase(restaurantRepository);
        _getRestaurantByIdUseCase = new GetRestaurantByIdUseCase(restaurantRepository);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _listRestaurantsUseCase.ExecuteAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        try
        {
            var restaurant = await _getRestaurantByIdUseCase.ExecuteAsync(id);
            return Ok(restaurant);
        }
        catch
        {
            return NotFound(new { detail = "Restaurant not found" });
        }
    }

    [HttpPost]
    public async Task<IActionResult> CreateRestaurant([FromBody] CreateRestaurantDto restaurant)
    {
        var createdRestaurant = await _createRestaurantUseCase.ExecuteAsync(restaurant);
        return CreatedAtAction(nameof(GetById), new { id = createdRestaurant.Id }, createdRestaurant);
    }
}
