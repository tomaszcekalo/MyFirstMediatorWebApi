using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstMediatorWebApi.PipelineBehaviours
{
    public class CachingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private Dictionary<string, TResponse> Cache { get; set; } = new Dictionary<string, TResponse>();

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            var key = request.ToString();
            if (Cache.ContainsKey(key))
            {
                return Cache[key];
            }
            var result = await next();
            Cache.Add(key, result);
            return result;
        }
    }
}