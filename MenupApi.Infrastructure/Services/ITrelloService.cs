namespace MenupApi.Infrastructure;

public interface ITrelloService
{
    public Task CreateCard(string boardId, string cardName);
}
