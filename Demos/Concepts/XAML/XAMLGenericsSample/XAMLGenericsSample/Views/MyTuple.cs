namespace XAMLGenericsSample.Views;

public class MyTuple<T1, T2>
    where T1 : notnull
    where T2 : notnull
{
    public T1 Item1 { get; set; }

    public T2 Item2 { get; set; }

    public override string ToString()
    {
        string t1Name = typeof(T1).Name;
        string t2Name = typeof(T2).Name;

        return 
            $"MyTuple<{t1Name}, {t2Name}>({Item1}, {Item2})";
    }
}
