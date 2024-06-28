using Microsoft.AspNetCore.Mvc;
using RetroGameStoreAPI.Domain.Commands.Requests;
using RetroGameStoreAPI.Domain.Commands.Responses;
using RetroGameStoreAPI.Domain.Handlers;

namespace RetroGameStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICreateCustomerHandler _createCustomerHandler;
        public CustomerController(ICreateCustomerHandler createCustomerHandler)
        {
            _createCustomerHandler = createCustomerHandler;
        }

        [HttpPost]
        [Route("")]
        public CreateCustomerResponse CreateCustomer([FromBody] CreateCustomerRequest request)
        {
            return _createCustomerHandler.Handle(request);
        }

    }
}
