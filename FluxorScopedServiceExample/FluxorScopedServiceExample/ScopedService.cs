namespace FluxorScopedServiceExample
{
    public class ScopedService
    {
        public ScopedService()
        {
            Id = Guid.NewGuid().ToString()[^4..];
        }

        public string Id { get; }
    }
}
