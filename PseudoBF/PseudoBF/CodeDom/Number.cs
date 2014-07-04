namespace PseudoBF.CodeDom
{
    public class Number : IValue
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

        public override string ToString()
        {
            return "[" + NumericValue + "]";
        }
    }
}
