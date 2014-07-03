namespace PseudoBF.CodeDom
{
    public enum ValueType
    {
        Number,
        Variable,
        FunctionCall
    }

    public interface IValueProvider
    {
        ValueType Type { get; }
    }
}
