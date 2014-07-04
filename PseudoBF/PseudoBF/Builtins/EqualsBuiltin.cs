using PseudoBF.CodeDom;
using PseudoBF.MachineModel;
using PseudoBF.Compilation.Operations;
using PseudoBF.CodeInfrastructure;

namespace PseudoBF.Builtins
{
    public class EqualsBuiltin : IOperation
    {
        IValue value1;
        IValue value2;
        StackFrame stack;

        public EqualsBuiltin(IValue data1, IValue data2, StackFrame stack)
        {
            this.value1 = data1;
            this.value2 = data2;
            this.stack = stack;
        }

        public void Execute(IMachine machine)
        {
            if (value1.Type == ValueType.Number && value2.Type == ValueType.Number)
            {
                TwoNumbersEquals((Number)value1, (Number)value2, machine);
            }
            else if (value1.Type == ValueType.Number && value2.Type == ValueType.Variable)
            {
                NumberEqualsVariable((Number)value1, (VariableName)value2, machine);
            }
            else if (value1.Type == ValueType.Variable && value2.Type == ValueType.Number)
            {
                NumberEqualsVariable((Number)value2, (VariableName)value1, machine);
            }
            else
            {
                TwoVariablesEquals((VariableName)value1, (VariableName)value2, machine);
            }
        }

        private void TwoNumbersEquals(Number number1, Number number2, IMachine machine)
        {
            if (number1.NumericValue == number2.NumericValue)
            {
                machine.Set(stack.ReturnValueLocation, 1);
            }
            else
            {
                machine.Set(stack.ReturnValueLocation, 0);
            }
        }

        private void NumberEqualsVariable(Number number, VariableName variable, IMachine machine)
        {
            Location temp0 = stack.AllocateNewVariableAndGetLocation();
            Location varLoc = stack.GetVariableLocation(variable);

            machine.Copy(stack.ReturnValueLocation, varLoc, temp0);
            machine.Dec(stack.ReturnValueLocation, (byte)number.NumericValue);

            Location temp1 = stack.AllocateNewVariableAndGetLocation();
            machine.IfElse(stack.ReturnValueLocation, temp0, temp1,
                () => { machine.Set(stack.ReturnValueLocation, 0); },
                () => { machine.Set(stack.ReturnValueLocation, 1); });

            stack.FreeVariables(2);
        }

        private void TwoVariablesEquals(VariableName variable1, VariableName variable2, IMachine machine)
        {
            Location loc1 = stack.GetVariableLocation(variable1);
            Location loc2 = stack.GetVariableLocation(variable2);
            Location temp0 = stack.AllocateNewVariableAndGetLocation();
            Location temp1 = stack.AllocateNewVariableAndGetLocation();

            machine.Copy(stack.ReturnValueLocation, loc1, temp0);

            machine.Set(temp0, 0);
            machine.Set(temp1, 0);
            machine.DecUntilZero(stack.ReturnValueLocation, new[] { temp1 }, null);
            machine.Inc(stack.ReturnValueLocation);

            machine.DecUntilZero(loc2, new[] { temp0 }, new[] { temp1 });
            machine.DecUntilZero(temp0, new[] { loc2 }, null);

            machine.While(temp1, () =>
            {
                machine.Dec(stack.ReturnValueLocation);
                machine.Set(temp1, 0);
            });

            stack.FreeVariables(2);
        }
    }
}
