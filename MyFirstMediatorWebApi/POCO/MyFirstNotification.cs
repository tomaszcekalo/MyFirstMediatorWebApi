using MediatR;

namespace MyFirstMediatorWebApi.POCO
{
    public class MyFirstNotification : INotification
    {
        public string Message { get; }
        public MyFirstNotification(string message)
        {
            Message = message;
        }
    }
}