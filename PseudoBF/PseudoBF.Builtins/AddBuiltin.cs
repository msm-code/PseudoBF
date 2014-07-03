using PseudoBF.Compilation.Operations;
using System.Collections.Generic;
using PseudoBF.CodeDom;
using PseudoBF.MachineModel;
using PseudoBF.CodeInfrastructure;
using PseudoBF.Data;

namespace PseudoBF.Builtins
{
    public class AddBuiltin : IOperation
    {
        IValueProvider value1;
        IValueProvider value2;
        StackFrame stack;

        public AddBuiltin(IValueProvider var1, IValueProvider var2, StackFrame stack)
        {
            this.value1 = var1;
            this.value2 = var2;
            this.stack = stack;
        }

        public void Execute(IMachine machine)
        {
            /*
            if (value1.Type == ValueType.Number && value2.Type == ValueType.Number)
            {
                AddTwoNumbers((Number)value1, (Number)value2, machine);
            }
            else if (value1.Type == ValueType.Number && value2.Type == ValueType.Variable)
            {
                AddNumberToVariable((Number)value1, (Variable)value2, machine);
            }
            else if (value1.Type == ValueType.Variable && value2.Type == ValueType.Number)
            {
                AddNumberToVariable((Number)value2, (Variable)value1, machine);
            }
            else
            {
                AddTwoVariables((Variable)value1, (Variable)value2, machine);
            }
             * */
            throw new System.NotImplementedException();
        }

        private void AddTwoNumbers(Number num1, Number num2, IMachine machine)
        {
            byte result = unchecked((byte)(num1.NumericValue + num2.NumericValue));
            machine.Set(stack.ReturnValueLocation, result);
        }

        private void AddNumberToVariable(Number num, CharData var, IMachine machine)
        {
            /*
            Location varLocation = stack.GetVariableLocation(var);
            Location helper = stack.AllocateNewVariableAndGetLocation();

            machine.Copy(stack.ReturnValueLocation, varLocation, helper);
            machine.Inc(stack.ReturnValueLocation, num.NumericValue);

            stack.FreeVariables(1);*/

            throw new System.NotImplementedException();
        }

        private void AddTwoVariables(CharData data1, CharData data2, IMachine machine)
        {
            /* // x = x + y
             * helper[-]
             * y[x+helper+y-]
             * helper[y+helper-] */
            
            /*Location loc1 = stack.GetVariableLocation(var1); // x
            Location loc2 = stack.GetVariableLocation(var2); // y
            Location helper = stack.AllocateNewVariableAndGetLocation();

            machine.Copy(stack.ReturnValueLocation, loc1, helper);
            machine.Set(helper, 0);

            machine.DecUntilZero(loc2, new[] { stack.ReturnValueLocation, helper }, null );
            machine.DecUntilZero(helper, new[] { loc2 }, null);

            stack.FreeVariables(1);*/

            throw new System.NotImplementedException();
        }
    }
}
