namespace DependencyInjectionSingletonScopedTransient.Service
{
    public class ScopedService : IScopedService
    {
        private readonly string _operationId;

        public ScopedService()
        {
            _operationId = Guid.NewGuid().ToString();
        }

        public string GetOperationId()
        {
            return _operationId;
        }

    }
}
