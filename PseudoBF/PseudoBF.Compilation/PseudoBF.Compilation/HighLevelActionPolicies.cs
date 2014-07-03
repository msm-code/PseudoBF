using PseudoBF.CodeDom;
using System.Collections.Generic;
using PseudoBF.MachineModel;
using PseudoBF.Builtins;
using PseudoBF.Compilation.Operations;
using PseudoBF.CodeInfrastructure;
using PseudoBF.Data;

namespace PseudoBF.Compilation
{
    static class HighLevelActionPolicies
    {
        internal static void Assignment(CompilerContext compiler, Assignment assignment)
        {
            //CopyValue(compiler, assignment.Destination, assignment.Source);
            throw new System.NotImplementedException();
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
            //CopyValue(compiler, compiler.Stack.CurrentFrame.ReturnValue, _return.Value);
            throw new System.NotImplementedException();
        }

        internal static void Print(CompilerContext compiler, Print print)
        {
            /*string text = print.Text;
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
            }*/
            throw new System.NotImplementedException();
        }

        internal static void Call(CompilerContext compiler, Call call)
        {
            if (call.Subroutine.ImplType == ImplementationType.Custom)
            {
                compiler.Compile(call.Subroutine);
                //throw new System.NotImplementedException();
            }
            else if (call.Subroutine.ImplType == ImplementationType.External)
            {
                IOperation bltin = BuiltinRegister.Get(call.Subroutine.Name, call.Parameters, compiler.Stack.CurrentFrame);
                bltin.Execute(compiler.Executor);
            }
            else
            { throw new System.ArgumentException("Unknown subroutine type"); }
        }

        private static void CopyValue(CompilerContext compiler, CharData destination, IValueProvider source)
        {
            /*
            StackFrame frame = compiler.Stack.CurrentFrame;
            IMachine machine = compiler.Executor;
            Location loc = frame.GetVariableLocation(destination);
            if (source.Type == ValueType.Number)
            {
                machine.Set(loc, (source as Number).NumericValue);
            }
            else if (source.Type == ValueType.Variable)
            {
                Location var2loc = frame.GetVariableLocation(source as Variable);
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
            }*/
            throw new System.NotImplementedException();
        }
    }
}
