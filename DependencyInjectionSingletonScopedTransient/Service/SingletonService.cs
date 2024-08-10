namespace DependencyInjectionSingletonScopedTransient.Service
{
    public class SingletonService : ISingletonService
    {
        private readonly string _operationId;

        public SingletonService()
        {
            _operationId = Guid.NewGuid().ToString();
        }

        public string GetOperationId()
        {
            return _operationId;
        }
    }
}
