using PseudoBF.CodeDom;
using System.Collections.Generic;
using System.Linq;
using PseudoBF.Compilation;

namespace PseudoBF.Tests.BuiltinFunctions
{
    class MockSubroutine : Subroutine
    {
        public MockSubroutine(string name, List<VariableName> parameters)
            : base(name, parameters) { }

        public static Subroutine Empty
        { get { return new MockSubroutine("MockSubroutine", new List<VariableName>()); } }

        public override void Compile(CompilerContext compiler, List<IValueProvider> parameters)
        { throw new System.NotImplementedException(); }
    }
}
