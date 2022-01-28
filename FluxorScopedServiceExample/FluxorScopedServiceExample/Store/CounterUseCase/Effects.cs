using Fluxor;

namespace FluxorScopedServiceExample.Store.CounterUseCase;

public class Effects
{
    private readonly ScopedService _scopedService;

    public Effects(ScopedService scopedService)
    {
        _scopedService = scopedService;
    }

    [EffectMethod]
    public Task HandleIncrementCounterAction(IncrementCounterAction action, IDispatcher dispatcher)
    {
        Console.WriteLine(_scopedService.Id);
        return Task.CompletedTask;
    }
}
