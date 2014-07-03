using PseudoBF.Parsing;
using PseudoBF.CodeDom;
using PseudoBF.Compilation;
using PseudoBF.Builtins;
using System;
using System.Collections.Generic;

namespace PseudoBF
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = @"
function foo(znak) {
    print(""Function called!"");

    if (znak == 73) {
        print(""Przekazano znak 'I'"");
    }
    else {
        print(""Nie przekazano znaku 'I'"");
    }
}

function main() : locals(a, b) {
    a = 70;
    b = a + 3;

    if (b == 73) {
        print(""Przekazano znak 'I'"");
    }
    else {
        print(""Nie przekazano znaku 'I'"");
    }

    foo(b);
}";

            IParser parser = ParserFactory.Create();
            List<Subroutine> builtins = BuiltinRegister.Subroutines;
            ProgramModel model = parser.Parse(code, builtins);
            Compiler compiler = new Compiler();
            CompilerMachine machine = new CompilerMachine();
            compiler.CompileOnMachine(model, machine);

            Console.WriteLine(machine.CompiledCode);
            Console.ReadKey(true);
        }
    }
}
