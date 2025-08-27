namespace L.Pipes.Abstractions;

public interface IPipeContext
{
    public object Payload { get; set; }
}

public interface IPipeContext<T> : IPipeContext where T : notnull
{
    public new T Payload { get; set; }
}
