using PseudoBF.CodeDom;
using System.Collections.Generic;
using PseudoBF.MachineModel;
using PseudoBF.Builtins;
using PseudoBF.Compilation.Operations;
using PseudoBF.CodeInfrastructure;

namespace PseudoBF.Compilation
{
    static class HighLevelActionPolicies
    {
        internal static void Assignment(CompilerContext compiler, Assignment assignment)
        {
            CopyValue(compiler, assignment.Destination, assignment.Source);
        }

        internal static void If(CompilerContext compiler, If p)
        {
            IfHelper.ProcessIf(compiler, p);
        }

        internal static void While(CompilerContext compiler, While p)
        {
            throw new System.NotImplementedException("Nie chciało mi się na razie :(");
        }

        internal static void Return(CompilerContext compiler, Return _return)
        {
            CopyValue(compiler, compiler.Stack.CurrentFrame.ReturnValue, _return.Value);
        }

        internal static void Print(CompilerContext compiler, Print print)
        {
            string text = print.Text;
            IMachine machine = compiler.Executor;

            Location temp = compiler.Stack.CurrentFrame.AllocateNewVariableAndGetLocation();
            machine.Set(temp, 0);
            byte last = 0;

            foreach (char c in text)
            {
                byte curr = (byte)c;
                int diff = curr - last;

                if (diff > 0)
                { machine.Inc(diff); machine.Print(); }
                else
                { machine.Dec(-diff); machine.Print(); }

                last = curr;
            }
        }

        internal static void Call(CompilerContext compiler, Call call)
        {
            call.Subroutine.Compile(compiler, call.Parameters);
        }

        private static void CopyValue(CompilerContext compiler, VariableName destination, IValueProvider source)
        {
            StackFrame frame = compiler.Stack.CurrentFrame;
            IMachine machine = compiler.Executor;
            Location loc = frame.GetVariableLocation(destination);
            if (source.Type == ValueType.Number)
            {
                machine.Set(loc, (source as Number).NumericValue);
            }
            else if (source.Type == ValueType.Variable)
            {
                Location var2loc = frame.GetVariableLocation(source as VariableName);
                Location helper = frame.AllocateNewVariableAndGetLocation();
                machine.Copy(loc, var2loc, helper);
                frame.FreeVariables(1);
            }
            else if (source.Type == ValueType.FunctionCall)
            {
                Location helper = frame.AllocateNewVariableAndGetLocation();
                Call(compiler, (source as Call));
                machine.Copy(loc, frame.ReturnValueLocation, helper);
                frame.FreeVariables(1);
            }
        }
    }
}
