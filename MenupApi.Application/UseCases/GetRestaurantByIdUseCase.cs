using MenupApi.Domain;
using MenupApi.Infrastructure;

namespace MenupApi.Application;

public class GetRestaurantByIdUseCase
{
    private readonly IRestaurantRepository _restaurantRepository;

    public GetRestaurantByIdUseCase(IRestaurantRepository restaurantRepository)
    {
        _restaurantRepository = restaurantRepository;
    }

    public async Task<Restaurant> ExecuteAsync(int id)
    {
        return await _restaurantRepository.GetRestaurantById(id);
    }
}
