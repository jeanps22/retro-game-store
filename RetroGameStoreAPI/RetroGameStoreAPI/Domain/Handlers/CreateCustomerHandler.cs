using RetroGameStoreAPI.Domain.Commands.Requests;
using RetroGameStoreAPI.Domain.Commands.Responses;

namespace RetroGameStoreAPI.Domain.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            return new CreateCustomerResponse()
            {
                Document = request.Document,
                Name = request.Name,
                IdCustomer = Guid.NewGuid()
        };
        }
    }
}
