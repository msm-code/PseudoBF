﻿using NUnit.Framework;
using PseudoBF.Parsing;
using PseudoBF.CodeDom;
using System.Collections.Generic;
using PseudoBF.Compilation;
using PseudoBF.Builtins;

namespace PseudoBF.Tests.Parsing
{
    [TestFixture]
    class ParserTests
    {
        IParser parser;
        List<Subroutine> predefinedFuncSet;

        [SetUp]
        public void Setup()
        {
            parser = ParserFactory.Create();
            predefinedFuncSet = BuiltinRegister.Subroutines;
        }

        [Test]
        public void TestSimpleFunc()
        {
            string code = "function foo() { }";
            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(0, model.Subroutines[0].Arguments.Count);
            N.Eq(0, ((CustomSubroutine)model.Subroutines[0]).Code.Count);
            N.Eq(0, ((CustomSubroutine)model.Subroutines[0]).Locals.Count);
            N.Eq("foo", model.Subroutines[0].Name);
        }

        [Test]
        public void TestLocals()
        {
            string code = "procedure qwerty() :locals(bar) { }";
            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(1, ((CustomSubroutine)model.Subroutines[0]).Locals.Count);
            N.Eq("bar", (((CustomSubroutine)model.Subroutines[0]).Locals[0] as VariableName).VariableId);
        }

        [Test]
        public void TestArguments()
        {
            string code = "function asdf(zxc, vbn) { }";
            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(2, model.Subroutines[0].Arguments.Count);
            N.Eq("zxc", ((CustomSubroutine)model.Subroutines[0]).Arguments[0].VariableId);
            N.Eq("vbn", ((CustomSubroutine)model.Subroutines[0]).Arguments[1].VariableId);
        }

        [Test]
        public void TestAssignment()
        {
            string code = @"procedure name()
{
    dst = src;
}";
            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(1, ((CustomSubroutine)model.Subroutines[0]).Code.Count);

            Assignment st1 = (Assignment)((CustomSubroutine)model.Subroutines[0]).Code[0];
            N.Eq(StatementType.Assignment, st1.Type);
            N.Eq("dst", (st1.Destination as VariableName).VariableId);
            N.Eq(ValueType.Variable, st1.Source.Type);
            N.Eq("src", ((VariableName)st1.Source).VariableId);
        }

        [Test]
        public void TestFunctionCall()
        {
            string code = @"procedure name()
{
    put(foo);
}";

            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(1, ((CustomSubroutine)model.Subroutines[0]).Code.Count);

            Call st2 = (Call)((CustomSubroutine)model.Subroutines[0]).Code[0];
            N.Eq(StatementType.Call, st2.Type);
            N.Eq("put", st2.Subroutine.Name);
            N.Eq("foo", ((VariableName)st2.Parameters[0]).VariableId);
        }

        [Test]
        public void TestReturn()
        {
            string code = @"procedure name()
{
    return ret_val;
}";
            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(1, ((CustomSubroutine)model.Subroutines[0]).Code.Count);

            Return st3 = (Return)((CustomSubroutine)model.Subroutines[0]).Code[0];
            N.Eq(StatementType.Return, st3.Type);
            N.Eq(ValueType.Variable, st3.Value.Type);
            N.Eq("ret_val", ((VariableName)st3.Value).VariableId);
        }

        [Test]
        public void TestIf()
        {
            string code = @"procedure xxx()
{
    if (a == 3)
    {
        return true;
    };
}";

            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(1, ((CustomSubroutine)model.Subroutines[0]).Code.Count);

            If st3 = (If)((CustomSubroutine)model.Subroutines[0]).Code[0];
            N.Eq(StatementType.If, st3.Type);
            N.Eq(1, st3.CodeIf.Count);
            Call test = (Call)st3.Test;
            N.Eq("==", test.Subroutine.Name);
            N.Eq(2, test.Parameters.Count);
        }

        [Test]
        public void TestElse()
        {
            string code = @"procedure xxx()
{
    if (a == 3)
    {
        return 1;
    }
    else
    {
        return 2;
    };
}";

            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(1, ((CustomSubroutine)model.Subroutines[0]).Code.Count);

            If st3 = (If)((CustomSubroutine)model.Subroutines[0]).Code[0];
            N.Eq(StatementType.If, st3.Type);
            N.Eq(1, st3.CodeIf.Count);
            Call test = (Call)st3.Test;
            N.Eq("==", test.Subroutine.Name);
            N.Eq(2, test.Parameters.Count);
            N.Eq(1, st3.CodeElse.Count);
            N.Eq(StatementType.Return, st3.CodeElse[0].Type);
        }

        [Test]
        public void TestWhile()
        {
            string code = @"function yyy()
{
    while(true == false)
    {
        false = true;
    }
}";

            ProgramModel model = parser.Parse(code, predefinedFuncSet);
            N.Eq(1, ((CustomSubroutine)model.Subroutines[0]).Code.Count);

            While wh = (While)((CustomSubroutine)model.Subroutines[0]).Code[0];
            Call test = (Call)wh.Test;
            N.Eq("true", ((VariableName)test.Parameters[0]).VariableId);
            N.Eq("false", ((VariableName)test.Parameters[1]).VariableId);
            N.Eq("==", test.Subroutine.Name);
            N.Eq(1, wh.Body.Count);
        }

        [Test]
        public void TestCustomSubroutine()
        {
            string code = @"function custom(foo)
{
    return 2;
}

function main(bar)
{
    custom(baz);
    return 3;
}";

            ProgramModel model = parser.Parse(code, predefinedFuncSet);

            CustomSubroutine custom = (CustomSubroutine)model.Subroutines.Find((x) => x.Name == "custom");
            CustomSubroutine main = (CustomSubroutine)model.Subroutines.Find((x) => x.Name == "main");

            N.Eq(1, custom.Code.Count);
            N.Eq(1, custom.Arguments.Count);

            N.Eq(2, main.Code.Count);
            N.Eq(1, custom.Arguments.Count);

            Call customCall = (Call)main.Code[0];

            N.Eq(custom, customCall.Subroutine);
            N.Eq("baz", (customCall.Parameters[0] as VariableName).VariableId);
        }
    }
}
