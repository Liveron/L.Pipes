namespace L.Pipes.Abstractions;

public interface IPipe
{
    Task ExecuteAsync(IPipeContext context);
}
