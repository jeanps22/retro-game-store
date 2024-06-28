namespace RetroGameStoreAPI.Domain.Commands.Responses
{
    public class CreateGameResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
