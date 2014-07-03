﻿using PseudoBF.CodeDom;
using System.Collections.Generic;
using System.Linq;
using PseudoBF.Compilation.Operations;
using System;
using PseudoBF.CodeInfrastructure;

namespace PseudoBF.Builtins
{
    class BuiltinSubroutine : Subroutine
    {
        public delegate IOperation GetOpeartion(List<IValueProvider> args, StackFrame stack);

        private GetOpeartion operationGetter;

        public BuiltinSubroutine(SubroutineType type, GetOpeartion operation,
            string name, params string[] variableNames)
            : base(type, name, variableNames.Select((var) => new VariableName(var)).ToList()) 
        {
            this.operationGetter = operation;
        }

        public override ImplementationType ImplType
        {
            get { return ImplementationType.External; }
        }

        public IOperation Operation(List<IValueProvider> variables, StackFrame stack)
        {
            return operationGetter(variables, stack);
        }
    }
}
