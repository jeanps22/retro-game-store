using MediatR;
using RetroGameStoreAPI.Domain.Commands.Responses;

namespace RetroGameStoreAPI.Domain.Commands.Requests
{
    public class CreateGameRequest : IRequest<CreateGameResponse>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
