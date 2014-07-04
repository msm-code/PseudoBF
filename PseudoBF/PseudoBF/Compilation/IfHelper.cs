using PseudoBF.CodeDom;
using PseudoBF.MachineModel;
using PseudoBF.Compilation.Operations;
using PseudoBF.CodeInfrastructure;

namespace PseudoBF.Compilation
{
    class IfHelper
    {
        public static void ProcessIf(CompilerContext compiler, If p)
        {
            if (p.Test.Type == ValueType.Number)
            {
                if ((p.Test as Number).NumericValue != 0)
                { compiler.Compile(p.CodeIf); }
                else
                { compiler.Compile(p.CodeElse); }
            }
            else if (p.Test.Type == ValueType.Variable)
            {
                ProcessVariableIf(compiler, (p.Test as VariableName), p.CodeIf, p.CodeElse);
            }
            else if (p.Test.Type == ValueType.FunctionCall)
            {
                HighLevelActionPolicies.Call(compiler, p.Test as Call);
                ProcessVariableIf(compiler, compiler.Stack.CurrentFrame.ReturnValue, p.CodeIf, p.CodeElse);
            }
            else
            { throw new System.NotImplementedException(); }
        }

        private static void ProcessVariableIf(CompilerContext compiler, VariableName test,
            CodeBlock codeIf, CodeBlock codeElse)
        {
            Location varLoc = compiler.Stack.CurrentFrame.GetVariableLocation(test as VariableName);
            Location temp0 = compiler.Stack.CurrentFrame.AllocateNewVariableAndGetLocation();
            Location temp1 = compiler.Stack.CurrentFrame.AllocateNewVariableAndGetLocation();
            if (codeElse.Count == 0)
            {
                compiler.Executor.If(varLoc, temp0, temp1, () =>
                {
                    compiler.Compile(codeIf);
                });
            }
            else
            {
                compiler.Executor.IfElse(varLoc, temp0, temp1,
                    () =>
                    {
                        compiler.Executor.Comment("If true");
                        compiler.Compile(codeIf);
                    },
                    () =>
                    {
                        compiler.Executor.Comment("If false");
                        compiler.Compile(codeElse);
                    });
            }
        }
    }
}
