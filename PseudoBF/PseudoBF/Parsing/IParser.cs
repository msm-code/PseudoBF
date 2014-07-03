using PseudoBF.CodeDom;
using System.Collections.Generic;

namespace PseudoBF.Parsing
{
    public interface IParser
    {
        ProgramModel Parse(string code, List<Subroutine> predefinedSubroutines);
    }
}
