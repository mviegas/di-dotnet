using System;

namespace src.Services
{
    public class SomeOtherService 
    {
        public IScopedService ScopedService { get; }
        public ITransientService TransientService { get; }
        public ISingletonService SingletonService { get; }

        public SomeOtherService(
            ITransientService transientService,
            IScopedService scopedService,
            ISingletonService singletonService)
        {
            TransientService = transientService;
            ScopedService = scopedService;
            SingletonService = singletonService;
        }
    }
}