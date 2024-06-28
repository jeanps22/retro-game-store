namespace RetroGameStoreAPI.Domain.Commands.Requests
{
    public class CreateCustomerRequest
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
    }
}
