using System.Collections.Generic;
using PseudoBF.CodeDom;
using System;
using System.Linq;
using PseudoBF.MachineModel;

namespace PseudoBF.CodeInfrastructure
{
    public class StackFrame
    {
        int startLocation;
        List<VariableName> variables;
        VariableName returnValue;
        int oryginalSize;

        public StackFrame(StackContext stack, Subroutine subroutine)
        {
            startLocation = stack.UsedCells;
            variables = subroutine.Arguments.ToList(); // use .ToList to shallow copy list
            this.Subroutine = subroutine;
            this.oryginalSize = variables.Count;
            returnValue = new VariableName(null);
            this.variables.Add(ReturnValue);
        }

        public Subroutine Subroutine
        { get; private set; }

        public Location GetVariableLocation(VariableName var)
        {
            return new Location(variables.IndexOf(var));
        }

        public int Size
        { get { return oryginalSize; } }

        public VariableName ReturnValue
        { get { return returnValue; } }

        public Location ReturnValueLocation
        { get { return new Location(variables.IndexOf(returnValue)); } }

        public void AddData(VariableName data)
        { this.variables.Add(data); }

        public void AddData(List<VariableName> data)
        { this.variables.AddRange(data); }

        public void AllocateExistingVariables(List<VariableName> newVariables)
        {
            this.variables.AddRange(newVariables);
        }

        public List<VariableName> AllocateNewVariables(int count)
        {
            List<VariableName> locals = new List<VariableName>();
            for (int i = 0; i < count; i++)
            {
                VariableName var = new VariableName(null);
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
