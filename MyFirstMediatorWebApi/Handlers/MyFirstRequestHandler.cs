using MediatR;
using MyFirstMediatorWebApi.POCO;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstMediatorWebApi.Handlers
{
    public class MyFirstRequestHandler : IRequestHandler<MyFirstRequest, string>
    {
        public async Task<string> Handle(MyFirstRequest request, CancellationToken cancellationToken)
        {
            return $"Hello {request.Name}";
        }
    }
}