using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstMediatorWebApi.PipelineBehaviours
{
    public class TracingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Console.WriteLine($"TracingBehaviour request log:{request.ToString()}.");
            var response = await next();
            Console.WriteLine($"TracingBehaviour response log:{response.ToString()}.");
            return response;
        }
    }
}