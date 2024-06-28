namespace RetroGameStoreAPI.Domain.Commands.Responses
{
    public class CreateCustomerResponse
    {
        public Guid? IdCustomer { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
    }
}
