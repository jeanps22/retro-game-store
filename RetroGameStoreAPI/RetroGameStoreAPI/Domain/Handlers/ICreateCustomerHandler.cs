using RetroGameStoreAPI.Domain.Commands.Requests;
using RetroGameStoreAPI.Domain.Commands.Responses;

namespace RetroGameStoreAPI.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
