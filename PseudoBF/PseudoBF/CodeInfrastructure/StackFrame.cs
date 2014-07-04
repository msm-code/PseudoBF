using System.Collections.Generic;
using PseudoBF.CodeDom;
using System;
using System.Linq;
using PseudoBF.MachineModel;

namespace PseudoBF.CodeInfrastructure
{
    public class StackFrame
    {
        List<VariableName> variables;
        VariableName returnValue;

        public StackFrame(StackContext stack, Subroutine subroutine)
        {
            this.variables = new List<VariableName>();
            this.returnValue = new VariableName();
            this.variables.Add(returnValue);
            this.variables.AddRange(subroutine.Arguments.ToList()); // use .ToList to shallow copy list
            this.Subroutine = subroutine;
        }

        public Subroutine Subroutine
        { get; private set; }

        public Location GetVariableLocation(VariableName var)
        {
            if (!variables.Contains(var))
            {
                throw new ArgumentException("Variable is not allocated");
            }

            var index = variables.LastIndexOf(var);
            return new Location(variables.LastIndexOf(var));
        }

        public VariableName ReturnValue
        { get { return returnValue; } }

        public Location ReturnValueLocation
        { get { return new Location(variables.IndexOf(returnValue)); } }

        public void AddData(VariableName data)
        { this.variables.Add(data); }

        public void AddData(List<VariableName> data)
        { this.variables.AddRange(data); }

        public void AllocateExistingVariables(List<VariableName> newVariables)
        { this.variables.AddRange(newVariables); }

        public List<VariableName> AllocateNewVariables(int count)
        {
            List<VariableName> locals = new List<VariableName>();
            for (int i = 0; i < count; i++)
            {
                VariableName var = new VariableName();
                locals.Add(var);
            }

            this.variables.AddRange(locals);

            return locals;
        }

        public VariableName AllocateNewVariable()
        { return AllocateNewVariables(1)[0]; }

        public List<Location> AllocateNewVariablesAndGetLocations(int count)
        {
            return AllocateNewVariables(count).Select((x) => GetVariableLocation(x as VariableName)).ToList();
        }

        public Location AllocateNewVariableAndGetLocation()
        { return AllocateNewVariablesAndGetLocations(1)[0]; }

        public void FreeVariables(int count)
        {
            this.variables.RemoveRange(variables.Count - count, count);
        }
    }
}
