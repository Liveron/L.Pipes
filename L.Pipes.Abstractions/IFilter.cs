namespace L.Pipes.Abstractions;

public interface IFilter
{
    Task HandleAsync(IPipeContext context, FilterDelegate next);
}
