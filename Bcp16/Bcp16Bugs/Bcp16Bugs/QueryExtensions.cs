[ExtendObjectType("Query")]
public class QueryExtensions
{
    public Foo Foo(string id) => new Foo(id);
    public Foo[] Foos(FoosInput input) => input.Ids.Select(id => new Foo(id)).ToArray();
}

public record Foo(string Id);
public record FoosInput(string[] Ids);