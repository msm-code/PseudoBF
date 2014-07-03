using System.Collections.Generic;
using System.Linq;

namespace PseudoBF.CodeDom
{
    public enum SubroutineType
    {
        Function,
        Procedure
    }

    public enum ImplementationType
    {
        Custom,
        External
    }

    public interface IWithLocalVariables
    {
        List<VariableName> Locals { get; }
    }

    public abstract class Subroutine
    {
        public Subroutine(SubroutineType type, string name, List<VariableName> parameters)
        {
            this.Type = type;
            this.Name = name;
            this.Arguments = parameters;
        }

        public SubroutineType Type { get; private set; }
        public string Name { get; private set; }
        public abstract ImplementationType ImplType { get; }
        public List<VariableName> Arguments { get; private set; }

        internal virtual void LinkTo(ProgramModel programModel) { }
    }

    public class CustomSubroutine : Subroutine, IWithLocalVariables
    {
        public CustomSubroutine(SubroutineType type, string name, List<VariableName> parameters, 
            List<VariableName> locals, CodeBlock code)
            :base(type, name, parameters)
        {
            this.Locals = locals.Cast<VariableName>().ToList();
            this.Code = code;
        }

        public List<VariableName> Locals { get; private set; }
        public CodeBlock Code { get; private set; }

        public override ImplementationType ImplType
        {
            get { return ImplementationType.Custom; }
        }

        internal override void LinkTo(ProgramModel programModel)
        {
            foreach (var statement in Code)
            {
                if (statement is ILinkable)
                { (statement as ILinkable).LinkTo(programModel); }
            }
        }
    }

    public class CodeBlock : List<Statement>
    {
        public CodeBlock(List<Statement> statements)
            :base(statements)
        {
        }
    }
}
