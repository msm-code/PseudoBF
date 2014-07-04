using PseudoBF.CodeDom;
using System.Collections.Generic;
using System.Linq;
using PseudoBF.Compilation.Operations;
using System;
using PseudoBF.CodeInfrastructure;
using PseudoBF.Compilation;

namespace PseudoBF.Builtins
{
    public class BuiltinSubroutine : Subroutine
    {
        public delegate IOperation GetOperation(List<IValue> args, StackFrame stack);

        private GetOperation operationGetter;

        public BuiltinSubroutine(GetOperation operation,
            string name, params string[] variableNames)
            : base(name, variableNames.Select((var) => new VariableName(var)).ToList()) 
        {
            this.operationGetter = operation;
        }

        public IOperation Operation(List<IValue> variables, StackFrame stack)
        {
            return operationGetter(variables, stack);
        }

        public override void Compile(CompilerContext compiler, List<IValue> parameters)
        {
            IOperation bltin = BuiltinRegister.Get(Name, parameters, compiler.Stack.CurrentFrame);
            bltin.Execute(compiler.Executor);
        }
    }
}
