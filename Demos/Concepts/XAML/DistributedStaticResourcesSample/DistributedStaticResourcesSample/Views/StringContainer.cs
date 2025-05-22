namespace DistributedStaticResourcesSample.Views;

public class StringContainer
{
    public string? Str { get; set; }

    public override string ToString()
    {
        return $"Contains '{Str}'";
    }
}
