﻿using PseudoBF.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace PseudoBF.Tests.BuiltinFunctions
{
    class MockSubroutine : Subroutine
    {
        public MockSubroutine(SubroutineType type, string name, List<VariableName> parameters)
            : base(type, name, parameters) { }

        public override ImplementationType ImplType
        {
            get { return ImplementationType.External; }
        }

        public static Subroutine Empty
        { get { return new MockSubroutine(SubroutineType.Function, "MockSubroutine", new List<VariableName>()); } }
    }
}