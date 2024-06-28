using MediatR;
using RetroGameStoreAPI.Domain.Commands.Requests;
using RetroGameStoreAPI.Domain.Commands.Responses;

namespace RetroGameStoreAPI.Domain.Handlers
{
    public class CreateGameHandler : IRequestHandler<CreateGameRequest, CreateGameResponse>
    {
        public Task<CreateGameResponse> Handle(CreateGameRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateGameResponse()
            {
                Id = 1,
                Name = request.Name,
                Price = request.Price
            };

            return Task.FromResult(result);
        }
    }
}
