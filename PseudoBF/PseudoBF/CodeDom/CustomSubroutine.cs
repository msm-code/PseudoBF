using System.Collections.Generic;
using PseudoBF.Compilation;
using System.Linq;
using PseudoBF.MachineModel;
using PseudoBF.Compilation.Operations;

namespace PseudoBF.CodeDom
{
    public class CustomSubroutine : Subroutine
    {
        public CustomSubroutine(string name, List<VariableName> parameters,
            List<VariableName> locals, CodeBlock code)
            : base(name, parameters)
        {
            this.Locals = locals.Cast<VariableName>().ToList();
            this.Code = code;
        }

        public CodeBlock Code { get; private set; }

        internal override void LinkTo(ProgramModel programModel)
        {
            foreach (var statement in Code)
            {
                if (statement is ILinkable)
                { (statement as ILinkable).LinkTo(programModel); }
            }
        }

        public override void Compile(CompilerContext compiler, List<IValue> parameters)
        {
            var executor = compiler.Executor;
            var frame = compiler.Stack.CurrentFrame;

            var retval = frame.AllocateNewVariableAndGetLocation(); // return value;
            var args = frame.AllocateNewVariables(parameters.Count);
            for (int i = 0; i < parameters.Count; i++)
            {
                HighLevelActionPolicies.CopyValue(compiler, args[i], parameters[i]);
            }

            compiler.Executor.MoveTo(retval);
            compiler.Compile(this);

            frame.FreeVariables(parameters.Count + 1);
        }
    }
}
