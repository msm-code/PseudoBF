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

    public class Number : IValueProvider 
    {
        public Number(byte numericValue)
        {
            this.NumericValue = numericValue;
        }

        public byte NumericValue { get; private set; }

        public ValueType Type
        {
            get { return ValueType.Number; }
        }

        public override bool Equals(object obj)
        {
            return (obj != null && obj.GetType() == typeof(Number) && ((Number)obj).NumericValue == this.NumericValue);
        }

        public override int GetHashCode()
        {
            return NumericValue.GetHashCode();
        }
    }

    public class VariableName : IValueProvider
    {
        public VariableName(string variableId)
        {
            this.VariableId = variableId;
        }

        public string VariableId { get; private set; }

        public ValueType Type
        {
            get { return ValueType.Variable; }
        }

        public override bool Equals(object obj)
        {
            return (obj != null && obj.GetType() == typeof(VariableName) && ((VariableName)obj).VariableId == this.VariableId);
        }

        public override int GetHashCode()
        {
            return VariableId.GetHashCode();
        }
    }
}
