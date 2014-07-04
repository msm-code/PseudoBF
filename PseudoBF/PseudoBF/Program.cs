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
function foo(znak, wut, lol, swag, yolo) {
    print(""Function Call"");

    if (znak == 73) {
        print(""OK, YOLO"");
    }
    else {
        print(""nie ma takiego yolo"");
    }

    if (znak == 72) {
        print(""niedobsz swag"");
    }
    else {
        print(""DOBRZE SWAG"");
    }

    znak = znak + wut;
    znak = lol + swag;
    znak = znak + yolo;
}

function main() : locals(a, b, c) {
    a = 70;
    b = a + 3;
    c = a + 10;

    foo(b, 1, 13, 66, 50);
    foo(b, 1, 13, 66, 50);

    if (b == 73) {
        print(""OK, YOLO"");
    }
    else {
        print(""nie ma takiego yolo"");
    }


    if (b == 72) {
        print(""niedobsz swag"");
    }
    else {
        print(""DOBRZE SWAG"");
    }
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
