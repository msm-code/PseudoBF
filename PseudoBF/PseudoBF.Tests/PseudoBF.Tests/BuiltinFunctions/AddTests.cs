using NUnit.Framework;
using PseudoBF.CodeDom;
using System.Collections.Generic;
using PseudoBF.Compilation;
using Brainfuck;
using PseudoBF.Compilation.Operations;
using PseudoBF.Builtins;
using PseudoBF.CodeInfrastructure;
using PseudoBF.Tests.LowLevelOperations;

namespace PseudoBF.Tests.BuiltinFunctions
{
    [TestFixture]
    class AddTests
    {
        StackFrame frame;
        ExecutorMachine machine;

        [SetUp]
        public void Setup()
        {
            var subroutine = MockSubroutine.Empty;
            this.frame = new StackFrame(new StackContext(), subroutine);
            this.machine = new ExecutorMachine();
        }

        [Test, Sequential]
        public void AddNumberToNumberTests([Values(2, 5, 0, 0)]byte num1,
            [Values(3, 0, 6, 0)]byte num2,
            [Values(5, 5, 6, 0)]byte result)
        {
            AddBuiltin add = new AddBuiltin(new Number(num1), new Number(num2), frame);

            add.Execute(machine);
            machine.Execute();
            byte cell = machine.GetCell(frame.ReturnValueLocation.InternalPosition);

            N.Eq(result, cell);
        }

        [Test, Sequential]
        public void AddNumberToVariableTests([Values(2, 5, 0, 0)]byte num1,
            [Values(3, 0, 6, 0)]byte num2,
            [Values(5, 5, 6, 0)]byte result)
        {
            /*
            Variable var = frame.AllocateNewVariable();
            AddBuiltin add = new AddBuiltin(new Number(num1), var, frame);

            machine.Set(frame.GetVariableLocation(var), num2);
            add.Execute(machine);
            machine.Execute();
            byte cell = machine.GetCell(frame.ReturnValueLocation.InternalPosition);

            frame.FreeVariables(1);

            N.Eq(result, cell);*/
            throw new System.NotImplementedException();
        }

        [Test, Sequential]
        public void AddVariableToVariableTests([Values(2, 5, 0, 0)]byte num1,
            [Values(3, 0, 6, 0)]byte num2,
            [Values(5, 5, 6, 0)]byte result)
        {
            /*
            Variable var1 = frame.AllocateNewVariable();
            Variable var2 = frame.AllocateNewVariable();
            AddBuiltin add = new AddBuiltin(var1, var2, frame);

            machine.Set(frame.GetVariableLocation(var1), num1);
            machine.Set(frame.GetVariableLocation(var2), num2);
            add.Execute(machine);
            machine.Execute();
            byte cell = machine.GetCell(frame.ReturnValueLocation.InternalPosition);

            frame.FreeVariables(2);

            N.Eq(result, cell);*/
            throw new System.NotImplementedException();
        }
    }
}
