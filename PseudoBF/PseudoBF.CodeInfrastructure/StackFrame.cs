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
        List<IInMemoryData> variables;
        IInMemoryData returnValue;
        int oryginalSize;

        public StackFrame(StackContext stack, Subroutine subroutine)
        {
            startLocation = stack.UsedCells;
            variables = new List<IInMemoryData>();
            // subroutine.Arguments.Cast<Variable>().ToList();
            throw new System.NotImplementedException();
            this.Subroutine = subroutine;
            this.oryginalSize = variables.Count;
            //returnValue = new Variable();
            throw new System.NotImplementedException();
            this.variables.Add(ReturnValue);
        }

        public Subroutine Subroutine
        { get; private set; }

        public Location GetVariableLocation(IInMemoryData var)
        {
            return new Location(variables.IndexOf(var));
        }

        public int Size
        { get { return oryginalSize; } }

        public IInMemoryData ReturnValue
        { get { return returnValue; } }

        public Location ReturnValueLocation
        { get { return new Location(variables.IndexOf(returnValue)); } }

        public void AddData(IInMemoryData data)
        { this.variables.Add(data); }

        public void AddData(List<IInMemoryData> data)
        { this.variables.AddRange(data); }

        /*public void AllocateExistingVariables(List<Variable> newVariables)
        {
            this.variables.AddRange(newVariables);
        }

        public List<Variable> AllocateNewVariables(int count)
        {
            List<Variable> locals = new List<Variable>();
            for (int i = 0; i < count; i++)
            {
                Variable var = new Variable();
                locals.Add(var);
            }

            this.variables.AddRange(locals);

            return locals;
        }

        public Variable AllocateNewVariable()
        { return AllocateNewVariables(1)[0]; }
        
        public List<Location> AllocateNewVariablesAndGetLocations(int count)
        {
            return AllocateNewVariables(count).Select((x) => GetVariableLocation(x as Variable)).ToList();
        }

        public Location AllocateNewVariableAndGetLocation()
        { return AllocateNewVariablesAndGetLocations(1)[0]; }*/

        public void FreeVariables(int count)
        {
            this.variables.RemoveRange(variables.Count - count, count);
        }
    }
}
