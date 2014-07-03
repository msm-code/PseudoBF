﻿namespace PseudoBF.CodeDom
{
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
