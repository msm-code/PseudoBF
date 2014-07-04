namespace PseudoBF.CodeDom
{
    public enum ValueType
    {
        Number,
        Variable,
        FunctionCall
    }

    public interface IValue
    {
        ValueType Type { get; }
    }
}
