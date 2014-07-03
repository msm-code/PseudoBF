using PseudoBF.CodeDom;
using System.Collections.Generic;
using PseudoBF.MachineModel;
using PseudoBF.Builtins;
using PseudoBF.Compilation.Operations;
using PseudoBF.CodeInfrastructure;
using System.Linq;

namespace PseudoBF.Compilation
{
    static class HighLevelActionPolicies
    {
        internal static void Assignment(CompilerContext compiler, Assignment assignment)
        {
            compiler.Executor.Comment("Assign {0} to {1}", assignment.Source, assignment.Destination);
            CopyValue(compiler, assignment.Destination, assignment.Source);
        }

        internal static void If(CompilerContext compiler, If p)
        {
            compiler.Executor.Comment("If {0} then {1} else {2}", p.Test, p.CodeIf, p.CodeElse);
            IfHelper.ProcessIf(compiler, p);
        }

        internal static void While(CompilerContext compiler, While p)
        {
            compiler.Executor.Comment("While {0} do {1}", p.Test, p.Body);
            throw new System.NotImplementedException("Nie chciało mi się na razie :(");
        }

        internal static void Return(CompilerContext compiler, Return _return)
        {
            compiler.Executor.Comment("Return {0}", _return.Value);
            CopyValue(compiler, compiler.Stack.CurrentFrame.ReturnValue, _return.Value);
        }

        internal static void Print(CompilerContext compiler, Print print)
        {
            compiler.Executor.Comment("Print {0}", print.Text);

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
            var paramString = string.Join(", ", call.Parameters.Select(x => x.ToString()));
            compiler.Executor.Comment("Call {0} ({1})", call.Subroutine, paramString);

            call.Subroutine.Compile(compiler, call.Parameters);
        }

        private static void CopyValue(CompilerContext compiler, VariableName destination, IValueProvider source)
        {
            compiler.Executor.Comment("{0} <- {1}", destination, source);

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
