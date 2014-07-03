using PseudoBF.Compilation;
using NUnit.Framework;
using PseudoBF.MachineModel;

namespace PseudoBF.Tests.Compilation
{
    [TestFixture]
    class CompilerMachineTests
    {
        [Test]
        public void Test()
        {
            CompilerMachine machine = new CompilerMachine();

            N.Eq("", machine.CompiledCode);
            N.Eq(new Location(0), machine.Location);

            machine.Inc(3);
            N.Eq("+++", machine.CompiledCode);
            N.Eq(new Location(0), machine.Location);

            machine.Forward(2);
            N.Eq("+++>>", machine.CompiledCode);
            N.Eq(new Location(2), machine.Location);

            machine.Backward(1);
            N.Eq("+++>><", machine.CompiledCode);
            N.Eq(new Location(1), machine.Location);

            machine.BeginConditional();
            machine.Read();
            machine.Print();
            machine.EndConditional();
            N.Eq("+++>><[,.]", machine.CompiledCode);
            N.Eq(new Location(1), machine.Location);

            machine.Reset();
            N.Eq("", machine.CompiledCode);
            N.Eq(new Location(0), machine.Location);
        }
    }
}
