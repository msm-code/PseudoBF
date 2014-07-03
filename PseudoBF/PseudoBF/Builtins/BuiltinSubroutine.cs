using PseudoBF.CodeDom;
using System.Collections.Generic;
using System.Linq;
using PseudoBF.Compilation.Operations;
using System;
using PseudoBF.CodeInfrastructure;
using PseudoBF.Compilation;

namespace PseudoBF.Builtins
{
    class BuiltinSubroutine : Subroutine
    {
        public delegate IOperation GetOpeartion(List<IValueProvider> args, StackFrame stack);

        private GetOpeartion operationGetter;

        public BuiltinSubroutine(GetOpeartion operation,
            string name, params string[] variableNames)
            : base(name, variableNames.Select((var) => new VariableName(var)).ToList()) 
        {
            this.operationGetter = operation;
        }

        public IOperation Operation(List<IValueProvider> variables, StackFrame stack)
        {
            return operationGetter(variables, stack);
        }

        public override void Compile(CompilerContext compiler, List<IValueProvider> parameters)
        {
            IOperation bltin = BuiltinRegister.Get(Name, parameters, compiler.Stack.CurrentFrame);
            bltin.Execute(compiler.Executor);
        }
    }
}
