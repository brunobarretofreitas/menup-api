using MenupApi.Domain;
using MenupApi.Infrastructure;

namespace MenupApi.Application;

public class ListRestaurantsUseCase
{
    private readonly IRestaurantRepository _restaurantsRepository;

    public ListRestaurantsUseCase(IRestaurantRepository restaurantRepository)
    {
        _restaurantsRepository = restaurantRepository;
    }

    public async Task<List<Restaurant>> ExecuteAsync()
    {
        return await _restaurantsRepository.GetRestaurants();
    }
}
