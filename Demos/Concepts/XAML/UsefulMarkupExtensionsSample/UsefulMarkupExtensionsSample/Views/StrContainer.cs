namespace UsefulMarkupExtensionsSample.Views;

public class StrContainer
{
    public string? Str { get; set; } = null;

    public override string ToString()
    {
        return Str ?? "null";
    }
}
