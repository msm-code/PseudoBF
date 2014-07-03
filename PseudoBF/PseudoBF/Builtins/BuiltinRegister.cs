using PseudoBF.Compilation.Operations;
using System.Collections.Generic;
using PseudoBF.CodeDom;
using System.Linq;
using PseudoBF.CodeInfrastructure;

namespace PseudoBF.Builtins
{
    public static class BuiltinRegister
    {
        private static List<BuiltinSubroutine> builtins;

        static BuiltinRegister()
        {
            builtins = new List<BuiltinSubroutine>();

            builtins.Add(new BuiltinSubroutine((p, s) => new AddBuiltin(p[0], p[1], s),
                "+", "var1", "var2"));
            builtins.Add(new BuiltinSubroutine((p, s) => new PutBuiltin(p[0], s),
                "put", "charecterToPrint"));
            builtins.Add(new BuiltinSubroutine((p, s) => new EqualsBuiltin(p[0], p[1], s),
                "==", "var1", "var2"));
        }

        public static List<Subroutine> Subroutines
        { get { return builtins.Cast<Subroutine>().ToList(); } }

        public static IOperation Get(string name, List<IValueProvider> parameters, StackFrame stack)
        {
            return builtins.Find((x) => x.Name == name).Operation(parameters, stack);
        }
    }
}
