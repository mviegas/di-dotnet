using System;

namespace src.Services
{
    public interface ISingletonService : IService
    {
        
    }

    public class SingletonService : ISingletonService
    {
        public SingletonService()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}