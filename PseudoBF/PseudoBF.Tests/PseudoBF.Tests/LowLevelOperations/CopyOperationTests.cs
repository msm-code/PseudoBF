using NUnit.Framework;
using PseudoBF.Compilation;
using PseudoBF.Compilation.Operations;
using PseudoBF.CodeDom;
using System.Collections.Generic;
using PseudoBF.Tests.BuiltinFunctions;
using Brainfuck;
using PseudoBF.MachineModel;
using PseudoBF.CodeInfrastructure;

namespace PseudoBF.Tests.LowLevelOperations
{
    [TestFixture]
    class CopyOperationTests
    {
        ExecutorMachine exec;

        [SetUp]
        public void Setup()
        {
            exec = new ExecutorMachine();
        }

        [Test, Sequential]
        public void TestCopy([Values(5, 2, 0)]byte value1, [Values(2, 0, 3)]byte value2)
        {
            Location loc1 = new Location(0);
            Location loc2 = new Location(1);
            Location hlpLoc = new Location(2);

            exec.Set(loc1, value1);
            exec.Set(loc2, value2);
            exec.Copy(loc1, loc2, hlpLoc);

            exec.Execute();

            N.Eq(value2, exec.GetCell(loc1.InternalPosition));
            N.Eq(value2, exec.GetCell(loc2.InternalPosition));
        }
    }
}
