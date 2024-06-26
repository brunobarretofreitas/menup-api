namespace MenupApi.Domain;

public class Restaurant
{
    public int Id { get; set;}
    public required string Name { get; set;}
    public required string City { get; set;}
    public required string State { get; set;}
    public required string Street { get; set;}
    public required string Number { get; set;}
    public required string Complement { get; set;}
    public required string Phone { get; set;}
    public Boolean IsWhatsappPhone { get; set;}
    public required string Logo { get; set;}
    public Schedule? WeeklySchedule { get; set; }
}

public class Schedule
{
    public int Id { get; set;}
    public ICollection<OpeningHours>? DailyHours { get; }
}

public class OpeningHours
{
    public int Id { get; set; }
    public DayOfWeek Day { get; set; }
    public TimeSpan OpeningTime { get; set; }
    public TimeSpan ClosingTime { get; set; }
    public int ScheduleId { get; set; }
    public required Schedule Schedule { get; set; }
}
