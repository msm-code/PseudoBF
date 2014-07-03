using NUnit.Framework;
using PseudoBF.Compilation.Operations;
using PseudoBF.MachineModel;
namespace PseudoBF.Tests.LowLevelOperations
{
    [TestFixture]
    class IfElseTests
    {
        ExecutorMachine exec;

        [SetUp]
        public void SetUp()
        {
            exec = new ExecutorMachine();
        }

        [Test]
        public void TestIfFalse()
        {
            exec.Set(new Location(0), 0);
            exec.If(new Location(0), new Location(1), new Location(2),
                () => { exec.Set(new Location(3), 66); });
            exec.Execute();

            N.Eq(0, exec.GetCell(3));
        }

        [Test]
        public void TestIfTrue()
        {
            exec.Set(new Location(0), 1);
            exec.If(new Location(0), new Location(1), new Location(2),
                () => { exec.Set(new Location(3), 66); });
            exec.Execute();

            N.Eq(66, exec.GetCell(3));
        }

        [Test]
        public void TestIfElseFalse()
        {
            exec.Set(new Location(0), 0);
            exec.IfElse(new Location(0), new Location(1), new Location(2),
                () => { exec.Set(new Location(3), 66);},
                () => { exec.Set(new Location(4), 66); });
            exec.Execute();

            N.Eq(0, exec.GetCell(3));
            N.Eq(66, exec.GetCell(4));
        }

        [Test]
        public void TestIfElseTrue()
        {
            exec.Set(new Location(0), 1);
            exec.IfElse(new Location(0), new Location(1), new Location(2),
                () => { exec.Set(new Location(3), 66); },
                () => { exec.Set(new Location(4), 66); });
            exec.Execute();

            N.Eq(66, exec.GetCell(3));
            N.Eq(0, exec.GetCell(4));
        }
    }
}
