
using MenupApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace MenupApi.Infrastructure;

public class RestaurantRepository : IRestaurantRepository
{
    private readonly MenupDbContext _dbContext;

    public RestaurantRepository(MenupDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Restaurant>> GetRestaurants()
    {
        return await _dbContext.Restaurants.ToListAsync();
    }

    public async Task<Restaurant> CreateRestaurant(Restaurant restaurant)
    {
        await _dbContext.Restaurants.AddAsync(restaurant);
        await _dbContext.SaveChangesAsync();
        return restaurant;
    }
}
