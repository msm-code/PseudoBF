﻿using NUnit.Framework;
using PseudoBF.Tests.LowLevelOperations;
using PseudoBF.CodeInfrastructure;
using PseudoBF.Builtins;
using PseudoBF.CodeDom;
using PseudoBF.Compilation.Operations;

namespace PseudoBF.Tests.BuiltinFunctions
{
    [TestFixture]
    class EqualsTests
    {
        StackFrame frame;
        ExecutorMachine machine;

        [SetUp]
        public void Setup()
        {
            frame = new StackFrame(new StackContext(), MockSubroutine.Empty);
            machine = new ExecutorMachine();
        }

        [Test, Sequential]
        public void NumberEqualsNumber([Values(5, 0, 2, 4, 0)]byte val1,
            [Values(5, 0, 3, 0, 2)]byte val2,
            [Values(1, 1, 0, 0, 0)]byte result)
        {
            /*
            EqualsBuiltin equals = new EqualsBuiltin(new Number(val1), new Number(val2), frame);
            equals.Execute(machine);
            machine.Execute();

            byte cell = machine.GetCell(frame.ReturnValueLocation.InternalPosition);

            N.Eq(result, cell);*/
            throw new System.NotImplementedException();
        }

        [Test, Sequential]
        public void NumberEqualsVariable([Values(5, 0, 2, 4, 0)]byte val1,
            [Values(5, 0, 3, 0, 2)]byte val2,
            [Values(1, 1, 0, 0, 0)]byte result)
        {
            /*
            Variable var = frame.AllocateNewVariable();
            machine.Set(frame.GetVariableLocation(var), val1);

            EqualsBuiltin equals = new EqualsBuiltin(var, new Number(val2), frame);
            equals.Execute(machine);
            machine.Execute();

            byte cell = machine.GetCell(frame.ReturnValueLocation.InternalPosition);

            frame.FreeVariables(1);

            N.Eq(result, cell);*/
            throw new System.NotImplementedException();
        }

        [Test, Sequential]
        public void VariableEqualsVariable([Values(5, 0, 2, 4, 0)]byte val1,
            [Values(5, 0, 3, 0, 2)]byte val2,
            [Values(1, 1, 0, 0, 0)]byte result)
        {
            /*
            Variable var1 = frame.AllocateNewVariable();
            Variable var2 = frame.AllocateNewVariable();
            machine.Set(frame.GetVariableLocation(var1), val1);
            machine.Set(frame.GetVariableLocation(var2), val2);

            EqualsBuiltin equals = new EqualsBuiltin(var1, var2, frame);
            equals.Execute(machine);
            machine.Execute();

            byte cell = machine.GetCell(frame.ReturnValueLocation.InternalPosition);

            frame.FreeVariables(1);

            N.Eq(result, cell);*/
            throw new System.NotImplementedException();
        }
    }
}
