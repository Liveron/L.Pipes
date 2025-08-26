namespace L.Pipes.Abstractions;

public interface IPipeContext
{
    public object Payload { get; set; }
}

public interface IPipeContext<T>
{
    public T Payload { get; set; }
}
