namespace DependencyInjectionSingletonScopedTransient.Service
{
    public class TransientService : ITransientService
    {
        private readonly string _operationId;

        public TransientService()
        {
            _operationId = Guid.NewGuid().ToString();
        }

        public string GetOperationId()
        {
            return _operationId;
        }
    }
}
