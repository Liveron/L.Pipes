namespace L.Pipes.Abstractions;

public interface IPipeContext
{
    public object Payload { get; set; }
}

public interface IPipeContext<T> : IPipeContext
{
    public new T Payload { get; set; }
}
