using System;
using NUnit.Framework;
using Brainfuck;

namespace PseudoBF.Tests.BrainfuckInterpreter
{
    [TestFixture]
    class InterpreterTests
    {
        private const int TestSize = 15;

        [Test]
        public void TestInit()
        {
            BrainfuckMachine machine = new BrainfuckMachine(TestSize);
            for (int i = 0; i <TestSize; i++)
            {
                N.Eq(machine.GetCell(i), 0);
            }

            byte[] bytes = machine.GetCurrentState();
            for (int i = 0; i < TestSize; i++)
            {
                N.Eq(bytes[i], 0);
            }
        }

        [Test]
        public void TestSimple()
        {
            BrainfuckMachine machine = new BrainfuckMachine(TestSize);

            N.Eq(0, machine.GetCell(0));
            N.Eq(0, machine.HeadLocation);

            machine.Execute("+");
            N.Eq(1, machine.GetCell(0));

            machine.Execute("-");
            N.Eq(0, machine.GetCell(0));

            machine.Execute(">");
            N.Eq(1, machine.HeadLocation);

            machine.Execute("<");
            N.Eq(0, machine.HeadLocation);
        }

        [Test]
        public void TestConditional()
        {
            BrainfuckMachine machine = new BrainfuckMachine(TestSize);

            machine.Execute("+++++");
            N.Eq(5, machine.GetCell(0));
            N.Eq(0, machine.GetCell(1));

            machine.Execute("[->+<]");
            N.Eq(0, machine.GetCell(0));
            N.Eq(5, machine.GetCell(1));
        }
    }
}
