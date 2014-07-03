using PseudoBF.CodeDom;
using PseudoBF.MachineModel;
using PseudoBF.Compilation.Operations;
using PseudoBF.CodeInfrastructure;

namespace PseudoBF.Builtins
{
    class PutBuiltin : IOperation
    {
        IValueProvider value;
        StackFrame stack;

        public PutBuiltin(IValueProvider value, StackFrame stack)
        {
            this.value = value;
            this.stack = stack;
        }

        public void Execute(IMachine machine)
        {
            Location putLoc;

            if (value.Type == ValueType.Number)
            {
                putLoc = stack.AllocateNewVariableAndGetLocation();
                machine.Set(putLoc, (value as Number).NumericValue);
            }
            else if (value.Type == ValueType.Variable)
            {
                putLoc = stack.GetVariableLocation(value as VariableName);
            }
            else
            { throw new System.ArgumentException("Unsupported argument"); }

            machine.MoveTo(putLoc);
            machine.Print();

            if (value.Type == ValueType.Number)
            {
                stack.FreeVariables(1);
            }

            throw new System.NotImplementedException();
        }
    }
}
