using MediatR;

namespace MyFirstMediatorWebApi.POCO
{
    public class MyFirstRequest : IRequest<string>
    {
        public string Name { get; }

        public MyFirstRequest(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}