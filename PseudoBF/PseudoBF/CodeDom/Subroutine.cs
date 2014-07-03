using System.Collections.Generic;
using System.Linq;
using PseudoBF.Compilation;
using PseudoBF.CodeInfrastructure;

namespace PseudoBF.CodeDom
{
    public abstract class Subroutine
    {
        public Subroutine(string name, List<VariableName> parameters)
        {
            this.Name = name;
            this.Arguments = parameters;
        }

        public string Name { get; private set; }
        public List<VariableName> Arguments { get; private set; }
        public List<VariableName> Locals { get; protected set; }

        internal virtual void LinkTo(ProgramModel programModel) { }

        public abstract void Compile(CompilerContext compiler, List<IValueProvider> parameters);
    }

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

    public class CodeBlock : List<Statement>
    {
        public CodeBlock(List<Statement> statements)
            : base(statements)
        {
        }
    }
}
