namespace L.Pipes.Abstractions;

public interface IFilter
{
    Task HandleAsync(IPipeContext context, FilterDelegate next);
}

public interface IFilter<TContext> : IFilter where TContext : IPipeContext
{
    Task HandleAsync(TContext context, FilterDelegate next);
    async Task IFilter.HandleAsync(IPipeContext context, FilterDelegate next)
    {
        if (context is not TContext typedContext)
            throw new ArgumentException($"Expected context of type {typeof(TContext).FullName}, but received {context.GetType().FullName}.");
        await HandleAsync(typedContext, next);
    }
}
