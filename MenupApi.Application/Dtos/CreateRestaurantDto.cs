namespace MenupApi.Application;

public class CreateRestaurantDto
{
    public required string Name { get; set;}
    public required string City { get; set;}
    public required string State { get; set;}
    public required string Street { get; set;}
    public required string Number { get; set;}
    public required string Complement { get; set;}
    public required string Phone { get; set;}
    public Boolean IsWhatsappPhone { get; set;}
    public required string Logo { get; set;}
}
