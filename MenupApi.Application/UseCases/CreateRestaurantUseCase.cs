using MenupApi.Domain;
using MenupApi.Infrastructure;

namespace MenupApi.Application;

public class CreateRestaurantUseCase
{
    private readonly IRestaurantRepository _restaurantRepository;
    
    public CreateRestaurantUseCase(IRestaurantRepository restaurantRepository)
    {
        _restaurantRepository = restaurantRepository;
    }
    
    public async Task<Restaurant> ExecuteAsync(CreateRestaurantDto createRestaurantDto)
    {
        var restaurant = new Restaurant
        {
            Name = createRestaurantDto.Name,
            City = createRestaurantDto.City,
            Complement = createRestaurantDto.Complement,
            Logo = createRestaurantDto.Logo,
            Number = createRestaurantDto.Number,
            Phone = createRestaurantDto.Phone,
            State = createRestaurantDto.State,
            Street = createRestaurantDto.Street,
            IsWhatsappPhone = createRestaurantDto.IsWhatsappPhone,
        };
        var createdRestaurant = await _restaurantRepository.CreateRestaurant(restaurant);
        return createdRestaurant;
    }
}
