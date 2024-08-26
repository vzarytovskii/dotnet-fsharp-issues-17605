namespace _17605;

public interface IThird<out TSecond> where TSecond : IThird<TSecond>
{
    internal static abstract int Metadata { get; }
}

public interface ISecond<out TSecond> : IThird<TSecond> where TSecond : ISecond<TSecond>
{
    protected static abstract TSecond Create(int _);
}

public interface IFirst<TFirst> : ISecond<TFirst> where TFirst : IFirst<TFirst>
{
    protected new static abstract int Metadata { get; }
    protected static abstract TFirst Create(string initializer);
    protected new static abstract TFirst Create(int initializer);
    protected static abstract TFirst Create(decimal initializer);
}