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
}
