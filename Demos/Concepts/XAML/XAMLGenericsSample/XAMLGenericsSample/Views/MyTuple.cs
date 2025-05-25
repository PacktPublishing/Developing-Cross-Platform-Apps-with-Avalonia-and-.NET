namespace XAMLGenericsSample.Views;

public class MyTuple<T1, T2>
    where T1 : notnull
    where T2 : notnull
{
    public T1 Item1 { get; set; }

    public T2 Item2 { get; set; }

    public override string ToString()
    {
        return $"MyTuple({typeof(T1).Name}, {typeof(T2).Name}): ({Item1}, {Item2})";
    }
}
