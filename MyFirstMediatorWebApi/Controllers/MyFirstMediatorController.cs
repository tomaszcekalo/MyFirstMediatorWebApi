using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyFirstMediatorWebApi.POCO;
using System.Threading.Tasks;

namespace MyFirstMediatorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyFirstMediatorController : ControllerBase
    {
        private IMediator _mediator;

        public MyFirstMediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("SendNotification")]
        public async Task SendNotification(string message)
        {
            await _mediator.Publish(new MyFirstNotification(message));
        }

        [HttpGet]
        [Route("SendRequest")]
        public async Task<string> SendRequest(string name)
        {
            var result = await _mediator.Send(new MyFirstRequest(name));
            return result;
        }
    }
}