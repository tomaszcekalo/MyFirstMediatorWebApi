using MediatR;
using MyFirstMediatorWebApi.POCO;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MyFirstMediatorWebApi.Handlers
{
    public class MyFirstNotificationHandler : INotificationHandler<MyFirstNotification>
    {
        public async Task Handle(MyFirstNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification.Message);
        }
    }
}