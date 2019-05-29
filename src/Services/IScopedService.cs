using System;

namespace src.Services
{
    public interface IScopedService  : IService
    {

    }

    public class ScopedService : IScopedService 
    {
        public ScopedService()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}