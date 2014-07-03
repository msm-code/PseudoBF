using System.Collections.Generic;
using PseudoBF.Compilation;
using System.Linq;

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

        public override void Compile(CompilerContext compiler, List<IValueProvider> parameters)
        {
            compiler.Compile(this);
        }
    }
}
