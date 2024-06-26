using MenupApi.Domain;

namespace MenupApi.Infrastructure;

public interface IRestaurantRepository
{
    public Task<List<Restaurant>> GetRestaurants();
    public Task<Restaurant> CreateRestaurant(Restaurant restaurant);
}
