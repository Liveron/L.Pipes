using L.Pipes.Abstractions;

namespace L.Pipes;

public class Pipe
{
    public static async Task ExecuteFiltersAsync(IList<IFilter> filters, IPipeContext context)
    {
        if (filters.Count == 0) 
            return;

        FilterDelegate pipeline = _ => filters.Last()
            .HandleAsync(context, _ => Task.CompletedTask);

        for (int i = filters.Count - 2; i >= 0; i--)
        {
            var index = i;
            var next = pipeline;
            pipeline = async context => await filters[index].HandleAsync(context, next);
        }

        await pipeline(context);
    }
}
