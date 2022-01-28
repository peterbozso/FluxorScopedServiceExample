using Fluxor;

namespace FluxorScopedServiceExample.Store.CounterUseCase;

public class Effects
{
    private readonly ScopedService _scopedService;
    private readonly IServiceScopeFactory _scopeFactory;

    public Effects(ScopedService scopedService, IServiceScopeFactory scopeFactory)
    {
        _scopedService = scopedService;
        _scopeFactory = scopeFactory;
    }

    [EffectMethod]
    public Task HandleIncrementCounterAction(IncrementCounterAction action, IDispatcher dispatcher)
    {
        using var scope = _scopeFactory.CreateAsyncScope();
        var trulyScopedService = scope.ServiceProvider.GetRequiredService<ScopedService>();

        Console.WriteLine($"Injected service ID: {_scopedService.Id} Truly scoped service ID: {trulyScopedService.Id}");

        return Task.CompletedTask;
    }
}
