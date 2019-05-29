using System;

namespace src.Services
{
    public interface ITransientService : IService
    {
         
    }

    public class TransientService : ITransientService
    {
        public TransientService()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}