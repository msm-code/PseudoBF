using PseudoBF.CodeDom;
using System.Linq;
using PseudoBF.MachineModel;

namespace PseudoBF.Compilation
{
    public class Compiler
    {
        private CustomSubroutine FindEntrySubroutine(ProgramModel program)
        {
            const string entryName = "main";
            return program.Subroutines.OfType<CustomSubroutine>().First((sub) => sub.Name == entryName);
        }

        public void CompileOnMachine(ProgramModel program, IMachine executor)
        {
            CustomSubroutine entry = FindEntrySubroutine(program);

            CompilerContext compiler = new CompilerContext(executor);
            compiler.Compile(entry);
        }
    }
}
