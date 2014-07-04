using PseudoBF.MachineModel;
using PseudoBF.CodeDom;
using System.Collections.Generic;
using PseudoBF.CodeInfrastructure;
using PseudoBF.Compilation.Operations;

namespace PseudoBF.Compilation
{
    public class CompilerContext
    {
        IMachine executor;
        StackContext stackState;

        public IMachine Executor
        { get { return executor; } }

        public StackContext Stack
        { get { return stackState; } }

        public CompilerContext(IMachine executor)
        {
            this.stackState = new StackContext();
            this.executor = executor;
        }

        public void Compile(CustomSubroutine subroutine)
        {
            if (stackState.InContext(subroutine))
            {
                throw new System.InvalidOperationException("Invalid recursive call");
            }

            stackState.Enter(subroutine);
            stackState.CurrentFrame.AllocateExistingVariables(subroutine.Locals);

            var oldLoc = executor.Location;
            executor.OverrideLocation(Location.Zero);
            Compile(subroutine.Code);
            executor.MoveTo(new Location(subroutine.Locals.Count));
            executor.OverrideLocation(oldLoc);

            stackState.Exit(subroutine);
        }

        public void Compile(CodeBlock code)
        {
            for (int i = 0; i < code.Count; i++)
            {
                var statement = code[i];
                switch (statement.Type)
                {
                    case StatementType.Assignment:
                        HighLevelActionPolicies.Assignment(this, (Assignment)statement);
                        break;
                    case StatementType.Call:
                        HighLevelActionPolicies.Call(this, (Call)statement);
                        break;
                    case StatementType.If:
                        HighLevelActionPolicies.If(this, (If)statement);
                        break;
                    case StatementType.While:
                        HighLevelActionPolicies.While(this, (While)statement);
                        break;
                    case StatementType.Return:
                        if (i != code.Count - 1)
                        { throw new System.InvalidOperationException("Return have to be last operation in subroutine"); }
                        HighLevelActionPolicies.Return(this, (Return)statement);
                        break;
                    case StatementType.Print:
                        HighLevelActionPolicies.Print(this, (Print)statement);
                        break;
                    default:
                        throw new System.InvalidOperationException("Unknown type of operation");
                }
            }
        }
    }
}
