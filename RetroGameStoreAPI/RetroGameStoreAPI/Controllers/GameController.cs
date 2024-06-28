using MediatR;
using Microsoft.AspNetCore.Mvc;
using RetroGameStoreAPI.Domain.Commands.Requests;
using RetroGameStoreAPI.Domain.Commands.Responses;

namespace RetroGameStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        [HttpPost]
        public Task<CreateGameResponse> CreateGame([FromBody] CreateGameRequest request, [FromServices] IMediator mediator)
        {
            return mediator.Send(request);
        }
    }
}
