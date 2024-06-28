namespace MenupApi.Infrastructure.Exceptions;

public class RestaurantNotFoundException : Exception
{
    public RestaurantNotFoundException(string message)
        : base(message)
    {
    }
}
