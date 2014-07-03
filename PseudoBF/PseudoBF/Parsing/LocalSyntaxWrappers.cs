using System.Collections.Generic;
using PseudoBF.CodeDom;

namespace PseudoBF.Parsing
{
    internal class VariableList
    {
        public VariableList()
        {
            Arguments = new List<VariableName>();
        }

        public List<VariableName> Arguments { get; set; }
    }

    internal class ValueList
    {
        public ValueList()
        {
            Values = new List<IValueProvider>();
        }

        public List<IValueProvider> Values { get; set; }
    }

    internal class LocalsDef
    {
        public LocalsDef()
        {
            Locals = new List<string>();
        }

        public List<string> Locals { get; set; }
    }
}
